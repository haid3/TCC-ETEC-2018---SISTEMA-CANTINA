namespace TCC
{
    partial class ESTOQUEATUAL
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
            this.label5 = new System.Windows.Forms.Label();
            this.btn_voltarproduto = new System.Windows.Forms.Button();
            this.datagrid_grupos = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_grupos)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 40);
            this.label5.TabIndex = 37;
            this.label5.Text = "Estoque Atual";
            // 
            // btn_voltarproduto
            // 
            this.btn_voltarproduto.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarproduto.Location = new System.Drawing.Point(704, 471);
            this.btn_voltarproduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_voltarproduto.Name = "btn_voltarproduto";
            this.btn_voltarproduto.Size = new System.Drawing.Size(96, 39);
            this.btn_voltarproduto.TabIndex = 42;
            this.btn_voltarproduto.Text = "Voltar";
            this.btn_voltarproduto.UseVisualStyleBackColor = true;
            this.btn_voltarproduto.Click += new System.EventHandler(this.btn_voltarproduto_Click);
            // 
            // datagrid_grupos
            // 
            this.datagrid_grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_grupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Nome,
            this.VALOR,
            this.Column4,
            this.Column1});
            this.datagrid_grupos.Location = new System.Drawing.Point(58, 92);
            this.datagrid_grupos.Name = "datagrid_grupos";
            this.datagrid_grupos.Size = new System.Drawing.Size(742, 306);
            this.datagrid_grupos.TabIndex = 65;
            // 
            // Data
            // 
            this.Data.HeaderText = "Id Produto:";
            this.Data.Name = "Data";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "nome_cli";
            this.Nome.FillWeight = 130F;
            this.Nome.HeaderText = "Produto:";
            this.Nome.Name = "Nome";
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "Quantidade Min";
            this.VALOR.Name = "VALOR";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Quantidade atual";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor compra";
            this.Column1.Name = "Column1";
            // 
            // ESTOQUEATUAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 521);
            this.Controls.Add(this.datagrid_grupos);
            this.Controls.Add(this.btn_voltarproduto);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ESTOQUEATUAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTOQUE ATUAL";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_grupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_voltarproduto;
        private System.Windows.Forms.DataGridView datagrid_grupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}