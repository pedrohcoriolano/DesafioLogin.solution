namespace DesafioLogin.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.bntLogar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBackground.BackgroundImage")));
            this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackground.Controls.Add(this.textBoxNome);
            this.panelBackground.Controls.Add(this.textBoxSenha);
            this.panelBackground.Controls.Add(this.bntLogar);
            this.panelBackground.Controls.Add(this.label1);
            this.panelBackground.Location = new System.Drawing.Point(-29, -11);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(676, 471);
            this.panelBackground.TabIndex = 0;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(153, 215);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(129, 20);
            this.textBoxNome.TabIndex = 4;
            this.textBoxNome.Text = "Usuario";
            this.textBoxNome.Enter += new System.EventHandler(this.textBoxNome_enter);
            this.textBoxNome.Leave += new System.EventHandler(this.textBoxNome_leave);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(153, 274);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(129, 20);
            this.textBoxSenha.TabIndex = 3;
            this.textBoxSenha.Text = "Senha";
            this.textBoxSenha.Enter += new System.EventHandler(this.textBoxSenha_enter);
            this.textBoxSenha.Leave += new System.EventHandler(this.textBoxSenha_leave);
            // 
            // bntLogar
            // 
            this.bntLogar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntLogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLogar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntLogar.Location = new System.Drawing.Point(182, 388);
            this.bntLogar.Name = "bntLogar";
            this.bntLogar.Size = new System.Drawing.Size(75, 23);
            this.bntLogar.TabIndex = 1;
            this.bntLogar.Text = "Logar";
            this.bntLogar.UseVisualStyleBackColor = true;
            this.bntLogar.Click += new System.EventHandler(this.bntLogar_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button bntLogar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSenha;
    }
}

