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
    public partial class cadastro_funcionario : Form
    {
        public cadastro_funcionario()
        {
            InitializeComponent();
        }

        private void cadastro_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void btnfuncionario_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "girlpower";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("RG", txtRG.Text);
            cmd.Parameters.AddWithValue("CPF", txtCPF.Text);
            cmd.Parameters.AddWithValue("Endereço", txtEnd.Text);
            cmd.Parameters.AddWithValue("Senha", txtSenha.Text);
            cmd.Parameters.AddWithValue("Cargo", txtCargo.Text);
            cmd.Parameters.AddWithValue("DadosBancarios", txtConta.Text);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();





            MessageBox.Show("Funcionário cadastrado com sucesso.");


        }
    }
}
