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

namespace girl_power
{
    public partial class Sessao : Form
    {
        public Sessao()
        {
            InitializeComponent();
        }
        int idFilme;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sessao_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";



            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM CADASTROFILMEG";
            command.CommandType = CommandType.Text;
            command.Connection = connection;



            connection.Open();
            SqlDataReader reader = command.ExecuteReader();



            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    filmeslista.Items.Add(reader.GetString(1));

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "PiSessaoG";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Titulo", filmeslista.Text);
            cmd.Parameters.AddWithValue("Horario", txthorario.Text);
            cmd.Parameters.AddWithValue("Sala", txtsala.Text);
            cmd.Parameters.AddWithValue("DiaDaSemana", txtdia.Text);
           


            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();





            MessageBox.Show("Sessão cadastrada com sucesso.");

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        
        }   
    }
}
