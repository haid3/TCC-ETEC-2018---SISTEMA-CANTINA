using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class SANGRIA : Form
    {
        public SANGRIA()
        {
            InitializeComponent();
        }

        private void btn_voltarproduto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novasangria_Click(object sender, EventArgs e)
        {
            txtbox_descsangria.Text = "";
            txtbox_idsangria.Text = "";
            txtbox_valorsangria.Text = "";
            cbbox_tiposangria.Text = "";

            txtbox_idsangria.Focus();
        }
    }
}
