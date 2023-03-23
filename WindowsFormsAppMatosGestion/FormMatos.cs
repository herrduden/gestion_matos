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
    }
}
