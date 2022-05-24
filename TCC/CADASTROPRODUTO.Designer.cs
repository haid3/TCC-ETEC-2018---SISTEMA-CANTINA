namespace TCC
{
    partial class CADASTROPRODUTO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_datavenc_prod = new System.Windows.Forms.Label();
            this.txt_valorv_produto = new System.Windows.Forms.TextBox();
            this.lbl_email_c = new System.Windows.Forms.Label();
            this.txt_id_produto = new System.Windows.Forms.TextBox();
            this.lbl_id_produto = new System.Windows.Forms.Label();
            this.txt_nome_produto = new System.Windows.Forms.TextBox();
            this.lbl_nomeproduto = new System.Windows.Forms.Label();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valorc_produto = new System.Windows.Forms.TextBox();
            this.lbl_depto_prod = new System.Windows.Forms.Label();
            this.combobox_depto_prod = new System.Windows.Forms.ComboBox();
            this.txtbox_estoquemin = new System.Windows.Forms.TextBox();
            this.lbl_estoquemin = new System.Windows.Forms.Label();
            this.txtbox_estoqueatual = new System.Windows.Forms.TextBox();
            this.lbl_estoqueatual = new System.Windows.Forms.Label();
            this.txtbox_valid_prod = new System.Windows.Forms.TextBox();
            this.lbl_dias_prod = new System.Windows.Forms.Label();
            this.tCC1DataSet = new TCC.TCC1DataSet();
            this.tCC1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposTableAdapter = new TCC.TCC1DataSetTableAdapters.gruposTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tCC1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCC1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cadastro Produtos ";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(503, 279);
            this.btn_voltar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(96, 38);
            this.btn_voltar.TabIndex = 37;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(326, 279);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(96, 38);
            this.btn_limpar.TabIndex = 36;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 34;
            // 
            // lbl_datavenc_prod
            // 
            this.lbl_datavenc_prod.AutoSize = true;
            this.lbl_datavenc_prod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datavenc_prod.Location = new System.Drawing.Point(242, 228);
            this.lbl_datavenc_prod.Name = "lbl_datavenc_prod";
            this.lbl_datavenc_prod.Size = new System.Drawing.Size(171, 21);
            this.lbl_datavenc_prod.TabIndex = 33;
            this.lbl_datavenc_prod.Text = "Validade do produto:";
            // 
            // txt_valorv_produto
            // 
            this.txt_valorv_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorv_produto.Location = new System.Drawing.Point(125, 159);
            this.txt_valorv_produto.Name = "txt_valorv_produto";
            this.txt_valorv_produto.Size = new System.Drawing.Size(86, 29);
            this.txt_valorv_produto.TabIndex = 32;
            this.txt_valorv_produto.TextChanged += new System.EventHandler(this.txt_valorv_produto_TextChanged);
            this.txt_valorv_produto.Enter += new System.EventHandler(this.txt_valorv_produto_Enter);
            this.txt_valorv_produto.Leave += new System.EventHandler(this.txt_valorv_produto_Leave);
            // 
            // lbl_email_c
            // 
            this.lbl_email_c.AutoSize = true;
            this.lbl_email_c.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email_c.Location = new System.Drawing.Point(20, 162);
            this.lbl_email_c.Name = "lbl_email_c";
            this.lbl_email_c.Size = new System.Drawing.Size(106, 21);
            this.lbl_email_c.TabIndex = 31;
            this.lbl_email_c.Text = "Valor Venda:";
            this.lbl_email_c.Click += new System.EventHandler(this.lbl_email_c_Click);
            // 
            // txt_id_produto
            // 
            this.txt_id_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_produto.Location = new System.Drawing.Point(56, 102);
            this.txt_id_produto.Name = "txt_id_produto";
            this.txt_id_produto.Size = new System.Drawing.Size(50, 29);
            this.txt_id_produto.TabIndex = 30;
            this.txt_id_produto.Leave += new System.EventHandler(this.txt_id_produto_Leave);
            // 
            // lbl_id_produto
            // 
            this.lbl_id_produto.AutoSize = true;
            this.lbl_id_produto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_produto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_id_produto.Location = new System.Drawing.Point(24, 105);
            this.lbl_id_produto.Name = "lbl_id_produto";
            this.lbl_id_produto.Size = new System.Drawing.Size(31, 21);
            this.lbl_id_produto.TabIndex = 29;
            this.lbl_id_produto.Text = "ID:";
            // 
            // txt_nome_produto
            // 
            this.txt_nome_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome_produto.Location = new System.Drawing.Point(206, 102);
            this.txt_nome_produto.Name = "txt_nome_produto";
            this.txt_nome_produto.Size = new System.Drawing.Size(241, 29);
            this.txt_nome_produto.TabIndex = 28;
            // 
            // lbl_nomeproduto
            // 
            this.lbl_nomeproduto.AutoSize = true;
            this.lbl_nomeproduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeproduto.Location = new System.Drawing.Point(116, 106);
            this.lbl_nomeproduto.Name = "lbl_nomeproduto";
            this.lbl_nomeproduto.Size = new System.Drawing.Size(88, 21);
            this.lbl_nomeproduto.TabIndex = 27;
            this.lbl_nomeproduto.Text = "Descrição:";
            // 
            // btn_gravar
            // 
            this.btn_gravar.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar.Location = new System.Drawing.Point(158, 282);
            this.btn_gravar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(96, 38);
            this.btn_gravar.TabIndex = 39;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Valor da Compra:";
            // 
            // txt_valorc_produto
            // 
            this.txt_valorc_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorc_produto.Location = new System.Drawing.Point(419, 159);
            this.txt_valorc_produto.Name = "txt_valorc_produto";
            this.txt_valorc_produto.Size = new System.Drawing.Size(85, 29);
            this.txt_valorc_produto.TabIndex = 41;
            this.txt_valorc_produto.TextChanged += new System.EventHandler(this.txt_valorc_produto_TextChanged);
            this.txt_valorc_produto.Enter += new System.EventHandler(this.txt_valorc_produto_Enter);
            this.txt_valorc_produto.Leave += new System.EventHandler(this.txt_valorc_produto_Leave);
            // 
            // lbl_depto_prod
            // 
            this.lbl_depto_prod.AutoSize = true;
            this.lbl_depto_prod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_depto_prod.Location = new System.Drawing.Point(452, 107);
            this.lbl_depto_prod.Name = "lbl_depto_prod";
            this.lbl_depto_prod.Size = new System.Drawing.Size(125, 21);
            this.lbl_depto_prod.TabIndex = 44;
            this.lbl_depto_prod.Text = "Departamento:";
            // 
            // combobox_depto_prod
            // 
            this.combobox_depto_prod.DataSource = this.gruposBindingSource;
            this.combobox_depto_prod.DisplayMember = "nome";
            this.combobox_depto_prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_depto_prod.FormattingEnabled = true;
            this.combobox_depto_prod.Location = new System.Drawing.Point(579, 110);
            this.combobox_depto_prod.Name = "combobox_depto_prod";
            this.combobox_depto_prod.Size = new System.Drawing.Size(159, 21);
            this.combobox_depto_prod.TabIndex = 45;
            this.combobox_depto_prod.ValueMember = "nome";
            // 
            // txtbox_estoquemin
            // 
            this.txtbox_estoquemin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_estoquemin.Location = new System.Drawing.Point(165, 226);
            this.txtbox_estoquemin.Name = "txtbox_estoquemin";
            this.txtbox_estoquemin.Size = new System.Drawing.Size(46, 29);
            this.txtbox_estoquemin.TabIndex = 49;
            // 
            // lbl_estoquemin
            // 
            this.lbl_estoquemin.AutoSize = true;
            this.lbl_estoquemin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estoquemin.Location = new System.Drawing.Point(20, 228);
            this.lbl_estoquemin.Name = "lbl_estoquemin";
            this.lbl_estoquemin.Size = new System.Drawing.Size(139, 21);
            this.lbl_estoquemin.TabIndex = 48;
            this.lbl_estoquemin.Text = "Estoque mínimo:";
            // 
            // txtbox_estoqueatual
            // 
            this.txtbox_estoqueatual.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_estoqueatual.Location = new System.Drawing.Point(677, 159);
            this.txtbox_estoqueatual.Name = "txtbox_estoqueatual";
            this.txtbox_estoqueatual.Size = new System.Drawing.Size(60, 29);
            this.txtbox_estoqueatual.TabIndex = 47;
            // 
            // lbl_estoqueatual
            // 
            this.lbl_estoqueatual.AutoSize = true;
            this.lbl_estoqueatual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estoqueatual.Location = new System.Drawing.Point(553, 162);
            this.lbl_estoqueatual.Name = "lbl_estoqueatual";
            this.lbl_estoqueatual.Size = new System.Drawing.Size(118, 21);
            this.lbl_estoqueatual.TabIndex = 46;
            this.lbl_estoqueatual.Text = "Estoque atual:";
            // 
            // txtbox_valid_prod
            // 
            this.txtbox_valid_prod.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_valid_prod.Location = new System.Drawing.Point(419, 226);
            this.txtbox_valid_prod.Name = "txtbox_valid_prod";
            this.txtbox_valid_prod.Size = new System.Drawing.Size(57, 29);
            this.txtbox_valid_prod.TabIndex = 50;
            // 
            // lbl_dias_prod
            // 
            this.lbl_dias_prod.AutoSize = true;
            this.lbl_dias_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dias_prod.Location = new System.Drawing.Point(482, 240);
            this.lbl_dias_prod.Name = "lbl_dias_prod";
            this.lbl_dias_prod.Size = new System.Drawing.Size(30, 15);
            this.lbl_dias_prod.TabIndex = 51;
            this.lbl_dias_prod.Text = "dias";
            // 
            // tCC1DataSet
            // 
            this.tCC1DataSet.DataSetName = "TCC1DataSet";
            this.tCC1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tCC1DataSetBindingSource
            // 
            this.tCC1DataSetBindingSource.DataSource = this.tCC1DataSet;
            this.tCC1DataSetBindingSource.Position = 0;
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "grupos";
            this.gruposBindingSource.DataSource = this.tCC1DataSet;
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
            // 
            // CADASTROPRODUTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(764, 336);
            this.Controls.Add(this.lbl_dias_prod);
            this.Controls.Add(this.txtbox_valid_prod);
            this.Controls.Add(this.txtbox_estoquemin);
            this.Controls.Add(this.lbl_estoquemin);
            this.Controls.Add(this.txtbox_estoqueatual);
            this.Controls.Add(this.lbl_estoqueatual);
            this.Controls.Add(this.combobox_depto_prod);
            this.Controls.Add(this.lbl_depto_prod);
            this.Controls.Add(this.txt_valorc_produto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_datavenc_prod);
            this.Controls.Add(this.txt_valorv_produto);
            this.Controls.Add(this.lbl_email_c);
            this.Controls.Add(this.txt_id_produto);
            this.Controls.Add(this.lbl_id_produto);
            this.Controls.Add(this.txt_nome_produto);
            this.Controls.Add(this.lbl_nomeproduto);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CADASTROPRODUTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " PRODUTOS CADASTRADOS";
            this.Load += new System.EventHandler(this.CADASTROPRODUTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tCC1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCC1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_datavenc_prod;
        private System.Windows.Forms.TextBox txt_valorv_produto;
        private System.Windows.Forms.Label lbl_email_c;
        private System.Windows.Forms.TextBox txt_id_produto;
        private System.Windows.Forms.Label lbl_id_produto;
        private System.Windows.Forms.TextBox txt_nome_produto;
        private System.Windows.Forms.Label lbl_nomeproduto;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valorc_produto;
        private System.Windows.Forms.Label lbl_depto_prod;
        private System.Windows.Forms.ComboBox combobox_depto_prod;
        private System.Windows.Forms.TextBox txtbox_estoquemin;
        private System.Windows.Forms.Label lbl_estoquemin;
        private System.Windows.Forms.TextBox txtbox_estoqueatual;
        private System.Windows.Forms.Label lbl_estoqueatual;
        private System.Windows.Forms.TextBox txtbox_valid_prod;
        private System.Windows.Forms.Label lbl_dias_prod;
        private System.Windows.Forms.BindingSource tCC1DataSetBindingSource;
        private TCC1DataSet tCC1DataSet;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private TCC1DataSetTableAdapters.gruposTableAdapter gruposTableAdapter;
    }
}