using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsAppMatosGestion
{
    public partial class FormClient : Form
    {   
        private string connstring = @"Server=.\SQLEXPRESS;Database=GM;Trusted_Connection=True;";
        public FormClient()
        {
            InitializeComponent();
        }


 

        private void buttonFermer_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("button fermer clicked");
            this.Close();
            
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            afficheclient();

        }

        private void afficheclient()
        {
            NomsClients.Items.Clear();
            SqlConnection cn = null;
            SqlCommand com = null;
            SqlDataReader sqr = null;
            try
            {
                cn = new SqlConnection(this.connstring);
                cn.Open();
                string strsql = "select ID_CLIENT , Nom from CLIENT;";

                com = new SqlCommand(strsql, cn);
                /* Pour executer ma requete il faut 2 parametres : la requete literale et la connexion a ma DB*/

                sqr = com.ExecuteReader();
                /* sqr = com.ExecuteReader() va permettre d'executer  la commande c'est l equivalent du F5 sur l'interface*/
                string str;
                while (sqr.Read() == true)
                {
                    str = sqr["Nom"].ToString();
                    NomsClients.Items.Add(str);
                }
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show("probleme avec votre databse contactez votre admin");
                Application.Exit();
            }

            if (sqr != null)
            {
                sqr.Close();
            }
            if (cn != null)
            {
                /* le dispose libere la place de la memoire*/
                cn.Close();
                cn.Dispose();
            }
            if (com != null)
            {
                com.Dispose();
            }

        }

        private void InfosClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NomsClients.SelectedItem== null)
            {
                MessageBox.Show("please select an item");
                return;
            }
           
            string nom = NomsClients.SelectedItem.ToString();
            /* attention diff entre selectedItem et selectedIndex*/

            /* va recuperer ce sur quoi j'ai clicker et va le mettre dans une variable
             MessageBox.Show(nom);
             */


            SqlConnection cn = null;
            SqlCommand com = null;
            SqlDataReader result = null;
            /*  result est un tableau*/

            cn = new SqlConnection(this.connstring);
            cn.Open();
            string strsql = "select * from CLIENT where Nom ='" + nom +"' ";

            com = new SqlCommand(strsql, cn);
            result = com.ExecuteReader();
            
            result.Read();
            /* on prend la textbox et dans la propriete text on insert le nom ou mail etc..*/
            textBoxNom.Text = result["Nom"].ToString();
            textBoxAdresse.Text = result["Adresse"].ToString();
            textBoxMail.Text = result["Tel"].ToString();
            textBoxTel.Text = result["Mail"].ToString();

            if (result != null)
            {
                result.Close();
            }
            if (cn != null)
            {
                cn.Close();
                cn.Dispose();
            }
            if (com != null)
            {
                com.Dispose();
            }
        }

        /* #########################################################################################*/

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            
            AddClient AddClientWindow = new AddClient();
            AddClientWindow.ShowDialog();
            afficheclient();

        }
        /* #########################################################################################*/
        private void ButtonModifier_Click(object sender , EventArgs e)
        {
            if (NomsClients.SelectedIndex==-1)
            {
                MessageBox.Show("please select an item", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NomsClients.Focus();
                return;
            }


            SqlConnection co = null;
            SqlCommand requete = null;
            co = new SqlConnection(this.connstring);
            co.Open();


            string query = "UPDATE CLIENT SET Nom= @name , Adresse = @address, Mail=@email , Tel=@num " + "WHERE Nom = '" + NomsClients.SelectedItem + "'";
            requete = new SqlCommand(query, co);

            requete.Parameters.Add("@name", textBoxNom.Text.Trim());
            requete.Parameters.Add("@address", textBoxAdresse.Text);
            requete.Parameters.Add("@email", textBoxMail.Text);
            requete.Parameters.Add("@num", textBoxTel.Text);

            requete.ExecuteNonQuery();
            afficheclient();

            
            if (co != null)
            {
                co.Close();
                co.Dispose();
            }
            if (requete != null)
            {
                requete.Dispose();
            }

        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (NomsClients.SelectedIndex == -1)
            {
                MessageBox.Show("please select an item", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NomsClients.Focus();
                return;
            }

            SqlConnection co = null;
            SqlCommand requete = null;
            co = new SqlConnection(this.connstring);
            co.Open();
            
            string query = "delete from client where Nom='" + NomsClients.SelectedItem+ "'";

            requete = new SqlCommand(query, co);
            requete.ExecuteNonQuery();
            afficheclient();

            
            if (co != null)
            {
                co.Close();
                co.Dispose();
            }
            if (requete != null)
            {
                requete.Dispose();
            }
        }
    }
}
