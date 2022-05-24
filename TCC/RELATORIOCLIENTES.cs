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
    public partial class RELATORIOCLIENTES : Form
    {
        public RELATORIOCLIENTES()
        {
            InitializeComponent();
        }

        private void btn_novocliente_Click(object sender, EventArgs e)
        {
            CADASTROCLIENTE cadastrar = new CADASTROCLIENTE();
            cadastrar.ShowDialog();
        }

        private void btn_voltarproduto_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
