namespace TCC
{
    partial class RELATORIOCLIENTES
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
            this.lista_produtos = new System.Windows.Forms.ListView();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_voltarproduto = new System.Windows.Forms.Button();
            this.btn_cancelarproduto = new System.Windows.Forms.Button();
            this.btn_excluirproduto = new System.Windows.Forms.Button();
            this.btn_editarproduto = new System.Windows.Forms.Button();
            this.btn_novocliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 50);
            this.label5.TabIndex = 17;
            this.label5.Text = "Relatório de Clientes";
            // 
            // lista_produtos
            // 
            this.lista_produtos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lista_produtos.Location = new System.Drawing.Point(59, 112);
            this.lista_produtos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lista_produtos.Name = "lista_produtos";
            this.lista_produtos.Size = new System.Drawing.Size(1028, 368);
            this.lista_produtos.TabIndex = 18;
            this.lista_produtos.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gravar.Location = new System.Drawing.Point(777, 518);
            this.btn_Gravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(128, 47);
            this.btn_Gravar.TabIndex = 35;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            // 
            // btn_voltarproduto
            // 
            this.btn_voltarproduto.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarproduto.Location = new System.Drawing.Point(960, 517);
            this.btn_voltarproduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_voltarproduto.Name = "btn_voltarproduto";
            this.btn_voltarproduto.Size = new System.Drawing.Size(128, 48);
            this.btn_voltarproduto.TabIndex = 34;
            this.btn_voltarproduto.Text = "Voltar";
            this.btn_voltarproduto.UseVisualStyleBackColor = true;
            this.btn_voltarproduto.Click += new System.EventHandler(this.btn_voltarproduto_Click);
            // 
            // btn_cancelarproduto
            // 
            this.btn_cancelarproduto.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarproduto.Location = new System.Drawing.Point(595, 517);
            this.btn_cancelarproduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelarproduto.Name = "btn_cancelarproduto";
            this.btn_cancelarproduto.Size = new System.Drawing.Size(128, 47);
            this.btn_cancelarproduto.TabIndex = 33;
            this.btn_cancelarproduto.Text = "Cancelar";
            this.btn_cancelarproduto.UseVisualStyleBackColor = true;
            // 
            // btn_excluirproduto
            // 
            this.btn_excluirproduto.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluirproduto.Location = new System.Drawing.Point(415, 517);
            this.btn_excluirproduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excluirproduto.Name = "btn_excluirproduto";
            this.btn_excluirproduto.Size = new System.Drawing.Size(128, 47);
            this.btn_excluirproduto.TabIndex = 32;
            this.btn_excluirproduto.Text = "Excluir";
            this.btn_excluirproduto.UseVisualStyleBackColor = true;
            // 
            // btn_editarproduto
            // 
            this.btn_editarproduto.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarproduto.Location = new System.Drawing.Point(229, 517);
            this.btn_editarproduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_editarproduto.Name = "btn_editarproduto";
            this.btn_editarproduto.Size = new System.Drawing.Size(128, 47);
            this.btn_editarproduto.TabIndex = 31;
            this.btn_editarproduto.Text = "Editar";
            this.btn_editarproduto.UseVisualStyleBackColor = true;
            // 
            // btn_novocliente
            // 
            this.btn_novocliente.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novocliente.Location = new System.Drawing.Point(59, 518);
            this.btn_novocliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_novocliente.Name = "btn_novocliente";
            this.btn_novocliente.Size = new System.Drawing.Size(128, 47);
            this.btn_novocliente.TabIndex = 36;
            this.btn_novocliente.Text = "Novo Cliente";
            this.btn_novocliente.UseVisualStyleBackColor = true;
            this.btn_novocliente.Click += new System.EventHandler(this.btn_novocliente_Click);
            // 
            // RELATORIOCLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 629);
            this.Controls.Add(this.btn_novocliente);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.btn_voltarproduto);
            this.Controls.Add(this.btn_cancelarproduto);
            this.Controls.Add(this.btn_excluirproduto);
            this.Controls.Add(this.btn_editarproduto);
            this.Controls.Add(this.lista_produtos);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RELATORIOCLIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATORIOCLIENTES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lista_produtos;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_voltarproduto;
        private System.Windows.Forms.Button btn_cancelarproduto;
        private System.Windows.Forms.Button btn_excluirproduto;
        private System.Windows.Forms.Button btn_editarproduto;
        private System.Windows.Forms.Button btn_novocliente;
    }
}