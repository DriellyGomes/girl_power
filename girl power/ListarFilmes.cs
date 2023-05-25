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
    public partial class ListarFilmes : Form
    {
        public ListarFilmes()
        {
            InitializeComponent();
        }

        int idFilme;

        private void Buscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CadastroFilmeG WHERE Titulo LIKE '%" + txtID.Text + "%' ORDER BY idFilme DESC ";
            listarFilme(sql);
        }
        private void listarFilme(string sql)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
         
            DataSet ds = new DataSet();

            adapter.Fill(ds);


            gridfilme.DataSource = ds.Tables[0];
        }

        private void listarTodosClientes()
        {
            string sql = "SELECT * FROM CadastroFilmeG ORDER BY idFilme DESC ";
            listarFilme(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo);



            if (result == DialogResult.Yes)
            {

                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Server=turmassenacsantos.mssql.somee.com;Database=turmassenacsantos;User Id=senacclovis_SQLLogin_1;Password=n1642mlxmm;";


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "PiFilme47";
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("idFilme", idFilme);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();



                MessageBox.Show("Filme excluído com sucesso.");



                listarTodosClientes();
            }
        }

        private void gridfilme_CellClick(object sender, DataGridViewCellEventArgs e)
        
        {
            btnExcluir.Enabled = true;
            idFilme = Convert.ToInt32(gridfilme.Rows[e.RowIndex].Cells[0].Value);
        }

        private void ListarFilmes_Load(object sender, EventArgs e)
        {

        }
    }
}
