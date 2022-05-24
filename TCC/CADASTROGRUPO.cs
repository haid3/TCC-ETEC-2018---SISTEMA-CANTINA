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
    public partial class CADASTROGRUPO : Form
    {
        public CADASTROGRUPO()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtbox_id_depto.Text = "";
            txtbox_nome_depto.Text = "";
            combobox_situacao_depto.Text = "";
        }

        private void btn_novo_grupo_Click(object sender, EventArgs e)
        {
            txtbox_id_depto.Focus();

            SqlConnection conexao = new SqlConnection("Data Source=localhost;Initial Catalog=TCC1;Integrated Security=True;Pooling=False");
            SqlDataReader dr = null;

            try
            {
                // 2. Abre a conexão
                conexao.Open();

                // prepara um comando SQL para incluir dados usando a instrução INSERT INTO
                // string incluiSQL = " insert into produto (nome, valorv, valorc, estoque, validade, grupo, estoquemin) values ("txt_nome_produto.Text", "txt_valorv_produto.Text", "txt_valorc_produto.Text", "txtbox_estoqueatual", "txtbox_valid_prod", "combobox_depto_prod", "txtbox_estoquemin"')";


                string Apresentanovoid = "select MAX (id_grupo) from grupos";
               

                SqlCommand cmd = new SqlCommand(Apresentanovoid, conexao);
                SqlDataReader reader = cmd.ExecuteReader(); //realiza a consulta criada pelo SQLCommand
                if (reader.HasRows) //verifica se foi encontrado linhas
                {
                    while (reader.Read()) //enquanto tiver linha
                    {
                        MessageBox.Show(reader.GetInt32(0).ToString()); //pega a primeira posição do array - GetInt32(0): posição 0
                        MessageBox.Show("teste");
                    }
                }
                else //senao
                {
                    Console.WriteLine("Nada foi encontrado"); //exibe mensagem de nada encontrado
                }
                reader.Close(); //fecha a consulta e libera a memoria
         

            // 1. Instancia um novo comando com uma consulta e uma conexão


            // 2. Chama o método ExecuteNonQuery para enviar o comando
            //    cmd.ExecuteNonQuery();


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
        }

        private void btn_gravar_grupo_Click(object sender, EventArgs e)
        {
            string n = txtbox_nome_depto.Text;
            string s = combobox_situacao_depto.Text;




            if (n == "")
            {
                MessageBox.Show("É necessário preencher o nome do grupo");
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




                    string incluiSQL = " insert into grupos (nome, situacao_ativo) values ('" + n + "', '" + s + "')";


                    // 1. Instancia um novo comando com uma consulta e uma conexão
                    SqlCommand cmd = new SqlCommand(incluiSQL, conexao);

                    // 2. Chama o método ExecuteNonQuery para enviar o comando
                    cmd.ExecuteNonQuery();



                    MessageBox.Show("Grupo cadastrado com sucesso.");



                    //datagrid_grupos.Refresh();
                    
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
            }
            
            
        }

        private void CADASTROGRUPO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tCC1DataSet1.grupos' table. You can move, or remove it, as needed.
            this.gruposTableAdapter.Fill(this.tCC1DataSet1.grupos);

        }

        private void btn_excluir_grupo_Click(object sender, EventArgs e)
        {
          /*  string sql = "Delete from grupos where Codigo= " + datagrid_grupos.CurrentRow.Cells[0].Value;
            SqlConnection conexao = new SqlConnection(cnSql);
            SqlCommand comando = new SqlCommand(sql, conexao);
            conexao.Open();
            int i = comando.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show(i + "Dados Excluídos Com Sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                consultar();
            }

            conexao.Close(); */
        }

        private void btn_editar_grupo_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
