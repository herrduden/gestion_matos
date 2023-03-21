using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMatosGestion
{
    public partial class FormGenerale : Form
    {
        public FormGenerale()
        {
            InitializeComponent();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            FormClient dlg = new FormClient();
            dlg.ShowDialog();
        }


    }
}
