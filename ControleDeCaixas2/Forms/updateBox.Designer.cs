namespace ControleDeCaixas2
{
    partial class updateBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_update = new System.Windows.Forms.DataGridView();
            this.label_id = new System.Windows.Forms.Label();
            this.label_altura = new System.Windows.Forms.Label();
            this.label_largura = new System.Windows.Forms.Label();
            this.label_profundidade = new System.Windows.Forms.Label();
            this.label_quantidade = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_altura = new System.Windows.Forms.TextBox();
            this.tb_largura = new System.Windows.Forms.TextBox();
            this.tb_profundidade = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_update)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_update
            // 
            this.dataGridView_update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_update.Location = new System.Drawing.Point(12, 26);
            this.dataGridView_update.Name = "dataGridView_update";
            this.dataGridView_update.Size = new System.Drawing.Size(722, 202);
            this.dataGridView_update.TabIndex = 0;
            this.dataGridView_update.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(107, 267);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 13);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID";
            // 
            // label_altura
            // 
            this.label_altura.AutoSize = true;
            this.label_altura.Location = new System.Drawing.Point(107, 295);
            this.label_altura.Name = "label_altura";
            this.label_altura.Size = new System.Drawing.Size(34, 13);
            this.label_altura.TabIndex = 2;
            this.label_altura.Text = "Altura";
            // 
            // label_largura
            // 
            this.label_largura.AutoSize = true;
            this.label_largura.Location = new System.Drawing.Point(107, 327);
            this.label_largura.Name = "label_largura";
            this.label_largura.Size = new System.Drawing.Size(43, 13);
            this.label_largura.TabIndex = 3;
            this.label_largura.Text = "Largura";
            // 
            // label_profundidade
            // 
            this.label_profundidade.AutoSize = true;
            this.label_profundidade.Location = new System.Drawing.Point(105, 358);
            this.label_profundidade.Name = "label_profundidade";
            this.label_profundidade.Size = new System.Drawing.Size(70, 13);
            this.label_profundidade.TabIndex = 4;
            this.label_profundidade.Text = "Profundidade";
            // 
            // label_quantidade
            // 
            this.label_quantidade.AutoSize = true;
            this.label_quantidade.Location = new System.Drawing.Point(107, 386);
            this.label_quantidade.Name = "label_quantidade";
            this.label_quantidade.Size = new System.Drawing.Size(62, 13);
            this.label_quantidade.TabIndex = 5;
            this.label_quantidade.Text = "Quantidade";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(181, 264);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(61, 20);
            this.tb_id.TabIndex = 6;
            // 
            // tb_altura
            // 
            this.tb_altura.Location = new System.Drawing.Point(181, 292);
            this.tb_altura.Name = "tb_altura";
            this.tb_altura.Size = new System.Drawing.Size(61, 20);
            this.tb_altura.TabIndex = 7;
            // 
            // tb_largura
            // 
            this.tb_largura.Location = new System.Drawing.Point(181, 324);
            this.tb_largura.Name = "tb_largura";
            this.tb_largura.Size = new System.Drawing.Size(61, 20);
            this.tb_largura.TabIndex = 8;
            // 
            // tb_profundidade
            // 
            this.tb_profundidade.Location = new System.Drawing.Point(181, 355);
            this.tb_profundidade.Name = "tb_profundidade";
            this.tb_profundidade.Size = new System.Drawing.Size(61, 20);
            this.tb_profundidade.TabIndex = 9;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(181, 381);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(61, 20);
            this.tb_quantidade.TabIndex = 10;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(382, 304);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(111, 58);
            this.btn_novo.TabIndex = 11;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(580, 304);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(103, 58);
            this.btn_salvar.TabIndex = 12;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // updateBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.tb_profundidade);
            this.Controls.Add(this.tb_largura);
            this.Controls.Add(this.tb_altura);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label_quantidade);
            this.Controls.Add(this.label_profundidade);
            this.Controls.Add(this.label_largura);
            this.Controls.Add(this.label_altura);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.dataGridView_update);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "updateBox";
            this.Text = "updateBox";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_update)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_update;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_altura;
        private System.Windows.Forms.Label label_largura;
        private System.Windows.Forms.Label label_profundidade;
        private System.Windows.Forms.Label label_quantidade;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_altura;
        private System.Windows.Forms.TextBox tb_largura;
        private System.Windows.Forms.TextBox tb_profundidade;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}