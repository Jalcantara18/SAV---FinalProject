
namespace SAV___FinalProject.Formularios
{
    partial class frmUsuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BoxRol = new System.Windows.Forms.ComboBox();
            this.BoxSexo = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BoxCorreo = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BoxDireccion = new System.Windows.Forms.TextBox();
            this.BoxTelefono = new System.Windows.Forms.TextBox();
            this.BoxPass = new System.Windows.Forms.TextBox();
            this.BoxUser = new System.Windows.Forms.TextBox();
            this.BoxApellido = new System.Windows.Forms.TextBox();
            this.BoxName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BoxRol);
            this.groupBox1.Controls.Add(this.BoxSexo);
            this.groupBox1.Controls.Add(this.BtnLimpiar);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.BoxCorreo);
            this.groupBox1.Controls.Add(this.BtnModificar);
            this.groupBox1.Controls.Add(this.BoxDireccion);
            this.groupBox1.Controls.Add(this.BoxTelefono);
            this.groupBox1.Controls.Add(this.BoxPass);
            this.groupBox1.Controls.Add(this.BoxUser);
            this.groupBox1.Controls.Add(this.BoxApellido);
            this.groupBox1.Controls.Add(this.BoxName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSexo);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtRol);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 280);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Usuarios";
            // 
            // BoxRol
            // 
            this.BoxRol.FormattingEnabled = true;
            this.BoxRol.Items.AddRange(new object[] {
            "Operador",
            "Supervisor"});
            this.BoxRol.Location = new System.Drawing.Point(436, 139);
            this.BoxRol.Name = "BoxRol";
            this.BoxRol.Size = new System.Drawing.Size(259, 21);
            this.BoxRol.TabIndex = 87;
            // 
            // BoxSexo
            // 
            this.BoxSexo.FormattingEnabled = true;
            this.BoxSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.BoxSexo.Location = new System.Drawing.Point(436, 112);
            this.BoxSexo.Name = "BoxSexo";
            this.BoxSexo.Size = new System.Drawing.Size(259, 21);
            this.BoxSexo.TabIndex = 86;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLimpiar.Location = new System.Drawing.Point(565, 202);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(173, 52);
            this.BtnLimpiar.TabIndex = 85;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.Location = new System.Drawing.Point(6, 202);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(173, 52);
            this.btnCrear.TabIndex = 84;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(386, 202);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 52);
            this.btnEliminar.TabIndex = 84;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // BoxCorreo
            // 
            this.BoxCorreo.Location = new System.Drawing.Point(436, 85);
            this.BoxCorreo.Name = "BoxCorreo";
            this.BoxCorreo.Size = new System.Drawing.Size(259, 20);
            this.BoxCorreo.TabIndex = 16;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(198, 202);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(173, 52);
            this.BtnModificar.TabIndex = 83;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BoxDireccion
            // 
            this.BoxDireccion.Location = new System.Drawing.Point(436, 58);
            this.BoxDireccion.Name = "BoxDireccion";
            this.BoxDireccion.Size = new System.Drawing.Size(259, 20);
            this.BoxDireccion.TabIndex = 15;
            // 
            // BoxTelefono
            // 
            this.BoxTelefono.Location = new System.Drawing.Point(436, 31);
            this.BoxTelefono.Name = "BoxTelefono";
            this.BoxTelefono.Size = new System.Drawing.Size(259, 20);
            this.BoxTelefono.TabIndex = 14;
            // 
            // BoxPass
            // 
            this.BoxPass.Location = new System.Drawing.Point(95, 143);
            this.BoxPass.Name = "BoxPass";
            this.BoxPass.Size = new System.Drawing.Size(228, 20);
            this.BoxPass.TabIndex = 13;
            // 
            // BoxUser
            // 
            this.BoxUser.Location = new System.Drawing.Point(95, 115);
            this.BoxUser.Name = "BoxUser";
            this.BoxUser.Size = new System.Drawing.Size(228, 20);
            this.BoxUser.TabIndex = 12;
            // 
            // BoxApellido
            // 
            this.BoxApellido.Location = new System.Drawing.Point(95, 87);
            this.BoxApellido.Name = "BoxApellido";
            this.BoxApellido.Size = new System.Drawing.Size(228, 20);
            this.BoxApellido.TabIndex = 11;
            // 
            // BoxName
            // 
            this.BoxName.Location = new System.Drawing.Point(95, 59);
            this.BoxName.Name = "BoxName";
            this.BoxName.Size = new System.Drawing.Size(228, 20);
            this.BoxName.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(95, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(228, 20);
            this.txtID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtSexo
            // 
            this.txtSexo.AutoSize = true;
            this.txtSexo.Location = new System.Drawing.Point(329, 116);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(31, 13);
            this.txtSexo.TabIndex = 8;
            this.txtSexo.Text = "Sexo";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(35, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(44, 13);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Nombre";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Location = new System.Drawing.Point(329, 91);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(38, 13);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.Text = "Correo";
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = true;
            this.txtApellido.Location = new System.Drawing.Point(35, 89);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(44, 13);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Text = "Apellido";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.AutoSize = true;
            this.TxtDireccion.Location = new System.Drawing.Point(329, 66);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(52, 13);
            this.TxtDireccion.TabIndex = 6;
            this.TxtDireccion.Text = "Direccion";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(34, 119);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(55, 13);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Username";
            // 
            // txtRol
            // 
            this.txtRol.AutoSize = true;
            this.txtRol.Location = new System.Drawing.Point(329, 141);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(23, 13);
            this.txtRol.TabIndex = 5;
            this.txtRol.Text = "Rol";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Location = new System.Drawing.Point(329, 41);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(49, 13);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Text = "Telefono";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(35, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(53, 13);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(18, 301);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.Size = new System.Drawing.Size(744, 327);
            this.dtgvUsuarios.TabIndex = 86;
            this.dtgvUsuarios.SelectionChanged += new System.EventHandler(this.dtgvUsuarios_SelectionChanged);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 731);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvUsuarios);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button BtnLimpiar;
        internal System.Windows.Forms.Button btnCrear;
        internal System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox BoxCorreo;
        internal System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.TextBox BoxDireccion;
        private System.Windows.Forms.TextBox BoxTelefono;
        private System.Windows.Forms.TextBox BoxPass;
        private System.Windows.Forms.TextBox BoxUser;
        private System.Windows.Forms.TextBox BoxApellido;
        private System.Windows.Forms.TextBox BoxName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtSexo;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label txtApellido;
        private System.Windows.Forms.Label TxtDireccion;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtRol;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.ComboBox BoxSexo;
        private System.Windows.Forms.ComboBox BoxRol;
    }
}