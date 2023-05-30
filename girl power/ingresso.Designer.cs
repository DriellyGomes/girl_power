namespace girl_power
{
    partial class ingresso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numinteira = new System.Windows.Forms.NumericUpDown();
            this.numeia = new System.Windows.Forms.NumericUpDown();
            this.btnIngresso = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmeslista = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxsessao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numinteira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compre seu ingresso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inteira:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Selecione o filme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Meia:";
            // 
            // numinteira
            // 
            this.numinteira.Location = new System.Drawing.Point(100, 186);
            this.numinteira.Name = "numinteira";
            this.numinteira.Size = new System.Drawing.Size(114, 20);
            this.numinteira.TabIndex = 5;
            // 
            // numeia
            // 
            this.numeia.Location = new System.Drawing.Point(331, 186);
            this.numeia.Name = "numeia";
            this.numeia.Size = new System.Drawing.Size(114, 20);
            this.numeia.TabIndex = 4;
            this.numeia.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnIngresso
            // 
            this.btnIngresso.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIngresso.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresso.Location = new System.Drawing.Point(519, 186);
            this.btnIngresso.Name = "btnIngresso";
            this.btnIngresso.Size = new System.Drawing.Size(101, 31);
            this.btnIngresso.TabIndex = 10;
            this.btnIngresso.Text = "Comprar";
            this.btnIngresso.UseVisualStyleBackColor = false;
            this.btnIngresso.Click += new System.EventHandler(this.btnIngresso_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 230);
            this.dataGridView1.TabIndex = 12;
            // 
            // filmeslista
            // 
            this.filmeslista.FormattingEnabled = true;
            this.filmeslista.Location = new System.Drawing.Point(203, 92);
            this.filmeslista.Name = "filmeslista";
            this.filmeslista.Size = new System.Drawing.Size(304, 21);
            this.filmeslista.TabIndex = 9;
            this.filmeslista.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sessão:";
            // 
            // boxsessao
            // 
            this.boxsessao.FormattingEnabled = true;
            this.boxsessao.Location = new System.Drawing.Point(100, 140);
            this.boxsessao.Name = "boxsessao";
            this.boxsessao.Size = new System.Drawing.Size(121, 21);
            this.boxsessao.TabIndex = 14;
            this.boxsessao.SelectedIndexChanged += new System.EventHandler(this.boxsessao_SelectedIndexChanged);
            // 
            // ingresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::girl_power.Properties.Resources.Captura_de_tela_2023_05_16_082544_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(737, 369);
            this.Controls.Add(this.boxsessao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngresso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numeia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numinteira);
            this.Controls.Add(this.filmeslista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "ingresso";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ingresso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numinteira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numinteira;
        private System.Windows.Forms.NumericUpDown numeia;
        private System.Windows.Forms.Button btnIngresso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox filmeslista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxsessao;
    }
}