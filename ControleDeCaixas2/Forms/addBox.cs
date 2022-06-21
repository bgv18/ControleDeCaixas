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
using Dapper;

namespace ControleDeCaixas2
{
    public partial class addBox : Form
    {
        List<Box> _boxCadastradas;
        public addBox()
        {
            InitializeComponent();
            tb_id.Enabled = false;
            tb_altura.Enabled = false;
            tb_largura.Enabled = false;
            tb_profundidade.Enabled = false;
            tb_volume.Enabled = false;
            tb_quantidade.Enabled = false;

            SqlCommand cmd = new SqlCommand();

        }

        public void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btn_adicionar_Click(object sender, EventArgs e)
        {
            var conexao = new SqlConnection("data source=DSVRESERVA; initial catalog=ControleDeCaixa;  user id=sa; password=cdssql;multipleactiveresultsets=true");
            _boxCadastradas = conexao.Query<Box>("select * from caixa").ToList();
            dgBox.AutoGenerateColumns = true;
            bsCaixa.DataSource = _boxCadastradas;
            dgBox.DataSource = _boxCadastradas;


            /*sql = "insert into caixa (id,altura,largura,profundidade,volume,quantidade) VALUES (@id,@altura,@largura,@profundidade,@volume,@quantidade)";
            SqlCommand cmd = new SqlCommand(sql,con.conectar());
            
            cmd.Parameters.Add("@id",SqlDbType.Int).Value = tb_id.Text;
            cmd.Parameters.Add("@altura", SqlDbType.Float).Value = tb_altura.Text;
            cmd.Parameters.Add("@largura", SqlDbType.Float).Value = tb_largura.Text;
            cmd.Parameters.Add("@profundidade", SqlDbType.Float).Value = tb_profundidade.Text;
            cmd.Parameters.Add("@volume", SqlDbType.Float).Value = tb_volume.Text;
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = tb_quantidade.Text;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Caixa cadastrada com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tb_id.Clear();
            tb_altura.Clear();
            tb_largura.Clear();
            tb_profundidade.Clear();
            tb_volume.Clear();
            tb_quantidade.Clear();*/
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
            tb_id.Enabled = false;
            tb_id.BackColor = Color.Gray;
            tb_altura.Focus();
            tb_altura.Enabled = true;
            tb_largura.Enabled = true;
            tb_profundidade.Enabled = true;
            tb_volume.Enabled = true;
            tb_quantidade.Enabled = true;
        }

        private void addBox_Load(object sender, EventArgs e)
        {
            dgBox.DataSource = null;
            dgBox.DataSource = _boxCadastradas;
        }

        private void bsCaixa_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

