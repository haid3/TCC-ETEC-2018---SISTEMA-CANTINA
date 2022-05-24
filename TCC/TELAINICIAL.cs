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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTROPRODUTO cadastrar = new CADASTROPRODUTO();
            cadastrar.ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTROGRUPO cadastrargrupo = new CADASTROGRUPO();
            cadastrargrupo.ShowDialog();
        }

        private void formasPagtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTROCLIENTE cadastrar = new CADASTROCLIENTE();
            cadastrar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COMPRA compra = new COMPRA();
            compra.ShowDialog();
        }

        private void ajustarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ESTOQUEATUAL cadastrar = new ESTOQUEATUAL();
            cadastrar.ShowDialog();
        }

        private void retiradaDoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RETIRAESTOQUE cadastrar = new RETIRAESTOQUE();
            cadastrar.ShowDialog();
        }

        private void relatóriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void estoqueAtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ESTOQUEATUAL cadastrar = new ESTOQUEATUAL();
            cadastrar.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RELATORIOVENDA cadastrar = new RELATORIOVENDA();
            cadastrar.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RELATORIOPRODUTOS cadastrar = new RELATORIOPRODUTOS();
            cadastrar.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RELATORIOCLIENTES cadastrar = new RELATORIOCLIENTES();
            cadastrar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void utilittáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTROUSUARIO cadastrarusuario = new CADASTROUSUARIO();
            cadastrarusuario.ShowDialog();
        }

        private void testeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void adicionarAoCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SANGRIA ADDCAIXA = new SANGRIA();
            ADDCAIXA.ShowDialog();
        }

        private void retiradaDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void group_produtos_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
