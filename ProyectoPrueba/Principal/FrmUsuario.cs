using Entidades.Usuarios;
using LogicaNegocio.Usuarios;
using ProyectoPrueba.Utilidades;
using System;
using System.Windows.Forms;

namespace ProyectoPrueba.Principal
{
    public partial class FrmUsuario : Form
    {

        private ClsUsuario ObjUsuario = null;
        private readonly ClsUsuarioLn ObjUsuarioLn = new ClsUsuarioLn();
        private ClsUtilidades ObjUtilidades = new ClsUtilidades();

        public FrmUsuario()
        {
            InitializeComponent();
            CargarListaUsuarios();
            LimpiarCampos();
        }

        private void ValidarCampos() 
        {
            ObjUtilidades = new ClsUtilidades()
            {
                LstTxtBox = new System.Collections.Generic.List<TextBox>(),
            };

            ObjUtilidades.LstTxtBox.Add(TextNombre);
            ObjUtilidades.LstTxtBox.Add(TextApellido1);
            ObjUtilidades.LstTxtBox.Add(TextCorreo);
            ObjUtilidades.LstTxtBox.Add(TextCargo);

            ObjUtilidades.ValidarTextBox(ObjUtilidades.LstTxtBox);

           
        }

        private void LimpiarCampos() 
        {
            TextNombre.Text = string.Empty;
            TextApellido1.Text = string.Empty;
            TextApellido2.Text = string.Empty;
            TextCorreo.Text = string.Empty;
            TextCargo.Text = string.Empty;
            ChkIsAdmin.Checked = true;
            DtpFechaNacimiento.Value = DateTime.Now;
            LblIdUsuario.Text = string.Empty;


            BtnActualizar.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnAgregar.Enabled = true;
        }


        private void FrmUsuario_Load(object sender, EventArgs e)
        {
           
              

        }

        private void CargarListaUsuarios()
        {
            ObjUsuario = new ClsUsuario();
            ObjUsuarioLn.Index(ref ObjUsuario);
            if (ObjUsuario.MensajeError == null)
            {
                DgvUsuarios.DataSource = ObjUsuario.DtResultados;
                ObjUtilidades.FormatoDataGridView(ref DgvUsuarios);
                DgvUsuarios.Columns[0].DisplayIndex = DgvUsuarios.ColumnCount - 1;
            }
            else
            {
                MessageBox.Show(ObjUsuario.MensajeError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            ValidarCampos();

            if (ObjUtilidades.MensajeError == null)
            {
                ObjUsuario = new ClsUsuario()
                {
                    Nombre = TextNombre.Text,
                    Apellido1 = TextApellido1.Text,
                    Apellido2 = TextApellido2.Text,
                    Correo = TextCorreo.Text,
                    FechaNacimiento = DtpFechaNacimiento.Value,
                    Cargo = TextCargo.Text,
                    EsAdmin = ChkIsAdmin.Checked
                };

                ObjUsuarioLn.Create(ref ObjUsuario);

                if (ObjUsuario.MensajeError == null)
                {

                    MessageBox.Show("El ID: " + ObjUsuario.ValorScalar + " , fue agregado correctamente");
                    CargarListaUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(ObjUsuario.MensajeError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(ObjUtilidades.MensajeError.ToString(), "Mensaje Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

           
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("¿Esta seguro de actualizar el registro " + LblIdUsuario.Text+"?", "Mensaje del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                ObjUsuario = new ClsUsuario()
                {
                    IdUsuario = Convert.ToByte(LblIdUsuario.Text),
                    Nombre = TextNombre.Text,
                    Apellido1 = TextApellido1.Text,
                    Apellido2 = TextApellido2.Text,
                    Correo = TextCorreo.Text,
                    FechaNacimiento = DtpFechaNacimiento.Value,
                    Cargo = TextCargo.Text,
                    EsAdmin = ChkIsAdmin.Checked
                };

                ObjUsuarioLn.Update(ref ObjUsuario);

                if (ObjUsuario.MensajeError == null)
                {

                    MessageBox.Show("El Usuario fue actualizado correctamente");
                    CargarListaUsuarios();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(ObjUsuario.MensajeError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        private void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DgvUsuarios.Columns[e.ColumnIndex].Name == "Editar")
                {
                    ObjUsuario = new ClsUsuario()
                    {
                        IdUsuario = Convert.ToByte(DgvUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString())
                    };

                    LblIdUsuario.Text = ObjUsuario.IdUsuario.ToString();

                    ObjUsuarioLn.Read(ref ObjUsuario);

                    TextNombre.Text = ObjUsuario.Nombre;
                    TextApellido1.Text = ObjUsuario.Apellido1;
                    TextApellido2.Text = ObjUsuario.Apellido2;
                    TextCorreo.Text = ObjUsuario.Correo;
                    DtpFechaNacimiento.Value = ObjUsuario.FechaNacimiento;
                    TextCargo.Text = ObjUsuario.Cargo;
                    ChkIsAdmin.Checked = ObjUsuario.EsAdmin;

                    BtnActualizar.Enabled = true;
                    BtnEliminar.Enabled = true;
                    BtnAgregar.Enabled = false;
                }
            }
            catch (Exception)
            {
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {


            DialogResult respuesta = MessageBox.Show("¿Esta seguro de eliminar el registro "+ LblIdUsuario.Text+"?", "Mensaje del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                ObjUsuario = new ClsUsuario()
                {
                    IdUsuario = Convert.ToByte(LblIdUsuario.Text)
                };


                ObjUsuarioLn.Delete(ref ObjUsuario);

                CargarListaUsuarios();
                LimpiarCampos();
                   
            }


            
        }
    }
}
