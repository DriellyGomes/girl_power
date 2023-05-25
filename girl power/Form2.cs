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
using static System.Net.Mime.MediaTypeNames;

namespace girl_power
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "PiFilmesG";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("Titulo", txtFilme.Text);
            cmd.Parameters.AddWithValue("Duraçao", txtDuracao.Text);
            cmd.Parameters.AddWithValue("AnodeLancamento", txtAno.Text);
            cmd.Parameters.AddWithValue("Sinopse", txtSinopse.Text);
            cmd.Parameters.AddWithValue("Sessão", txtsessao.Text);
            


            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();





            MessageBox.Show("Filme cadastrado com sucesso.");

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           BuscarFilme();
        }
        private void BuscarFilme()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "AcessoFilmes";
            cmd.CommandType = CommandType.StoredProcedure;



            cmd.Parameters.AddWithValue("idFilme", txtID.Text);



            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();



            if (reader.HasRows)
            {
                reader.Read();



               
                txtFilme.Text = reader.GetString(1);
                txtDuracao.Text = reader.GetString(3);
                txtAno.Text = reader.GetString(4);
                txtSinopse.Text = reader.GetString(2);


            }
            else
            {
                MessageBox.Show("Filme não encontrado.");
            }



            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente atualizar?", "Aviso", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
              
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection; 
                cmd.CommandText = "PiAtualizarFilme";
                cmd.CommandType = CommandType.StoredProcedure; 

                
                cmd.Parameters.AddWithValue("Titulo", txtFilme.Text);
                cmd.Parameters.AddWithValue("Sinopse", txtSinopse.Text);
                cmd.Parameters.AddWithValue("Duraçao", txtDuracao.Text);
                cmd.Parameters.AddWithValue("AnodeLancamento", txtAno.Text);
                cmd.Parameters.AddWithValue("idFilme", txtID.Text);
                cmd.Parameters.AddWithValue("Sessão", txtsessao.Text);

                connection.Open();
                cmd.ExecuteNonQuery(); 
                connection.Close();

                MessageBox.Show("Filme atualizado com sucesso.");

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
        }
    }
}
