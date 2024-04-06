using System;
using System.Data;

namespace Entidades.Usuarios
{
    public class ClsUsuario
    {
        #region Atributos privados

        private byte _IdUsuario;
        private string _Nombre, _Apellido1, _Apellido2, _Correo, _Cargo;
        private DateTime _FechaNacimiento;
        private bool _EsAdmin;

        // atributos de manejo de la base de datos

        private string _mensajeError, _valorScalar;
        private DataTable _dtResultados;



        #endregion

        #region Atributos publicos
        public byte IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido1 { get => _Apellido1; set => _Apellido1 = value; }
        public string Apellido2 { get => _Apellido2; set => _Apellido2 = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Cargo { get => _Cargo; set => _Cargo = value; }
        public DateTime FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public bool EsAdmin { get => _EsAdmin; set => _EsAdmin = value; }
        public string MensajeError { get => _mensajeError; set => _mensajeError = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }

        #endregion
    }
}
