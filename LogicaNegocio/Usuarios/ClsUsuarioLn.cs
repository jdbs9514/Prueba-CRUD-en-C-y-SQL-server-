using AccesoDatos.DataBase;
using Entidades.Usuarios;
using System;
using System.Data;

namespace LogicaNegocio.Usuarios
{
    public class ClsUsuarioLn
    {

        #region Variables privadas

        private ClsDataBase ObjDataBase = null;

        #endregion

        #region Metodo index

        public void Index(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Usuarios",
                NombreSP = "[SCH_GENERAL].[SP_Usuarios_Index]",
                Scalar = false
            };
            Ejecutar(ref ObjUsuario);
        }

        #endregion

        #region CRUD Usuario

        public void Create(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Usuarios",
                NombreSP = "[SCH_GENERAL].[SP_Usuarios_Create]",
                Scalar = true
            };

            ObjDataBase.ObjParametros.Rows.Add(@"@Nombre", "17", ObjUsuario.Nombre);
            ObjDataBase.ObjParametros.Rows.Add(@"@Apellido1", "17", ObjUsuario.Apellido1);
            ObjDataBase.ObjParametros.Rows.Add(@"@Apellido2", "17", ObjUsuario.Apellido2);
            ObjDataBase.ObjParametros.Rows.Add(@"@Correo", "17", ObjUsuario.Correo);
            ObjDataBase.ObjParametros.Rows.Add(@"@FechaNacimiento", "13", ObjUsuario.FechaNacimiento);
            ObjDataBase.ObjParametros.Rows.Add(@"@Cargo", "17", ObjUsuario.Cargo);
            ObjDataBase.ObjParametros.Rows.Add(@"@EsAdmin", "1", ObjUsuario.EsAdmin);

            Ejecutar(ref ObjUsuario);
        }

        public void Read(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Usuarios",
                NombreSP = "[SCH_GENERAL].[SP_Usuarios_Read]",
                Scalar = false
            };

            ObjDataBase.ObjParametros.Rows.Add(@"@IdUsuario", "2", ObjUsuario.IdUsuario);

            Ejecutar(ref ObjUsuario);
        }

        public void Update(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Usuarios",
                NombreSP = "[SCH_GENERAL].[SP_Usuarios_Update]",
                Scalar = true
            };

            ObjDataBase.ObjParametros.Rows.Add(@"@IdUsuario", "2", ObjUsuario.IdUsuario);
            ObjDataBase.ObjParametros.Rows.Add(@"@Nombre", "17", ObjUsuario.Nombre);
            ObjDataBase.ObjParametros.Rows.Add(@"@Apellido1", "17", ObjUsuario.Apellido1);
            ObjDataBase.ObjParametros.Rows.Add(@"@Apellido2", "17", ObjUsuario.Apellido2);
            ObjDataBase.ObjParametros.Rows.Add(@"@Correo", "17", ObjUsuario.Correo);
            ObjDataBase.ObjParametros.Rows.Add(@"@FechaNacimiento", "13", ObjUsuario.FechaNacimiento);
            ObjDataBase.ObjParametros.Rows.Add(@"@Cargo", "17", ObjUsuario.Cargo);
            ObjDataBase.ObjParametros.Rows.Add(@"@EsAdmin", "1", ObjUsuario.EsAdmin);

            Ejecutar(ref ObjUsuario);
        }

        public void Delete(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Usuarios",
                NombreSP = "[SCH_GENERAL].[SP_Usuarios_Delete]",
                Scalar = true
            };

            ObjDataBase.ObjParametros.Rows.Add(@"@IdUsuario", "2", ObjUsuario.IdUsuario);

            Ejecutar(ref ObjUsuario);
        }

        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsUsuario ObjUsuario)
        {
            ObjDataBase.CRUD(ref ObjDataBase);

            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjUsuario.ValorScalar = ObjDataBase.ValorScalar;
                }
                else
                {
                    ObjUsuario.DtResultados = ObjDataBase.ObjResultados.Tables[0];
                    if (ObjUsuario.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjUsuario.DtResultados.Rows)
                        {
                            ObjUsuario.IdUsuario = Convert.ToByte(item["IdUsuario"].ToString());
                            ObjUsuario.Nombre = item["Nombre"].ToString();
                            ObjUsuario.Apellido1 = item["Apellido1"].ToString();
                            ObjUsuario.Apellido2 = item["Apellido2"].ToString();
                            ObjUsuario.Correo = item["Correo"].ToString();
                            ObjUsuario.FechaNacimiento = Convert.ToDateTime(item["FechaNacimiento"].ToString());
                            ObjUsuario.Cargo = item["Cargo"].ToString();
                            ObjUsuario.EsAdmin = Convert.ToBoolean(item["EsAdmin"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjUsuario.MensajeError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion

    }
}

