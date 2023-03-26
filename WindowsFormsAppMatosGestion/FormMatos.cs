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
    public partial class FormMatos : Form
    {
        private string connstring = @"Server=.\SQLEXPRESS;Database=GM;Trusted_Connection=True;";

        public FormMatos()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMatos_Load(object sender, EventArgs e)
        {
            afficherMatos();

        }

        private void afficherMatos()
        {
            listBoxMatos.Items.Clear();
            SqlConnection cn = null;
            SqlCommand com = null;
            SqlDataReader rqtTable = null;

            try
            {
                cn = new SqlConnection(this.connstring);
                cn.Open();
                string query = "select Nom from MATERIEL;";

                com = new SqlCommand(query, cn);
                rqtTable = com.ExecuteReader();
                string str;
                while (rqtTable.Read() == true)
                {
                    str = rqtTable["Nom"].ToString();
                    listBoxMatos.Items.Add(str);
                }

            }
            catch (ArgumentException ex)
            {

                MessageBox.Show("probleme avec votre databse contactez votre admin");
                Application.Exit();
            }

            if (rqtTable != null)
            {
                rqtTable.Close();
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

        private void TransferData(object sender, EventArgs e)
        {
            if (listBoxMatos.SelectedIndex == -1)
            {
                MessageBox.Show("please select an item", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBoxMatos.Focus();
                return;
            }

            string matos = listBoxMatos.SelectedItem.ToString();

            SqlConnection co = null;           
            SqlCommand requete = null;
            SqlDataReader tableMatos = null;

            co= new SqlConnection(this.connstring);
            co.Open();

            string query = "select * from MATERIEL WHERE Nom = '" + matos + "'";
            requete =new SqlCommand(query, co);
            tableMatos= requete.ExecuteReader();
            tableMatos.Read();

            textBoxNom.Text = tableMatos["Nom"].ToString();
            textBoxNumSerie.Text = tableMatos["NoSerie"].ToString();
            textBoxDate.Text = tableMatos["Date_Install"].ToString();
            textBoxMTBF.Text = tableMatos["MTBF"].ToString();
            textBoxType.Text = tableMatos["Type"].ToString();
            textBoxMarque.Text = tableMatos["Marque"].ToString();



        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            AddMatos Window = new AddMatos();
            Window.ShowDialog();
            afficherMatos();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (listBoxMatos.SelectedIndex==-1)
            {
                MessageBox.Show("please select an item" ,"erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBoxMatos.Focus();
                return;
            }
            SqlConnection co =null;
            SqlCommand requete = null;
            co = new SqlConnection(this.connstring);
            co.Open();

            string query = @"UPDATE MATERIEL SET Nom= @name , NoSerie = @serie, Date_install=@date, MTBF=@mtbf, type=@type , Marque=@marque  WHERE Nom = @Nom" ;

            requete = new SqlCommand(query, co);
            requete.Parameters.Add("@Nom",listBoxMatos.SelectedItem.ToString());
            requete.Parameters.Add("@name",textBoxNom.Text);                    
            requete.Parameters.Add("@serie",textBoxNumSerie.Text);              
            requete.Parameters.Add("@date", textBoxDate.Text);                  
            requete.Parameters.Add("@mtbf",textBoxMTBF.Text);                   
            requete.Parameters.Add("@type",textBoxType.Text);                   
            requete.Parameters.Add("@marque",textBoxMarque.Text);               
            requete.ExecuteNonQuery();

            MessageBox.Show("Item was successfully modified", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            afficherMatos();



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
            if (listBoxMatos.SelectedIndex == -1)
            {
                MessageBox.Show("please select an item", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listBoxMatos.Focus();
                return;
            }
            SqlConnection co = null;
            SqlCommand requete = null;

            string query = "delete from MATERIEL where Nom=@nom";

            co = new SqlConnection(this.connstring);
            co.Open();
            requete = new SqlCommand(query,co);

            requete.Parameters.Add("@nom", listBoxMatos.SelectedItem);
            requete.ExecuteNonQuery();
            MessageBox.Show("Item was successfully deleted", "success", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            textBoxDate.Clear();
            textBoxMarque.Clear();
            textBoxMTBF.Clear();
            textBoxNom.Clear();
            textBoxType.Clear();
            textBoxNumSerie.Clear();
            afficherMatos();

        }
    }
}
