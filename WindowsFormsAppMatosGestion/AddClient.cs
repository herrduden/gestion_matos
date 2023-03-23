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


namespace WindowsFormsAppMatosGestion
{
    public partial class AddClient : Form
    {
        private string costring = @"Server=.\SQLEXPRESS;Database=GM;Trusted_Connection=True;";

        public AddClient()
        {
            InitializeComponent();
        }

        private bool CheckClientName(string name)
        {
            SqlConnection co = null;
            SqlCommand requete = null;
            SqlDataReader sqr = null;
            co=new SqlConnection(this.costring);
            co.Open();
            string query = "SELECT COUNT(*) as nb FROM CLIENT where Nom='" + ClientName.Text + "'";
            requete= new SqlCommand(query, co);
            sqr= requete.ExecuteReader();
            sqr.Read();
            int i = Convert.ToInt32(sqr["nb"]);

            if (i==1)
            {
                return true;
            }
            else
            {
                return false;
            }


            

            return true;
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            bool b =CheckClientName(ClientName.Text);
            if (b == true) {
                MessageBox.Show("Client already exist");
                    return;
            }

            SqlConnection co = null;
            SqlCommand requete = null;
                       

            string query = "insert into CLIENT (Nom,Adresse,Mail,Tel) values (@name,@address,@email,@tel)";

            Console.WriteLine("save info");

            co = new SqlConnection(this.costring);
            co.Open();

            requete = new SqlCommand(query,co);
            requete.Parameters.AddWithValue("@name",ClientName.Text.Trim());
            requete.Parameters.AddWithValue("@address",AdresseClient.Text);
            requete.Parameters.AddWithValue("@email",EmailClient.Text);
            requete.Parameters.AddWithValue("@tel",TelClient.Text);

            requete.ExecuteNonQuery();
            /* le executeNonQuery va executer le delete , uodate et insert */

            MessageBox.Show("Client successfully added");

            if (co != null)
            {
                co.Close();
                co.Dispose();
            }
            if (requete != null)
            {
                requete.Dispose();
            }

            Close();





        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }
    }
}
