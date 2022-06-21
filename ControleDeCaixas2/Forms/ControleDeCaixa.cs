using ControleDeCaixas2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCaixas2
{
    public partial class ControleDeCaixa : Form
    {
        public ControleDeCaixa()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBox add = new addBox();
            add.ShowDialog();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
