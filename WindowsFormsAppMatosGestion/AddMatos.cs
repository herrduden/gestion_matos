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
using System.Xml.Linq;

namespace WindowsFormsAppMatosGestion
{
    public partial class AddMatos : Form
    {
        private string costring = @"Server=.\SQLEXPRESS;Database=GM;Trusted_Connection=True;";

        public AddMatos()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection co = null;
            SqlCommand requete = null;

            co = new SqlConnection(this.costring);
            co.Open();
            string query = "INSERT INTO MATERIEL VALUES(@name, @noSerie, @date_install, @mtbf, @type, @marque,@idClient)";
            requete = new SqlCommand(query, co);

            requete.Parameters.AddWithValue("@name", textBoxNom.Text);
            requete.Parameters.AddWithValue("@noSerie", textBoxNumSerie.Text);
            requete.Parameters.AddWithValue("@date_install", textBoxDate_install.Text);
            requete.Parameters.AddWithValue("@mtbf", int.Parse(textBoxMTBF.Text));
            requete.Parameters.AddWithValue("@type", textBoxType.Text);
            requete.Parameters.AddWithValue("@marque", textBoxMarque.Text);
            requete.Parameters.AddWithValue("@idClient", 16);
            requete.ExecuteNonQuery();

            MessageBox.Show("Matos successfully added");


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
    }
}
