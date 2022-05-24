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

namespace TCC
{
    public partial class CADASTROPRODUTO : Form
    {
        public CADASTROPRODUTO()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //n excluir
        }

        private void lbl_email_c_Click(object sender, EventArgs e)
        {
            //afss
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome_produto.Text = "";
            combobox_depto_prod.Text = "";
            txtbox_valid_prod.Text = "";
            txt_valorv_produto.Text = "";
            txt_valorc_produto.Text = "";
            txtbox_estoqueatual.Text = "";
            txtbox_estoquemin.Text = "";
        }

        private void txt_valorv_produto_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_valorv_produto_Leave(object sender, EventArgs e)
        {
            /*
            try
            {


                double valorv = Convert.ToDouble(txt_valorv_produto.Text.Replace("R$", ""));
                txt_valorv_produto.Text = String.Format("{0:c}", valorv);
            }

            catch
            {

            }
            */
        }

        private void txt_valorc_produto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_valorv_produto_Enter(object sender, EventArgs e)
        {

        }

        private void txt_valorc_produto_Leave(object sender, EventArgs e)
        {
            /*
            try
            {


                double valorc = Convert.ToDouble(txt_valorc_produto.Text.Replace("R$", ""));
                txt_valorc_produto.Text = String.Format("{0:c}", valorc);
            }

            catch
            {

            }
            */
        }

        private void txt_valorc_produto_Enter(object sender, EventArgs e)
        {
            
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            string n  = txt_nome_produto.Text;
            string vv = txt_valorv_produto.Text;
            string vc = txt_valorc_produto.Text;
            string ea = txtbox_estoqueatual.Text;
          //string vl = txtbox_valid_prod.Text;


            if (n == "") {
                MessageBox.Show("É necessário preencher o nome do produto");
            }

            else { 


            SqlConnection conexao = new SqlConnection("Data Source=localhost;Initial Catalog=TCC1;Integrated Security=True;Pooling=False");
            SqlDataReader dr = null;

            try
            {
                // 2. Abre a conexão
                conexao.Open();

                // prepara um comando SQL para incluir dados usando a instrução INSERT INTO
                // string incluiSQL = " insert into produto (nome, valorv, valorc, estoque, validade, grupo, estoquemin) values ("txt_nome_produto.Text", "txt_valorv_produto.Text", "txt_valorc_produto.Text", "txtbox_estoqueatual", "txtbox_valid_prod", "combobox_depto_prod", "txtbox_estoquemin"')";
               



                string incluiSQL = " insert into produto (nome, valorv, valorc, estoque) values ('" + n+ "', '"+ vv+"', '"+ vc+"', '"+ ea+ "')";
                

                // 1. Instancia um novo comando com uma consulta e uma conexão
                SqlCommand cmd = new SqlCommand(incluiSQL, conexao);

                // 2. Chama o método ExecuteNonQuery para enviar o comando
                cmd.ExecuteNonQuery();

               

                MessageBox.Show("Produto cadastrado com sucesso.");

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

                txt_id_produto.Text = "";
                txt_nome_produto.Text = "";
                combobox_depto_prod.Text = "";
                txtbox_valid_prod.Text = "";
                txt_valorv_produto.Text = "";
                txt_valorc_produto.Text = "";
                txtbox_estoqueatual.Text = "";
                txtbox_estoquemin.Text = "";
            }
        }

        private void CADASTROPRODUTO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tCC1DataSet.grupos' table. You can move, or remove it, as needed.
            this.gruposTableAdapter.Fill(this.tCC1DataSet.grupos);

        }

        private void txt_id_produto_Leave(object sender, EventArgs e)
        {
           
        }
    }
}

