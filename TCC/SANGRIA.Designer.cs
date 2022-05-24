namespace TCC
{
    partial class SANGRIA
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
            this.txtbox_idsangria = new System.Windows.Forms.TextBox();
            this.txtbox_valorsangria = new System.Windows.Forms.TextBox();
            this.txtbox_descsangria = new System.Windows.Forms.TextBox();
            this.cbbox_tiposangria = new System.Windows.Forms.ComboBox();
            this.lbl_id_sangria = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_desc_sangria = new System.Windows.Forms.Label();
            this.lbl_tipo_sangria = new System.Windows.Forms.Label();
            this.btn_gravarsangria = new System.Windows.Forms.Button();
            this.btn_voltarsangria = new System.Windows.Forms.Button();
            this.btn_novasangria = new System.Windows.Forms.Button();
            this.btn_excluirsangria = new System.Windows.Forms.Button();
            this.lbl_sangriascadastradas = new System.Windows.Forms.Label();
            this.datagrid_grupos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_total_sangrias = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_filtrodata = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_de = new System.Windows.Forms.Label();
            this.txtbox_de = new System.Windows.Forms.TextBox();
            this.txtbox_ate = new System.Windows.Forms.TextBox();
            this.lbl_datasangria = new System.Windows.Forms.Label();
            this.txtbox_datasangria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_grupos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_idsangria
            // 
            this.txtbox_idsangria.Location = new System.Drawing.Point(64, 411);
            this.txtbox_idsangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_idsangria.Name = "txtbox_idsangria";
            this.txtbox_idsangria.Size = new System.Drawing.Size(50, 20);
            this.txtbox_idsangria.TabIndex = 1;
            // 
            // txtbox_valorsangria
            // 
            this.txtbox_valorsangria.Location = new System.Drawing.Point(283, 411);
            this.txtbox_valorsangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_valorsangria.Name = "txtbox_valorsangria";
            this.txtbox_valorsangria.Size = new System.Drawing.Size(69, 20);
            this.txtbox_valorsangria.TabIndex = 2;
            // 
            // txtbox_descsangria
            // 
            this.txtbox_descsangria.Location = new System.Drawing.Point(434, 410);
            this.txtbox_descsangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_descsangria.Name = "txtbox_descsangria";
            this.txtbox_descsangria.Size = new System.Drawing.Size(206, 20);
            this.txtbox_descsangria.TabIndex = 3;
            // 
            // cbbox_tiposangria
            // 
            this.cbbox_tiposangria.FormattingEnabled = true;
            this.cbbox_tiposangria.Location = new System.Drawing.Point(686, 411);
            this.cbbox_tiposangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbox_tiposangria.Name = "cbbox_tiposangria";
            this.cbbox_tiposangria.Size = new System.Drawing.Size(98, 21);
            this.cbbox_tiposangria.TabIndex = 4;
            // 
            // lbl_id_sangria
            // 
            this.lbl_id_sangria.AutoSize = true;
            this.lbl_id_sangria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_sangria.Location = new System.Drawing.Point(37, 411);
            this.lbl_id_sangria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id_sangria.Name = "lbl_id_sangria";
            this.lbl_id_sangria.Size = new System.Drawing.Size(25, 17);
            this.lbl_id_sangria.TabIndex = 5;
            this.lbl_id_sangria.Text = "ID:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(237, 411);
            this.lbl_valor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(45, 17);
            this.lbl_valor.TabIndex = 6;
            this.lbl_valor.Text = "Valor:";
            // 
            // lbl_desc_sangria
            // 
            this.lbl_desc_sangria.AutoSize = true;
            this.lbl_desc_sangria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc_sangria.Location = new System.Drawing.Point(358, 413);
            this.lbl_desc_sangria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_desc_sangria.Name = "lbl_desc_sangria";
            this.lbl_desc_sangria.Size = new System.Drawing.Size(75, 17);
            this.lbl_desc_sangria.TabIndex = 7;
            this.lbl_desc_sangria.Text = "Descrição:";
            // 
            // lbl_tipo_sangria
            // 
            this.lbl_tipo_sangria.AutoSize = true;
            this.lbl_tipo_sangria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_sangria.Location = new System.Drawing.Point(646, 411);
            this.lbl_tipo_sangria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tipo_sangria.Name = "lbl_tipo_sangria";
            this.lbl_tipo_sangria.Size = new System.Drawing.Size(40, 17);
            this.lbl_tipo_sangria.TabIndex = 8;
            this.lbl_tipo_sangria.Text = "Tipo:";
            // 
            // btn_gravarsangria
            // 
            this.btn_gravarsangria.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravarsangria.Location = new System.Drawing.Point(406, 448);
            this.btn_gravarsangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_gravarsangria.Name = "btn_gravarsangria";
            this.btn_gravarsangria.Size = new System.Drawing.Size(96, 38);
            this.btn_gravarsangria.TabIndex = 39;
            this.btn_gravarsangria.Text = "Gravar";
            this.btn_gravarsangria.UseVisualStyleBackColor = true;
            // 
            // btn_voltarsangria
            // 
            this.btn_voltarsangria.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarsangria.Location = new System.Drawing.Point(558, 447);
            this.btn_voltarsangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_voltarsangria.Name = "btn_voltarsangria";
            this.btn_voltarsangria.Size = new System.Drawing.Size(96, 39);
            this.btn_voltarsangria.TabIndex = 38;
            this.btn_voltarsangria.Text = "Voltar";
            this.btn_voltarsangria.UseVisualStyleBackColor = true;
            this.btn_voltarsangria.Click += new System.EventHandler(this.btn_voltarproduto_Click);
            // 
            // btn_novasangria
            // 
            this.btn_novasangria.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novasangria.Location = new System.Drawing.Point(254, 448);
            this.btn_novasangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_novasangria.Name = "btn_novasangria";
            this.btn_novasangria.Size = new System.Drawing.Size(96, 38);
            this.btn_novasangria.TabIndex = 37;
            this.btn_novasangria.Text = "Novo";
            this.btn_novasangria.UseVisualStyleBackColor = true;
            this.btn_novasangria.Click += new System.EventHandler(this.btn_novasangria_Click);
            // 
            // btn_excluirsangria
            // 
            this.btn_excluirsangria.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluirsangria.Location = new System.Drawing.Point(104, 448);
            this.btn_excluirsangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_excluirsangria.Name = "btn_excluirsangria";
            this.btn_excluirsangria.Size = new System.Drawing.Size(96, 38);
            this.btn_excluirsangria.TabIndex = 36;
            this.btn_excluirsangria.Text = "Excluir";
            this.btn_excluirsangria.UseVisualStyleBackColor = true;
            // 
            // lbl_sangriascadastradas
            // 
            this.lbl_sangriascadastradas.AutoSize = true;
            this.lbl_sangriascadastradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sangriascadastradas.Location = new System.Drawing.Point(348, 28);
            this.lbl_sangriascadastradas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sangriascadastradas.Name = "lbl_sangriascadastradas";
            this.lbl_sangriascadastradas.Size = new System.Drawing.Size(121, 31);
            this.lbl_sangriascadastradas.TabIndex = 40;
            this.lbl_sangriascadastradas.Text = "Sangrias";
            // 
            // datagrid_grupos
            // 
            this.datagrid_grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_grupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Data,
            this.VALOR,
            this.Nome,
            this.Column4});
            this.datagrid_grupos.Location = new System.Drawing.Point(40, 115);
            this.datagrid_grupos.Name = "datagrid_grupos";
            this.datagrid_grupos.Size = new System.Drawing.Size(742, 251);
            this.datagrid_grupos.TabIndex = 41;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "id_cli";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "Valor";
            this.VALOR.Name = "VALOR";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "nome_cli";
            this.Nome.FillWeight = 130F;
            this.Nome.HeaderText = "Descrição";
            this.Nome.Name = "Nome";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "email_cli";
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            // 
            // lbl_total_sangrias
            // 
            this.lbl_total_sangrias.AutoSize = true;
            this.lbl_total_sangrias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_sangrias.Location = new System.Drawing.Point(664, 373);
            this.lbl_total_sangrias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total_sangrias.Name = "lbl_total_sangrias";
            this.lbl_total_sangrias.Size = new System.Drawing.Size(44, 17);
            this.lbl_total_sangrias.TabIndex = 42;
            this.lbl_total_sangrias.Text = "Total:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(707, 371);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 43;
            // 
            // btn_filtrodata
            // 
            this.btn_filtrodata.Location = new System.Drawing.Point(317, 86);
            this.btn_filtrodata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_filtrodata.Name = "btn_filtrodata";
            this.btn_filtrodata.Size = new System.Drawing.Size(70, 19);
            this.btn_filtrodata.TabIndex = 44;
            this.btn_filtrodata.Text = "Pesquisar";
            this.btn_filtrodata.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Até:";
            // 
            // lbl_de
            // 
            this.lbl_de.AutoSize = true;
            this.lbl_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_de.Location = new System.Drawing.Point(38, 89);
            this.lbl_de.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_de.Name = "lbl_de";
            this.lbl_de.Size = new System.Drawing.Size(30, 17);
            this.lbl_de.TabIndex = 46;
            this.lbl_de.Text = "De:";
            // 
            // txtbox_de
            // 
            this.txtbox_de.Location = new System.Drawing.Point(70, 86);
            this.txtbox_de.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_de.Name = "txtbox_de";
            this.txtbox_de.Size = new System.Drawing.Size(96, 20);
            this.txtbox_de.TabIndex = 47;
            // 
            // txtbox_ate
            // 
            this.txtbox_ate.Location = new System.Drawing.Point(203, 86);
            this.txtbox_ate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_ate.Name = "txtbox_ate";
            this.txtbox_ate.Size = new System.Drawing.Size(96, 20);
            this.txtbox_ate.TabIndex = 48;
            // 
            // lbl_datasangria
            // 
            this.lbl_datasangria.AutoSize = true;
            this.lbl_datasangria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datasangria.Location = new System.Drawing.Point(119, 411);
            this.lbl_datasangria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_datasangria.Name = "lbl_datasangria";
            this.lbl_datasangria.Size = new System.Drawing.Size(42, 17);
            this.lbl_datasangria.TabIndex = 50;
            this.lbl_datasangria.Text = "Data:";
            // 
            // txtbox_datasangria
            // 
            this.txtbox_datasangria.Location = new System.Drawing.Point(165, 411);
            this.txtbox_datasangria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_datasangria.Name = "txtbox_datasangria";
            this.txtbox_datasangria.Size = new System.Drawing.Size(66, 20);
            this.txtbox_datasangria.TabIndex = 49;
            // 
            // SANGRIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 502);
            this.Controls.Add(this.lbl_datasangria);
            this.Controls.Add(this.txtbox_datasangria);
            this.Controls.Add(this.txtbox_ate);
            this.Controls.Add(this.txtbox_de);
            this.Controls.Add(this.lbl_de);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_filtrodata);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_total_sangrias);
            this.Controls.Add(this.datagrid_grupos);
            this.Controls.Add(this.lbl_sangriascadastradas);
            this.Controls.Add(this.btn_gravarsangria);
            this.Controls.Add(this.btn_voltarsangria);
            this.Controls.Add(this.btn_novasangria);
            this.Controls.Add(this.btn_excluirsangria);
            this.Controls.Add(this.lbl_tipo_sangria);
            this.Controls.Add(this.lbl_desc_sangria);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_id_sangria);
            this.Controls.Add(this.cbbox_tiposangria);
            this.Controls.Add(this.txtbox_descsangria);
            this.Controls.Add(this.txtbox_valorsangria);
            this.Controls.Add(this.txtbox_idsangria);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SANGRIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SANGRIA";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_grupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_idsangria;
        private System.Windows.Forms.TextBox txtbox_valorsangria;
        private System.Windows.Forms.TextBox txtbox_descsangria;
        private System.Windows.Forms.ComboBox cbbox_tiposangria;
        private System.Windows.Forms.Label lbl_id_sangria;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_desc_sangria;
        private System.Windows.Forms.Label lbl_tipo_sangria;
        private System.Windows.Forms.Button btn_gravarsangria;
        private System.Windows.Forms.Button btn_voltarsangria;
        private System.Windows.Forms.Button btn_novasangria;
        private System.Windows.Forms.Button btn_excluirsangria;
        private System.Windows.Forms.Label lbl_sangriascadastradas;
        private System.Windows.Forms.DataGridView datagrid_grupos;
        private System.Windows.Forms.Label lbl_total_sangrias;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_filtrodata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_de;
        private System.Windows.Forms.TextBox txtbox_de;
        private System.Windows.Forms.TextBox txtbox_ate;
        private System.Windows.Forms.Label lbl_datasangria;
        private System.Windows.Forms.TextBox txtbox_datasangria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}