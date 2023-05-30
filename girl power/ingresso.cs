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
    public partial class ingresso : Form
    {
        public ingresso()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ingresso_Load(object sender, EventArgs e)
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
                    boxsessao.Items.Add(reader.GetString(4));
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";





            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM SessãoFil";
            command.CommandType = CommandType.Text;
            command.Connection = connection;





            connection.Open();
            SqlDataReader reader = command.ExecuteReader();





            if (reader.HasRows)
            {
                while (reader.Read())
                {



                    string sessao = reader.GetString(1) + " " + reader.GetTimeSpan(2) + " " + reader.GetString(3);



                    boxsessao.Items.Add(sessao);
                }
            }
        }

        private void btnIngresso_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja confirmar?", "Aviso", MessageBoxButtons.YesNo);



            if (result == DialogResult.Yes)
            {
                if (filmeslista.SelectedIndex == -1)
                {
                    MessageBox.Show("Favor selecionar um filme");
                }
                else if (numinteira.Value > 0 || numeia.Value > 0)
                {
                    int valor = (int)numinteira.Value * 25 + (int)numeia.Value * 12;
                    MessageBox.Show("Venda gerada. \n Total da compra R$ " + valor.ToString());
                }
                else
                {
                    MessageBox.Show("Favor inserir ao menos um ingresso");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void boxsessao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
