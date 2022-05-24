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
    public partial class CADASTROUSUARIO : Form
    {
        public CADASTROUSUARIO()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_cpf_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_cpf_c_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txtbox_logra_u.Clear();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            txtbox_numero_u.Clear();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            txtbox_bairro_u.Clear();
        }

        private void txtbox_cidade_c_Enter(object sender, EventArgs e)
        {
            txtbox_cidade_u.Clear();
        }

        private void txtbox_comple_c_Enter(object sender, EventArgs e)
        {
            txtbox_comple_u.Clear();
        }

        

        private void txtbox_numero_u_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_logra_u_Enter(object sender, EventArgs e)
        {
            txtbox_logra_u.Clear();
        }

        private void txtbox_numero_u_Enter(object sender, EventArgs e)
        {
            txtbox_numero_u.Clear();
        }

        private void txtbox_bairro_u_Enter(object sender, EventArgs e)
        {
            txtbox_bairro_u.Clear();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome_u.Text = "";
            txtbox_sobrenome_u.Text = "";
            txtbox_senha_u.Text = "";
            txt_cpf_u.Text = "";
            txt_email_u.Text = "";
            msk_datanas_u.Text = "";
            cbx_tiporua_c.Text = "";
            txtbox_logra_u.Text = "";
            txtbox_numero_u.Text = "";
            txtbox_bairro_u.Text = "";
            txtbox_cidade_u.Text = "";
            msktxtbox_cep_u.Text = "";
            cbx_tipocasa_u.Text = "";
            txtbox_comple_u.Text = "";

        }

        private void txtbox_valorsalario_Leave(object sender, EventArgs e)
        {
            try
            {


                double valorv = Convert.ToDouble(txtbox_valorsalario.Text.Replace("R$", ""));
                txtbox_valorsalario.Text = String.Format("{0:c}", valorv);
            }

            catch
            {

            }
        }
    }
}
