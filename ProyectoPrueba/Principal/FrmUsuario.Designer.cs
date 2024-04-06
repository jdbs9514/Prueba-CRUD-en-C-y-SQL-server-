namespace ProyectoPrueba.Principal
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.TextNombre = new System.Windows.Forms.TextBox();
            this.TextApellido2 = new System.Windows.Forms.TextBox();
            this.TextApellido1 = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelApellido1 = new System.Windows.Forms.Label();
            this.LabelApellido2 = new System.Windows.Forms.Label();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ChkIsAdmin = new System.Windows.Forms.CheckBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TextCargo = new System.Windows.Forms.TextBox();
            this.TextCorreo = new System.Windows.Forms.TextBox();
            this.LabelCargo = new System.Windows.Forms.Label();
            this.LabelCorreo = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblIdUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.DgvUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvUsuarios.Location = new System.Drawing.Point(26, 178);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.Size = new System.Drawing.Size(745, 260);
            this.DgvUsuarios.TabIndex = 0;
            this.DgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            // 
            // TextNombre
            // 
            this.TextNombre.Location = new System.Drawing.Point(26, 35);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(148, 20);
            this.TextNombre.TabIndex = 1;
            // 
            // TextApellido2
            // 
            this.TextApellido2.Location = new System.Drawing.Point(334, 35);
            this.TextApellido2.Name = "TextApellido2";
            this.TextApellido2.Size = new System.Drawing.Size(148, 20);
            this.TextApellido2.TabIndex = 2;
            // 
            // TextApellido1
            // 
            this.TextApellido1.Location = new System.Drawing.Point(180, 35);
            this.TextApellido1.Name = "TextApellido1";
            this.TextApellido1.Size = new System.Drawing.Size(148, 20);
            this.TextApellido1.TabIndex = 3;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(23, 19);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(44, 13);
            this.LabelName.TabIndex = 4;
            this.LabelName.Text = "Nombre";
            // 
            // LabelApellido1
            // 
            this.LabelApellido1.AutoSize = true;
            this.LabelApellido1.Location = new System.Drawing.Point(177, 19);
            this.LabelApellido1.Name = "LabelApellido1";
            this.LabelApellido1.Size = new System.Drawing.Size(53, 13);
            this.LabelApellido1.TabIndex = 5;
            this.LabelApellido1.Text = "Apellido 1";
            // 
            // LabelApellido2
            // 
            this.LabelApellido2.AutoSize = true;
            this.LabelApellido2.Location = new System.Drawing.Point(331, 19);
            this.LabelApellido2.Name = "LabelApellido2";
            this.LabelApellido2.Size = new System.Drawing.Size(53, 13);
            this.LabelApellido2.TabIndex = 6;
            this.LabelApellido2.Text = "Apellido 2";
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(26, 77);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaNacimiento.TabIndex = 7;
            // 
            // ChkIsAdmin
            // 
            this.ChkIsAdmin.AutoSize = true;
            this.ChkIsAdmin.Location = new System.Drawing.Point(273, 80);
            this.ChkIsAdmin.Name = "ChkIsAdmin";
            this.ChkIsAdmin.Size = new System.Drawing.Size(55, 17);
            this.ChkIsAdmin.TabIndex = 8;
            this.ChkIsAdmin.Text = "Admin";
            this.ChkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(594, 138);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 10;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(696, 138);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TextCargo
            // 
            this.TextCargo.Location = new System.Drawing.Point(642, 35);
            this.TextCargo.Name = "TextCargo";
            this.TextCargo.Size = new System.Drawing.Size(148, 20);
            this.TextCargo.TabIndex = 12;
            // 
            // TextCorreo
            // 
            this.TextCorreo.Location = new System.Drawing.Point(488, 35);
            this.TextCorreo.Name = "TextCorreo";
            this.TextCorreo.Size = new System.Drawing.Size(148, 20);
            this.TextCorreo.TabIndex = 13;
            // 
            // LabelCargo
            // 
            this.LabelCargo.AutoSize = true;
            this.LabelCargo.Location = new System.Drawing.Point(639, 19);
            this.LabelCargo.Name = "LabelCargo";
            this.LabelCargo.Size = new System.Drawing.Size(35, 13);
            this.LabelCargo.TabIndex = 14;
            this.LabelCargo.Text = "Cargo";
            // 
            // LabelCorreo
            // 
            this.LabelCorreo.AutoSize = true;
            this.LabelCorreo.Location = new System.Drawing.Point(485, 19);
            this.LabelCorreo.Name = "LabelCorreo";
            this.LabelCorreo.Size = new System.Drawing.Size(38, 13);
            this.LabelCorreo.TabIndex = 15;
            this.LabelCorreo.Text = "Correo";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(488, 138);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
            // 
            // LblIdUsuario
            // 
            this.LblIdUsuario.AutoSize = true;
            this.LblIdUsuario.Location = new System.Drawing.Point(59, 148);
            this.LblIdUsuario.Name = "LblIdUsuario";
            this.LblIdUsuario.Size = new System.Drawing.Size(0, 13);
            this.LblIdUsuario.TabIndex = 18;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblIdUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.LabelCorreo);
            this.Controls.Add(this.LabelCargo);
            this.Controls.Add(this.TextCorreo);
            this.Controls.Add(this.TextCargo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.ChkIsAdmin);
            this.Controls.Add(this.DtpFechaNacimiento);
            this.Controls.Add(this.LabelApellido2);
            this.Controls.Add(this.LabelApellido1);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextApellido1);
            this.Controls.Add(this.TextApellido2);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.DgvUsuarios);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.TextBox TextNombre;
        private System.Windows.Forms.TextBox TextApellido2;
        private System.Windows.Forms.TextBox TextApellido1;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelApellido1;
        private System.Windows.Forms.Label LabelApellido2;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ChkIsAdmin;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TextCargo;
        private System.Windows.Forms.TextBox TextCorreo;
        private System.Windows.Forms.Label LabelCargo;
        private System.Windows.Forms.Label LabelCorreo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblIdUsuario;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}