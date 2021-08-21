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

namespace SAV___FinalProject
{

    public partial class Login : Form
    {
        public int LoginId { get; set; }
        public string Rol { get; set; }
        public string LoggedName { get; set; }
        public string LoggedApellido { get; set; }
        UsuariosRepository Usuariorepo = new UsuariosRepository();
        
        public Login()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string User = txtUser.Text, pass = txtPass.Text;
            var Result = Usuariorepo.FindUser(User, pass);


            if (Result == null)
            {
                MessageBox.Show("Ingrese un usuario valido");
                
            }
            else if (Result.Username == User && Result.Password == pass)
            {
                LoginId = Result.Id;
                Rol = Result.Rol;
                LoggedName = Result.Nombre;
                LoggedApellido = Result.Apellido;

                MessageBox.Show("Bienvenido a SAV: " + Result.Nombre + "" + Result.Apellido);
                Main Prin = new Main();
                Prin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ingrese un usuario valido");
            }

        }
    }
}
