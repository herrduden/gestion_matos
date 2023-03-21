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
            MessageBox.Show("Hallo Sir");
            SqlConnection cn = null;
            SqlCommand com= null;
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
                    InfosClients.Items.Add(str);
                }
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show("probleme avec votre databse contactez votre admin");
                Application.Exit();
            }

            if (sqr!=null)
            {
                sqr.Close();
            }
            if (cn !=null)
            {
                /* le dispose libere la place de la memoire*/ 
                cn.Close();
                cn.Dispose();
            }
            if (com!=null)
            {
                com.Dispose();
            }
            
            
            
            
        }

        private void InfosClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*MessageBox.Show("JAWOHL !");*/
            string nom = InfosClients.SelectedItem.ToString();
            /* attention diff entre selectedItem et selectedIndex*/
            
            /* va recuperer ce sur quoi j'ai clicker et va le mettre dans une variable*/
            MessageBox.Show(nom);

            SqlConnection cn = null;
            SqlCommand com = null;
            SqlDataReader sqr = null;

            cn = new SqlConnection(this.connstring);
            cn.Open();
            string strsql = "select * from CLIENT where Nom ='" + nom +"' ";

            com = new SqlCommand(strsql, cn);
            sqr = com.ExecuteReader();
            
            sqr.Read();
            /* on prend la textbox et dans la propriete text on insert le nom ou mail etc..*/
            textBox1.Text = sqr["Nom"].ToString();
            textBox2.Text = sqr["Adresse"].ToString();
            textBox4.Text = sqr["Tel"].ToString();
            textBox3.Text = sqr["Mail"].ToString();

            if (sqr != null)
            {
                sqr.Close();
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
    }
}
