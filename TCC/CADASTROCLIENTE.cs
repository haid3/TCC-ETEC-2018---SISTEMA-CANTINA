using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TCC
{
    public partial class CADASTROCLIENTE : Form
    {
        public CADASTROCLIENTE()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            txt_bairro_c.Clear();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            txtbox_n_endereco_c.Clear();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            txtbox_log_c.Clear();
        }

        private void txtbox_cidade_c_Enter(object sender, EventArgs e)
        {
            txtbox_cidade_c.Clear();
        }


        private void txtbox_comp_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_comple_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_comple_c_Enter(object sender, EventArgs e)
        {
            txtbox_comple_c.Clear();
        }

        private void cbx_tipocasa_c_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txtbox_cidade_c.Text = "";
            txtbox_cpf_c.Text = "";
        }

        private void mskd_datanasccliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskd_datanasccliente_LocationChanged(object sender, EventArgs e)
        {

        }

        private void mskd_datanasccliente_Leave(object sender, EventArgs e)
        {


        }

        private void txt_cpf_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cpf_c_Leave(object sender, EventArgs e)
        {

        }

        private void mskd_cfp_c_Leave(object sender, EventArgs e)
        {
            /*if (mskd_cfp_c.Text.Length >1 && mskd_cfp_c.Text.Length  < 14)
            {
                MessageBox.Show("Favor preencher um cpf com 11 dígitos");
                mskd_cfp_c.Clear();
                mskd_cfp_c.Focus();
            }
            else {
            }
            */

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            
           /* if (mskd_datanasccliente.Text.Length < 10)
            {
                MessageBox.Show("Preencha uma data de nascimento válida ");
                mskd_datanasccliente.Focus();
            }
            */

            if (txt_nome_c.Text == "")
            {
                MessageBox.Show("Favor preencher o nome");
                txt_nome_c.Focus();
            }

            else
            {

                string n = txt_nome_c.Text;
                string cpf = txtbox_cpf_c.Text;
                string dt = mskd_datanasccliente.Text;
                string em = txt_email_c.Text;
                string r = cbx_tiporua_c.Text;
                string lg = txtbox_log_c.Text;
                string ne = txtbox_n_endereco_c.Text;
                string b = txt_bairro_c.Text;
                string c = txtbox_cidade_c.Text;
                string cep = masked_cep_c.Text;
                string comp = txtbox_comple_c.Text;
                string tipo = cbx_tipocasa_c.Text;



                if (n == "")
                {
                    MessageBox.Show("É necessário preencher o nome do cliente");
                }

                else
                {


                    SqlConnection conexao = new SqlConnection("Data Source=localhost;Initial Catalog=TCC1;Integrated Security=True;Pooling=False");
                    SqlDataReader dr = null;

                    try
                    {
                        // 2. Abre a conexão
                        conexao.Open();

                        // prepara um comando SQL para incluir dados usando a instrução INSERT INTO
                        // string incluiSQL = " insert into produto (nome, valorv, valorc, estoque, validade, grupo, estoquemin) values ("txt_nome_produto.Text", "txt_valorv_produto.Text", "txt_valorc_produto.Text", "txtbox_estoqueatual", "txtbox_valid_prod", "combobox_depto_prod", "txtbox_estoquemin"')";




                        string incluiSQL = " insert into cliente (nome, cpf_cliente) values ('" + n + "', '" + cpf + "')";
                       // usar > " insert into cliente () values ('txt_nome_produto, ')";
                        //sexo, rg, endereco, numero_endereco, logradouro, complemento, bairro, cidade, uf,  telefone, telefone2, observacao


                        // 1. Instancia um novo comando com uma consulta e uma conexão
                        SqlCommand cmd = new SqlCommand(incluiSQL, conexao);

                        // 2. Chama o método ExecuteNonQuery para enviar o comando
                        cmd.ExecuteNonQuery();



                        MessageBox.Show("Cliente cadastrado com sucesso.");

                    }
                    finally
                    {
                        // fecha o reader
                        if (dr != null)
                        {
                            dr.Close();
                        }
                        // 5. Fecha a conexão
                        if (conexao != null)
                        {
                            conexao.Close();
                        }
                    }

                    txtbox_id_c.Text = "";
                    txt_nome_c.Text = "";
                    txtbox_cpf_c.Text = "";
                    mskd_datanasccliente.Text = "";
                    txt_email_c.Text = "";
                    cbx_tiporua_c.Text = "";
                    txtbox_log_c.Text = "";
                    txtbox_n_endereco_c.Text = "";
                    txt_bairro_c.Text = "";
                    txtbox_cidade_c.Text = "";
                    masked_cep_c.Text = "";
                    txtbox_comple_c.Text = "";
                    cbx_tipocasa_c.Text = "";
                }


            

        }
        }

        private void txtbox_cpf_c_Leave(object sender, EventArgs e)
        {
            if (txtbox_cpf_c.Text.Length >=1 && txtbox_cpf_c.Text.Length  < 11)
            {
                MessageBox.Show("Favor preencher um cpf com 11 dígitos");
               
                txtbox_cpf_c.Focus();
            }
            else {
            }
            

        }
    }
}

