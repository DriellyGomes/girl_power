namespace girl_power
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSessao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFilme = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuIngresso = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumOrchid;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Dubai Medium", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoToolStripMenuItem,
            this.MenuSessao,
            this.MenuCadastroFilme,
            this.MenuFuncionarios,
            this.MenuFilme,
            this.MenuIngresso,
            this.sairToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(130, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // acessoToolStripMenuItem
            // 
            this.acessoToolStripMenuItem.Font = new System.Drawing.Font("Dubai Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acessoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.acessoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            this.acessoToolStripMenuItem.Size = new System.Drawing.Size(124, 53);
            this.acessoToolStripMenuItem.Text = "Acesso";
            this.acessoToolStripMenuItem.Click += new System.EventHandler(this.acessoToolStripMenuItem_Click);
            // 
            // MenuFuncionarios
            // 
            this.MenuFuncionarios.Font = new System.Drawing.Font("Dubai Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFuncionarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuFuncionarios.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.MenuFuncionarios.Name = "MenuFuncionarios";
            this.MenuFuncionarios.Size = new System.Drawing.Size(199, 53);
            this.MenuFuncionarios.Text = "Funcionários";
            this.MenuFuncionarios.Visible = false;
            this.MenuFuncionarios.Click += new System.EventHandler(this.cadastroDeToolStripMenuItem_Click);
            // 
            // MenuCadastroFilme
            // 
            this.MenuCadastroFilme.Font = new System.Drawing.Font("Dubai Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCadastroFilme.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuCadastroFilme.Name = "MenuCadastroFilme";
            this.MenuCadastroFilme.Size = new System.Drawing.Size(243, 53);
            this.MenuCadastroFilme.Text = "Cadastro Filmes";
            this.MenuCadastroFilme.Visible = false;
            this.MenuCadastroFilme.Click += new System.EventHandler(this.filmesToolStripMenuItem_Click);
            // 
            // MenuSessao
            // 
            this.MenuSessao.Font = new System.Drawing.Font("Dubai Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSessao.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuSessao.Name = "MenuSessao";
            this.MenuSessao.Size = new System.Drawing.Size(248, 53);
            this.MenuSessao.Text = "Cadastro Sessão";
            this.MenuSessao.Visible = false;
            this.MenuSessao.Click += new System.EventHandler(this.cadastroSessãoToolStripMenuItem_Click);
            // 
            // MenuFilme
            // 
            this.MenuFilme.Font = new System.Drawing.Font("Dubai Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuFilme.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuFilme.Name = "MenuFilme";
            this.MenuFilme.Size = new System.Drawing.Size(118, 53);
            this.MenuFilme.Text = "Filmes";
            this.MenuFilme.Visible = false;
            this.MenuFilme.Click += new System.EventHandler(this.MenuFilme_Click);
            // 
            // MenuIngresso
            // 
            this.MenuIngresso.Font = new System.Drawing.Font("Dubai Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuIngresso.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MenuIngresso.Name = "MenuIngresso";
            this.MenuIngresso.Size = new System.Drawing.Size(165, 53);
            this.MenuIngresso.Text = "Ingressos ";
            this.MenuIngresso.Visible = false;
            this.MenuIngresso.Click += new System.EventHandler(this.ingressosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Dubai Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(86, 53);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::girl_power.Properties.Resources.Captura_de_tela_2023_05_16_082544_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuFuncionarios;
        public System.Windows.Forms.ToolStripMenuItem MenuCadastroFilme;
        public System.Windows.Forms.ToolStripMenuItem MenuIngresso;
        public System.Windows.Forms.ToolStripMenuItem MenuFilme;
        public System.Windows.Forms.ToolStripMenuItem MenuSessao;
    }
}

