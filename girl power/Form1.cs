using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace girl_power
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastroDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro_funcionario F = new cadastro_funcionario();
            F.MdiParent = this;
            F.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = SystemColors.ControlLight;
        }

        private void acessoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acesso A = new Acesso();
            A.MdiParent = this;
            A.Show();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 S = new Form2();
            S.MdiParent = this;
            S.Show();
        }

        private void listaDeFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void listaFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarFilmes L = new ListarFilmes();
            L.MdiParent = this;
            L.Show();
        }

        private void listarFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarFilmes L = new ListarFilmes();
            L.MdiParent = this;
            L.Show();
        }

        private void ingressosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ingresso I = new ingresso();
            I.MdiParent = this;
            I.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuFilme_Click(object sender, EventArgs e)
        {
            ListarFilmes L = new ListarFilmes();
            L.MdiParent = this;
            L.Show();
        }

        private void cadastroSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sessao S = new Sessao();
            S.MdiParent = this;
            S.Show();
        }
    }
}
