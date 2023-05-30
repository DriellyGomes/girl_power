using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace girl_power
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        private void Acesso_Load(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Acesso";
            cmd.CommandType = CommandType.StoredProcedure;



            cmd.Parameters.AddWithValue("idFuncionariosG", txtID.Text);
            cmd.Parameters.AddWithValue("Senha", txtSenha.Text);
            



            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();



            if (reader.HasRows)
            {
                reader.Read();
                string cargo = reader.GetString(3);



                Form1 f = (Form1)MdiParent; 



                MessageBox.Show("Bem vindo!");



                if (cargo == "Gerente")
                {
                    
                    f.MenuCadastroFilme.Visible = true;
                    f.MenuIngresso.Visible = true;
                    f.MenuFuncionarios.Visible = true;
                    f.MenuFilme.Visible = true;
                    f.MenuSessao.Visible = true;
                }
                else if (cargo == "Atendente")
                {
                    
                    f.MenuFilme.Visible = false;
                    f.MenuIngresso.Visible = true;
                    f.MenuFuncionarios.Visible = false;
                    f.MenuCadastroFilme.Visible = false;
                    f.MenuSessao.Visible = false;
                }



                connection.Close();
                this.Close();




            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreto.");
                connection.Close();
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
