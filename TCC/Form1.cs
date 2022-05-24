using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace TCC
{
    public partial class Telalogin : Form
    {
        public Telalogin()
        {
            InitializeComponent();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if (txtbox_usuario.Text == "")
            {
                MessageBox.Show("Preencha seu usuário!");  //verifica se campo login está vazio
                //Close();                               // se estiver, fecha aplicação

            }

            if (txtbox_senha.Text == "")
            {
                MessageBox.Show("Preencha sua senha!");  //verifica se campos senha está vazio
                //Close();                               // se estiver, fecha aplicação

            }



            else
            {       
            this.Hide();
            Home inicio = new Home();
            inicio.ShowDialog();


            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Telalogin_Load(object sender, EventArgs e)
        {

        }
    }
}
