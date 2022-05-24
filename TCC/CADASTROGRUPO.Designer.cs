namespace TCC
{
    partial class CADASTROGRUPO
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
            this.btn_voltar_grupo = new System.Windows.Forms.Button();
            this.lbl_descricao_grupos = new System.Windows.Forms.Label();
            this.combobox_situacao_depto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_nome_depto = new System.Windows.Forms.TextBox();
            this.txtbox_id_depto = new System.Windows.Forms.TextBox();
            this.btn_cancelar_grupo = new System.Windows.Forms.Button();
            this.btn_excluir_grupo = new System.Windows.Forms.Button();
            this.btn_editar_grupo = new System.Windows.Forms.Button();
            this.btn_novo_grupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gravar_grupo = new System.Windows.Forms.Button();
            this.datagrid_grupos = new System.Windows.Forms.DataGridView();
            this.idgrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCC1DataSet1 = new TCC.TCC1DataSet1();
            this.gruposTableAdapter = new TCC.TCC1DataSet1TableAdapters.gruposTableAdapter();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_grupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCC1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar_grupo
            // 
            this.btn_voltar_grupo.Location = new System.Drawing.Point(1179, 622);
            this.btn_voltar_grupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_voltar_grupo.Name = "btn_voltar_grupo";
            this.btn_voltar_grupo.Size = new System.Drawing.Size(128, 60);
            this.btn_voltar_grupo.TabIndex = 28;
            this.btn_voltar_grupo.Text = "Voltar";
            this.btn_voltar_grupo.UseVisualStyleBackColor = true;
            this.btn_voltar_grupo.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbl_descricao_grupos
            // 
            this.lbl_descricao_grupos.AutoSize = true;
            this.lbl_descricao_grupos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao_grupos.Location = new System.Drawing.Point(532, 37);
            this.lbl_descricao_grupos.Name = "lbl_descricao_grupos";
            this.lbl_descricao_grupos.Size = new System.Drawing.Size(295, 41);
            this.lbl_descricao_grupos.TabIndex = 27;
            this.lbl_descricao_grupos.Text = "Cadastro de Grupos";
            // 
            // combobox_situacao_depto
            // 
            this.combobox_situacao_depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_situacao_depto.FormattingEnabled = true;
            this.combobox_situacao_depto.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.combobox_situacao_depto.Location = new System.Drawing.Point(557, 640);
            this.combobox_situacao_depto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combobox_situacao_depto.Name = "combobox_situacao_depto";
            this.combobox_situacao_depto.Size = new System.Drawing.Size(192, 24);
            this.combobox_situacao_depto.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 612);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ativo";
            // 
            // txtbox_nome_depto
            // 
            this.txtbox_nome_depto.Location = new System.Drawing.Point(200, 640);
            this.txtbox_nome_depto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_nome_depto.Multiline = true;
            this.txtbox_nome_depto.Name = "txtbox_nome_depto";
            this.txtbox_nome_depto.Size = new System.Drawing.Size(321, 32);
            this.txtbox_nome_depto.TabIndex = 23;
            // 
            // txtbox_id_depto
            // 
            this.txtbox_id_depto.Location = new System.Drawing.Point(49, 640);
            this.txtbox_id_depto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_id_depto.Multiline = true;
            this.txtbox_id_depto.Name = "txtbox_id_depto";
            this.txtbox_id_depto.Size = new System.Drawing.Size(103, 32);
            this.txtbox_id_depto.TabIndex = 22;
            // 
            // btn_cancelar_grupo
            // 
            this.btn_cancelar_grupo.Location = new System.Drawing.Point(1179, 421);
            this.btn_cancelar_grupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar_grupo.Name = "btn_cancelar_grupo";
            this.btn_cancelar_grupo.Size = new System.Drawing.Size(128, 57);
            this.btn_cancelar_grupo.TabIndex = 20;
            this.btn_cancelar_grupo.Text = "Cancelar";
            this.btn_cancelar_grupo.UseVisualStyleBackColor = true;
            this.btn_cancelar_grupo.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_excluir_grupo
            // 
            this.btn_excluir_grupo.Location = new System.Drawing.Point(1179, 310);
            this.btn_excluir_grupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excluir_grupo.Name = "btn_excluir_grupo";
            this.btn_excluir_grupo.Size = new System.Drawing.Size(128, 58);
            this.btn_excluir_grupo.TabIndex = 19;
            this.btn_excluir_grupo.Text = "Excluir";
            this.btn_excluir_grupo.UseVisualStyleBackColor = true;
            this.btn_excluir_grupo.Click += new System.EventHandler(this.btn_excluir_grupo_Click);
            // 
            // btn_editar_grupo
            // 
            this.btn_editar_grupo.Location = new System.Drawing.Point(1179, 201);
            this.btn_editar_grupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editar_grupo.Name = "btn_editar_grupo";
            this.btn_editar_grupo.Size = new System.Drawing.Size(128, 52);
            this.btn_editar_grupo.TabIndex = 18;
            this.btn_editar_grupo.Text = "Editar";
            this.btn_editar_grupo.UseVisualStyleBackColor = true;
            this.btn_editar_grupo.Click += new System.EventHandler(this.btn_editar_grupo_Click);
            // 
            // btn_novo_grupo
            // 
            this.btn_novo_grupo.Location = new System.Drawing.Point(1179, 100);
            this.btn_novo_grupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_novo_grupo.Name = "btn_novo_grupo";
            this.btn_novo_grupo.Size = new System.Drawing.Size(128, 54);
            this.btn_novo_grupo.TabIndex = 17;
            this.btn_novo_grupo.Text = "Novo Depto";
            this.btn_novo_grupo.UseVisualStyleBackColor = true;
            this.btn_novo_grupo.Click += new System.EventHandler(this.btn_novo_grupo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID Depto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 612);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome departamento";
            // 
            // btn_gravar_grupo
            // 
            this.btn_gravar_grupo.Location = new System.Drawing.Point(1179, 533);
            this.btn_gravar_grupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_gravar_grupo.Name = "btn_gravar_grupo";
            this.btn_gravar_grupo.Size = new System.Drawing.Size(128, 60);
            this.btn_gravar_grupo.TabIndex = 31;
            this.btn_gravar_grupo.Text = "Gravar";
            this.btn_gravar_grupo.UseVisualStyleBackColor = true;
            this.btn_gravar_grupo.Click += new System.EventHandler(this.btn_gravar_grupo_Click);
            // 
            // datagrid_grupos
            // 
            this.datagrid_grupos.AllowUserToOrderColumns = true;
            this.datagrid_grupos.AutoGenerateColumns = false;
            this.datagrid_grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_grupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgrupoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.situacaoativoDataGridViewTextBoxColumn});
            this.datagrid_grupos.DataSource = this.gruposBindingSource;
            this.datagrid_grupos.Location = new System.Drawing.Point(52, 100);
            this.datagrid_grupos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datagrid_grupos.Name = "datagrid_grupos";
            this.datagrid_grupos.Size = new System.Drawing.Size(1057, 494);
            this.datagrid_grupos.TabIndex = 32;
            // 
            // idgrupoDataGridViewTextBoxColumn
            // 
            this.idgrupoDataGridViewTextBoxColumn.DataPropertyName = "id_grupo";
            this.idgrupoDataGridViewTextBoxColumn.HeaderText = "ID GRUPO";
            this.idgrupoDataGridViewTextBoxColumn.Name = "idgrupoDataGridViewTextBoxColumn";
            this.idgrupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // situacaoativoDataGridViewTextBoxColumn
            // 
            this.situacaoativoDataGridViewTextBoxColumn.DataPropertyName = "situacao_ativo";
            this.situacaoativoDataGridViewTextBoxColumn.HeaderText = "Ativo";
            this.situacaoativoDataGridViewTextBoxColumn.Name = "situacaoativoDataGridViewTextBoxColumn";
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "grupos";
            this.gruposBindingSource.DataSource = this.tCC1DataSet1;
            // 
            // tCC1DataSet1
            // 
            this.tCC1DataSet1.DataSetName = "TCC1DataSet1";
            this.tCC1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(1195, 46);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 33;
            this.btn_refresh.Text = "button1";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // CADASTROGRUPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 688);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.datagrid_grupos);
            this.Controls.Add(this.btn_gravar_grupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voltar_grupo);
            this.Controls.Add(this.lbl_descricao_grupos);
            this.Controls.Add(this.combobox_situacao_depto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_nome_depto);
            this.Controls.Add(this.txtbox_id_depto);
            this.Controls.Add(this.btn_cancelar_grupo);
            this.Controls.Add(this.btn_excluir_grupo);
            this.Controls.Add(this.btn_editar_grupo);
            this.Controls.Add(this.btn_novo_grupo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CADASTROGRUPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTROGRUPO";
            this.Load += new System.EventHandler(this.CADASTROGRUPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_grupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCC1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar_grupo;
        private System.Windows.Forms.Label lbl_descricao_grupos;
        private System.Windows.Forms.ComboBox combobox_situacao_depto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_nome_depto;
        private System.Windows.Forms.TextBox txtbox_id_depto;
        private System.Windows.Forms.Button btn_cancelar_grupo;
        private System.Windows.Forms.Button btn_excluir_grupo;
        private System.Windows.Forms.Button btn_editar_grupo;
        private System.Windows.Forms.Button btn_novo_grupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_gravar_grupo;
        private System.Windows.Forms.DataGridView datagrid_grupos;
        private TCC1DataSet1 tCC1DataSet1;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private TCC1DataSet1TableAdapters.gruposTableAdapter gruposTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_refresh;
    }
}