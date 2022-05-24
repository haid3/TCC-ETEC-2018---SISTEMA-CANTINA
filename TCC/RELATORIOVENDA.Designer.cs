namespace TCC
{
    partial class RELATORIOVENDA
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
            this.txtbox_ate = new System.Windows.Forms.TextBox();
            this.txtbox_de = new System.Windows.Forms.TextBox();
            this.lbl_de = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_filtrodata = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_total_sangrias = new System.Windows.Forms.Label();
            this.datagrid_vendas = new System.Windows.Forms.DataGridView();
            this.lbl_RELATORIOVENDAS = new System.Windows.Forms.Label();
            this.btn_voltarvendas = new System.Windows.Forms.Button();
            this.btn_excluirvendas = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_ate
            // 
            this.txtbox_ate.Location = new System.Drawing.Point(302, 113);
            this.txtbox_ate.Name = "txtbox_ate";
            this.txtbox_ate.Size = new System.Drawing.Size(127, 22);
            this.txtbox_ate.TabIndex = 71;
            // 
            // txtbox_de
            // 
            this.txtbox_de.Location = new System.Drawing.Point(124, 113);
            this.txtbox_de.Name = "txtbox_de";
            this.txtbox_de.Size = new System.Drawing.Size(127, 22);
            this.txtbox_de.TabIndex = 70;
            // 
            // lbl_de
            // 
            this.lbl_de.AutoSize = true;
            this.lbl_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_de.Location = new System.Drawing.Point(82, 116);
            this.lbl_de.Name = "lbl_de";
            this.lbl_de.Size = new System.Drawing.Size(36, 20);
            this.lbl_de.TabIndex = 69;
            this.lbl_de.Text = "De:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Até:";
            // 
            // btn_filtrodata
            // 
            this.btn_filtrodata.Location = new System.Drawing.Point(454, 113);
            this.btn_filtrodata.Name = "btn_filtrodata";
            this.btn_filtrodata.Size = new System.Drawing.Size(94, 23);
            this.btn_filtrodata.TabIndex = 67;
            this.btn_filtrodata.Text = "Pesquisar";
            this.btn_filtrodata.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(974, 515);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 66;
            // 
            // lbl_total_sangrias
            // 
            this.lbl_total_sangrias.AutoSize = true;
            this.lbl_total_sangrias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_sangrias.Location = new System.Drawing.Point(916, 517);
            this.lbl_total_sangrias.Name = "lbl_total_sangrias";
            this.lbl_total_sangrias.Size = new System.Drawing.Size(51, 20);
            this.lbl_total_sangrias.TabIndex = 65;
            this.lbl_total_sangrias.Text = "Total:";
            // 
            // datagrid_vendas
            // 
            this.datagrid_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Nome,
            this.Column4,
            this.VALOR});
            this.datagrid_vendas.Location = new System.Drawing.Point(84, 148);
            this.datagrid_vendas.Margin = new System.Windows.Forms.Padding(4);
            this.datagrid_vendas.Name = "datagrid_vendas";
            this.datagrid_vendas.Size = new System.Drawing.Size(990, 360);
            this.datagrid_vendas.TabIndex = 64;
            // 
            // lbl_RELATORIOVENDAS
            // 
            this.lbl_RELATORIOVENDAS.AutoSize = true;
            this.lbl_RELATORIOVENDAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RELATORIOVENDAS.Location = new System.Drawing.Point(447, 36);
            this.lbl_RELATORIOVENDAS.Name = "lbl_RELATORIOVENDAS";
            this.lbl_RELATORIOVENDAS.Size = new System.Drawing.Size(279, 39);
            this.lbl_RELATORIOVENDAS.TabIndex = 63;
            this.lbl_RELATORIOVENDAS.Text = "Relatório Vendas";
            // 
            // btn_voltarvendas
            // 
            this.btn_voltarvendas.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarvendas.Location = new System.Drawing.Point(607, 546);
            this.btn_voltarvendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_voltarvendas.Name = "btn_voltarvendas";
            this.btn_voltarvendas.Size = new System.Drawing.Size(128, 48);
            this.btn_voltarvendas.TabIndex = 61;
            this.btn_voltarvendas.Text = "Voltar";
            this.btn_voltarvendas.UseVisualStyleBackColor = true;
            // 
            // btn_excluirvendas
            // 
            this.btn_excluirvendas.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluirvendas.Location = new System.Drawing.Point(420, 546);
            this.btn_excluirvendas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excluirvendas.Name = "btn_excluirvendas";
            this.btn_excluirvendas.Size = new System.Drawing.Size(128, 47);
            this.btn_excluirvendas.TabIndex = 59;
            this.btn_excluirvendas.Text = "Excluir";
            this.btn_excluirvendas.UseVisualStyleBackColor = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data:";
            this.Data.Name = "Data";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "nome_cli";
            this.Nome.FillWeight = 130F;
            this.Nome.HeaderText = "Cliente:";
            this.Nome.Name = "Nome";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Forma de pagamento";
            this.Column4.Name = "Column4";
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "Valor:";
            this.VALOR.Name = "VALOR";
            // 
            // RELATORIOVENDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 623);
            this.Controls.Add(this.txtbox_ate);
            this.Controls.Add(this.txtbox_de);
            this.Controls.Add(this.lbl_de);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_filtrodata);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_total_sangrias);
            this.Controls.Add(this.datagrid_vendas);
            this.Controls.Add(this.lbl_RELATORIOVENDAS);
            this.Controls.Add(this.btn_voltarvendas);
            this.Controls.Add(this.btn_excluirvendas);
            this.Name = "RELATORIOVENDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATORIOVENDA";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_vendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_ate;
        private System.Windows.Forms.TextBox txtbox_de;
        private System.Windows.Forms.Label lbl_de;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_filtrodata;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_total_sangrias;
        private System.Windows.Forms.DataGridView datagrid_vendas;
        private System.Windows.Forms.Label lbl_RELATORIOVENDAS;
        private System.Windows.Forms.Button btn_voltarvendas;
        private System.Windows.Forms.Button btn_excluirvendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
    }
}