using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppMatosGestion.Entities;

namespace WindowsFormsAppMatosGestion
{
    public partial class Login : Form
    {
        private string costring = @"Server=.\SQLEXPRESS;Database=GM;Trusted_Connection=True;";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection co = null;
            SqlCommand requete = null;
            SqlDataReader table = null;

            co = new SqlConnection(this.costring);
            co.Open();

            string query = "SELECT * FROM Utilisateur WHERE Login =@login AND Pwd=@mdp";
            requete = new SqlCommand(query, co);
            requete.Parameters.Add("@login",textBoxLogin.Text);
            requete.Parameters.Add("@mdp", textBoxMdp.Text);

            table = requete.ExecuteReader();
           
            if (table.HasRows)
            {               
                Utilisateur loggedUser= new Utilisateur();
                while (table.Read() == true)
                {
                    loggedUser.IdUser =int.Parse(table["ID_USER"].ToString());
                    loggedUser.Mdp = table["Pwd"].ToString();
                    loggedUser.Login = table["Login"].ToString();
                }
                Session.Session.OpenSession(loggedUser);
                MessageBox.Show("welcome to your session: " + Session.Session.GetSession().GetUtilisateur().Login);
                Session.Session.GetSession().CloseSession();
            }
            else
            {
                MessageBox.Show("connection failed", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
