namespace Salao
{
    partial class AlterarInformacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarInformacoes));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterarEmail = new System.Windows.Forms.Button();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.btnAlterarTelefone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(8, 8);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(55, 18);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlterarEmail
            // 
            this.btnAlterarEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarEmail.Image")));
            this.btnAlterarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarEmail.Location = new System.Drawing.Point(131, 58);
            this.btnAlterarEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterarEmail.Name = "btnAlterarEmail";
            this.btnAlterarEmail.Size = new System.Drawing.Size(331, 50);
            this.btnAlterarEmail.TabIndex = 1;
            this.btnAlterarEmail.Text = "Clique aqui para mudar o seu E-mail";
            this.btnAlterarEmail.UseVisualStyleBackColor = true;
            this.btnAlterarEmail.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarSenha.Image")));
            this.btnAlterarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarSenha.Location = new System.Drawing.Point(131, 112);
            this.btnAlterarSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(331, 49);
            this.btnAlterarSenha.TabIndex = 2;
            this.btnAlterarSenha.Text = "Clique aqui para mudar a sua senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // btnAlterarTelefone
            // 
            this.btnAlterarTelefone.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarTelefone.Image")));
            this.btnAlterarTelefone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarTelefone.Location = new System.Drawing.Point(131, 165);
            this.btnAlterarTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlterarTelefone.Name = "btnAlterarTelefone";
            this.btnAlterarTelefone.Size = new System.Drawing.Size(331, 44);
            this.btnAlterarTelefone.TabIndex = 3;
            this.btnAlterarTelefone.Text = "   Clique aqui para mudar o seu telefone";
            this.btnAlterarTelefone.UseVisualStyleBackColor = true;
            this.btnAlterarTelefone.Click += new System.EventHandler(this.btnAlterarTelefone_Click);
            // 
            // AlterarInformacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnAlterarTelefone);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.btnAlterarEmail);
            this.Controls.Add(this.btnVoltar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AlterarInformacoes";
            this.Text = "AlterarInformacoes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterarEmail;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.Button btnAlterarTelefone;
    }
}