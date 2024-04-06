using System;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos.DataBase
{
    public class ClsDataBase
    {
        #region Variables privadas

        private SqlConnection _objSqlConnection;
        private SqlDataAdapter _objSqlDataAdapter;
        private SqlCommand _objSqlCommand;
        private DataSet _dsResultados;
        private DataTable _dtParametros;
        private string _nombreTabla, _nombreSP, _mensajeErrorDB, _valorScalar, _nombreDB;
        private bool _scalar;



        #endregion


        #region Variables publicas

        public SqlConnection ObjSqlConnection { get => _objSqlConnection; set => _objSqlConnection = value; }
        public SqlDataAdapter ObjSqlDataAdapter { get => _objSqlDataAdapter; set => _objSqlDataAdapter = value; }
        public SqlCommand ObjSqlCommand { get => _objSqlCommand; set => _objSqlCommand = value; }
        public DataSet ObjResultados { get => _dsResultados; set => _dsResultados = value; }
        public DataTable ObjParametros { get => _dtParametros; set => _dtParametros = value; }
        public string NombreTabla { get => _nombreTabla; set => _nombreTabla = value; }
        public string NombreSP { get => _nombreSP; set => _nombreSP = value; }
        public string MensajeErrorDB { get => _mensajeErrorDB; set => _mensajeErrorDB = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public string NombreDB { get => _nombreDB; set => _nombreDB = value; }
        public bool Scalar { get => _scalar; set => _scalar = value; }
        // public object DsResultados { get; set; }


        #endregion

        #region Constructores
        public ClsDataBase()
        {
           _dtParametros = new DataTable("SpParametros");
            _dtParametros.Columns.Add("Nombre");
            _dtParametros.Columns.Add("TipoDato");
            _dtParametros.Columns.Add("Valor");

            NombreDB = "DB_BasePruebas";

        }
        #endregion

        #region Metodos privados

        private void CrearConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            switch (ObjDataBase.NombreDB) 
            {
                case "DB_BasePruebas":
                    ObjDataBase.ObjSqlConnection = new SqlConnection(Properties.Settings.Default.cadenaConexion_DB_BasePruebas);
                    break;
                default:
                    break;
            }
        }

        private void ValidarConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            if (ObjDataBase.ObjSqlConnection.State == ConnectionState.Closed)
            {
                ObjDataBase.ObjSqlConnection.Open();
            }
            else
            {
                ObjDataBase.ObjSqlConnection.Close();
                ObjDataBase.ObjSqlConnection.Dispose();
            }
        }

        private void AgregarParametros(ref ClsDataBase ObjDataBase)
        {
            if (ObjDataBase._dtParametros != null)
            {
                SqlDbType TipoDatoSQL = new SqlDbType();

                foreach (DataRow item in ObjDataBase._dtParametros.Rows)
                {
                    switch (item[1])
                    {
                        case "1":
                            TipoDatoSQL = SqlDbType.Bit;
                            break;
                        case "2":
                            TipoDatoSQL = SqlDbType.TinyInt;
                            break;
                        case "3":
                            TipoDatoSQL = SqlDbType.SmallInt;
                            break;
                        case "4":
                            TipoDatoSQL = SqlDbType.Int;
                            break;
                        case "5":
                            TipoDatoSQL = SqlDbType.BigInt;
                            break;
                        case "6":
                            TipoDatoSQL = SqlDbType.Decimal;
                            break;
                        case "7":
                            TipoDatoSQL = SqlDbType.SmallMoney;
                            break;
                        case "8":
                            TipoDatoSQL = SqlDbType.Money;
                            break;
                        case "9":
                            TipoDatoSQL = SqlDbType.Float;
                            break;
                        case "10":
                            TipoDatoSQL = SqlDbType.Real;
                            break;
                        case "11":
                            TipoDatoSQL = SqlDbType.Date;
                            break;
                        case "12":
                            TipoDatoSQL = SqlDbType.Time;
                            break;
                        case "13":
                            TipoDatoSQL = SqlDbType.SmallDateTime;
                            break;
                        case "14":
                            TipoDatoSQL = SqlDbType.Date;
                            break;
                        case "15":
                            TipoDatoSQL = SqlDbType.Char;
                            break;
                        case "16":
                            TipoDatoSQL = SqlDbType.NChar;
                            break;
                        case "17":
                            TipoDatoSQL = SqlDbType.VarChar;
                            break;
                        case "18":
                            TipoDatoSQL = SqlDbType.NVarChar;
                            break;
                        default:
                            break;
                    }

                    if (ObjDataBase.Scalar)
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            ObjDataBase.ObjSqlCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = DBNull.Value;
                        }
                        else
                        {
                            ObjDataBase.ObjSqlCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = item[2].ToString();
                        }
                    }
                    else
                    {
                        if (item[2].ToString().Equals(string.Empty))
                        {
                            ObjDataBase.ObjSqlDataAdapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = DBNull.Value;
                        }
                        else
                        {
                            ObjDataBase.ObjSqlDataAdapter.SelectCommand.Parameters.Add(item[0].ToString(), TipoDatoSQL).Value = item[2].ToString();
                        }
                    }
                }
            }
        }

        private void PrepararConexionBaseDatos(ref ClsDataBase ObjDataBase)
        {
            CrearConexionBaseDatos(ref ObjDataBase);
            ValidarConexionBaseDatos(ref ObjDataBase);
        }

        private void EjecutarDataAdapter(ref ClsDataBase ObjDataBase)
        {
            try
            {
                PrepararConexionBaseDatos(ref ObjDataBase);
                ObjDataBase.ObjSqlDataAdapter = new SqlDataAdapter(ObjDataBase.NombreSP, ObjDataBase.ObjSqlConnection);
                ObjDataBase.ObjSqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                AgregarParametros(ref ObjDataBase);
                ObjDataBase._dsResultados = new DataSet();
                ObjDataBase.ObjSqlDataAdapter.Fill(ObjDataBase._dsResultados, ObjDataBase.NombreTabla);
            }
            catch (Exception ex)
            {
                ObjDataBase.MensajeErrorDB = ex.Message.ToString();
            }
            finally
            {
                if (ObjDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionBaseDatos(ref ObjDataBase);
                }
            }
        }

        private void EjecutarCommand(ref ClsDataBase ObjDataBase)
        {
            try
            {
                PrepararConexionBaseDatos(ref ObjDataBase);
                ObjDataBase.ObjSqlCommand = new SqlCommand(ObjDataBase.NombreSP, ObjDataBase.ObjSqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                AgregarParametros(ref ObjDataBase);

                if (ObjDataBase.Scalar)
                {
                    ObjDataBase.ValorScalar = ObjDataBase.ObjSqlCommand.ExecuteScalar().ToString().Trim();
                }
                else
                {
                    ObjDataBase.ObjSqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ObjDataBase.MensajeErrorDB = ex.Message.ToString();
            }
            finally
            {
                if (ObjDataBase.ObjSqlConnection.State == ConnectionState.Open)
                {
                    ValidarConexionBaseDatos(ref ObjDataBase);
                }
            }
        }


        #endregion

        #region Metodos publicos

        public void CRUD(ref ClsDataBase ObjDataBase)
        {
            if (ObjDataBase.Scalar)
            {
                EjecutarCommand(ref ObjDataBase);
            }
            else
            {
                EjecutarDataAdapter(ref ObjDataBase);
            }
        }

        #endregion
    }
}
