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

namespace ControleDeCaixas2
{
    public partial class addBox : Form
    {
        public addBox()
        {
            InitializeComponent();
            tb_id.Enabled = false;
            tb_altura.Enabled = false;
            tb_largura.Enabled = false;
            tb_profundidade.Enabled = false;
            tb_volume.Enabled = false;
            tb_quantidade.Enabled = false;

        }

        SqlConnection conexao = null;
        private string con = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Caixa;Data Source=GUERRA\SQLEXPRESS";
        private string sql = string.Empty;

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            sql = "insert into caixa (id,altura,largura,profundidade,volume,quantidade) VALUES (@id,@altura,@largura,@profundidade,@volume,@quantidade)";
            conexao = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(sql,conexao);
            
            cmd.Parameters.Add("@id",SqlDbType.Int).Value = tb_id.Text;
            cmd.Parameters.Add("@altura", SqlDbType.Float).Value = tb_altura.Text;
            cmd.Parameters.Add("@largura", SqlDbType.Float).Value = tb_largura.Text;
            cmd.Parameters.Add("@profundidade", SqlDbType.Float).Value = tb_profundidade.Text;
            cmd.Parameters.Add("@volume", SqlDbType.Float).Value = tb_volume.Text;
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = tb_quantidade.Text;

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Caixa cadastrada com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                conexao.Close();
            }

            tb_id.Clear();
            tb_altura.Clear();
            tb_largura.Clear();
            tb_profundidade.Clear();
            tb_volume.Clear();
            tb_quantidade.Clear();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            tb_altura.Clear();
            tb_largura.Clear();
            tb_profundidade.Clear();
            tb_volume.Clear();
            tb_quantidade.Clear();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            tb_id.Enabled = true;
            tb_altura.Enabled = true;
            tb_largura.Enabled = true;
            tb_profundidade.Enabled = true;
            tb_volume.Enabled = true;
            tb_quantidade.Enabled = true;
        }
    }
}
