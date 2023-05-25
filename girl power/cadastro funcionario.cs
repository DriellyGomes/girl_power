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
            cmd.CommandText = "GirlPower";
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("RG", txtRG.Text);
            cmd.Parameters.AddWithValue("CPF", txtCPF.Text);
            cmd.Parameters.AddWithValue("Senha", txtSenha.Text);
            cmd.Parameters.AddWithValue("Cargo", txtCargo.Text);


            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();





            MessageBox.Show("Funcionário cadastrado com sucesso.");

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo);



            if (result == DialogResult.Yes)
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "PiExcluir";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("idFuncionariosG", txtID.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();



                MessageBox.Show("Funcionário excluído com sucesso.");

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
        }

            private void button1_btnAtualizar(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Deseja realmente atualizar?", "Aviso", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Funcionarios46";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Cargo", txtCargo.Text);
                cmd.Parameters.AddWithValue("Senha", txtSenha.Text);
                cmd.Parameters.AddWithValue("IdFuncionariosG", txtID.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Funcionario atualizado com sucesso.");

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM FuncionariosG WHERE Nome LIKE '%" + txtID.Text + "%' ORDER BY idFuncionariosG DESC ";
            BuscarFuncionarios(sql);
        }
        private void BuscarFuncionarios(string sql)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "BuscarFuncionariosG";
            cmd.CommandType = CommandType.StoredProcedure;



            cmd.Parameters.AddWithValue("idFuncionariosG", txtID.Text);



            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();



            if (reader.HasRows)
            {
                reader.Read();




                txtNome.Text = reader.GetString(4);
                txtRG.Text = reader.GetString(1);
                txtCPF.Text = reader.GetInt64(2).ToString();
                txtCargo.Text = reader.GetString(3);
                txtSenha.Text = reader.GetInt32(5).ToString();



            }
            else
            {
                MessageBox.Show("Funcionário não encontrado.");
            }



            connection.Close();
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {

        }
    }


    
}