using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAV___FinalProject.Ops.Repos;
using SAV___FinalProject.SAVDataModel.Entities;
using SAV___FinalProject.Formularios;

namespace SAV___FinalProject.Formularios
{
    public partial class frmUsuarios : Form
    {
        UsuariosRepository Usuariorepo = new UsuariosRepository();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Llenardtgv();
        }
        private void Llenardtgv()
        {

            dtgvUsuarios.DataSource = Usuariorepo.Getall();
        }
        private void LimpiarCampos()
        {
            txtID.Text = string.Empty;
            BoxName.Text = string.Empty;
            BoxApellido.Text = string.Empty;
            BoxUser.Text = string.Empty;
            BoxPass.Text = string.Empty;
            BoxTelefono.Text = string.Empty;
            BoxDireccion.Text = string.Empty;
            BoxCorreo.Text = string.Empty;
            BoxSexo.Text = string.Empty;
            BoxRol.Text = string.Empty;
        }

        private void DeshabilitarCampos()
        {
            txtID.Enabled = false;
        }

        private void dtgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            txtID.Text = dtgvUsuarios.CurrentRow.Cells["Id"].Value.ToString();
            BoxName.Text = dtgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            BoxApellido.Text = dtgvUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
            BoxUser.Text = dtgvUsuarios.CurrentRow.Cells["Username"].Value.ToString();
            BoxPass.Text = dtgvUsuarios.CurrentRow.Cells["Password"].Value.ToString();
            BoxTelefono.Text = dtgvUsuarios.CurrentRow.Cells["Telefono"].Value.ToString();
            BoxDireccion.Text = dtgvUsuarios.CurrentRow.Cells["Direccion"].Value.ToString();
            BoxCorreo.Text = dtgvUsuarios.CurrentRow.Cells["Correo"].Value.ToString();
            BoxSexo.Text = dtgvUsuarios.CurrentRow.Cells["Sexo"].Value.ToString();
            BoxRol.Text = dtgvUsuarios.CurrentRow.Cells["Rol"].Value.ToString();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Usuariorepo.Create(new Usuarios()
            {
                
                Nombre = BoxName.Text,
                Username = BoxUser.Text,
                Password = BoxPass.Text,
                Apellido = BoxApellido.Text,
                Telefono = BoxTelefono.Text,
                Direccion = BoxDireccion.Text,
                Correo = BoxCorreo.Text,
                Sexo = BoxSexo.Text,
                Rol = BoxRol.Text,
                Estatus = "A",
                Borrado = false,
                FechaRegistro = DateTime.Now,
                UsuarioModifico = 1
            });
            MessageBox.Show("Usuario Agregado");
            Llenardtgv();
        }
    }
}
