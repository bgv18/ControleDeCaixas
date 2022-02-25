using ControleDeCaixas2.Class;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleDeCaixas2.Forms
{
    public partial class removeBox : Form
    {
        private string sql = string.Empty;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
     
        public removeBox()
        {
            InitializeComponent();
            btn_salvar.Enabled = false;
            tb_id.Enabled = false;
            sql = "select * from caixa";
            try
            {
                cmd.Connection = con.conectar();
                using (SqlDataAdapter da = new SqlDataAdapter(sql, cmd.Connection))
                {
                    using (DataTable dt = new DataTable())
                    {
                        da.Fill(dt);
                        dataGridView_remove.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_remove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_id.Enabled = true;
            btn_salvar.Enabled = true;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            sql = @"delete from caixa where id = @id";
           
            SqlCommand cmd = new SqlCommand(sql, con.conectar());
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = tb_id.Text;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Caixa deletada com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
