namespace TCC
{
    partial class Telalogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telalogin));
            this.txtbox_usuario = new System.Windows.Forms.TextBox();
            this.txtbox_senha = new System.Windows.Forms.TextBox();
            this.btn_logar = new System.Windows.Forms.Button();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_versao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_usuario
            // 
            resources.ApplyResources(this.txtbox_usuario, "txtbox_usuario");
            this.txtbox_usuario.Name = "txtbox_usuario";
            // 
            // txtbox_senha
            // 
            resources.ApplyResources(this.txtbox_senha, "txtbox_senha");
            this.txtbox_senha.Name = "txtbox_senha";
            // 
            // btn_logar
            // 
            resources.ApplyResources(this.btn_logar, "btn_logar");
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.UseVisualStyleBackColor = true;
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click);
            // 
            // lbl_usuario
            // 
            resources.ApplyResources(this.lbl_usuario, "lbl_usuario");
            this.lbl_usuario.Name = "lbl_usuario";
            // 
            // lbl_senha
            // 
            resources.ApplyResources(this.lbl_senha, "lbl_senha");
            this.lbl_senha.Name = "lbl_senha";
            // 
            // btn_sair
            // 
            resources.ApplyResources(this.btn_sair, "btn_sair");
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCC.Properties.Resources.borda_1_5_milimetros;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lbl_versao
            // 
            resources.ApplyResources(this.lbl_versao, "lbl_versao");
            this.lbl_versao.Name = "lbl_versao";
            // 
            // Telalogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.lbl_versao);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.txtbox_senha);
            this.Controls.Add(this.txtbox_usuario);
            this.Name = "Telalogin";
            this.Load += new System.EventHandler(this.Telalogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_usuario;
        private System.Windows.Forms.TextBox txtbox_senha;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_versao;
    }
}

