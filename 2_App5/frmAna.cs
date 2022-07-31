using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_App5
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        // formun yüklenme olayı...
        private void frmAna_Load(object sender, EventArgs e)
        {
            lblMesaj.Text = "Hoşgeldin Admin";
        }
    }
}