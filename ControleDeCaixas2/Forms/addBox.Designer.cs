namespace ControleDeCaixas2
{
    partial class addBox
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
            this.components = new System.ComponentModel.Container();
            this.label_BoxId = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.MaskedTextBox();
            this.label_altura = new System.Windows.Forms.Label();
            this.label_largura = new System.Windows.Forms.Label();
            this.label_profundidade = new System.Windows.Forms.Label();
            this.label_quantidade = new System.Windows.Forms.Label();
            this.tb_altura = new System.Windows.Forms.TextBox();
            this.tb_largura = new System.Windows.Forms.TextBox();
            this.tb_profundidade = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgBox = new System.Windows.Forms.DataGridView();
            this.bsCaixa = new System.Windows.Forms.BindingSource(this.components);
            this.label_volume = new System.Windows.Forms.Label();
            this.tb_volume = new System.Windows.Forms.TextBox();
            this.caixaDB = new ControleDeCaixas2.CaixaDB();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixaDB)).BeginInit();
            this.SuspendLayout();
            // 
            // label_BoxId
            // 
            this.label_BoxId.AutoSize = true;
            this.label_BoxId.Location = new System.Drawing.Point(57, 44);
            this.label_BoxId.Name = "label_BoxId";
            this.label_BoxId.Size = new System.Drawing.Size(18, 13);
            this.label_BoxId.TabIndex = 0;
            this.label_BoxId.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(81, 38);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(57, 20);
            this.tb_id.TabIndex = 2;
            // 
            // label_altura
            // 
            this.label_altura.AutoSize = true;
            this.label_altura.Location = new System.Drawing.Point(41, 69);
            this.label_altura.Name = "label_altura";
            this.label_altura.Size = new System.Drawing.Size(34, 13);
            this.label_altura.TabIndex = 3;
            this.label_altura.Text = "Altura";
            // 
            // label_largura
            // 
            this.label_largura.AutoSize = true;
            this.label_largura.Location = new System.Drawing.Point(32, 97);
            this.label_largura.Name = "label_largura";
            this.label_largura.Size = new System.Drawing.Size(43, 13);
            this.label_largura.TabIndex = 4;
            this.label_largura.Text = "Largura";
            // 
            // label_profundidade
            // 
            this.label_profundidade.AutoSize = true;
            this.label_profundidade.Location = new System.Drawing.Point(5, 125);
            this.label_profundidade.Name = "label_profundidade";
            this.label_profundidade.Size = new System.Drawing.Size(70, 13);
            this.label_profundidade.TabIndex = 5;
            this.label_profundidade.Text = "Profundidade";
            // 
            // label_quantidade
            // 
            this.label_quantidade.AutoSize = true;
            this.label_quantidade.Location = new System.Drawing.Point(13, 182);
            this.label_quantidade.Name = "label_quantidade";
            this.label_quantidade.Size = new System.Drawing.Size(62, 13);
            this.label_quantidade.TabIndex = 7;
            this.label_quantidade.Text = "Quantidade";
            // 
            // tb_altura
            // 
            this.tb_altura.Location = new System.Drawing.Point(81, 66);
            this.tb_altura.Name = "tb_altura";
            this.tb_altura.Size = new System.Drawing.Size(57, 20);
            this.tb_altura.TabIndex = 8;
            // 
            // tb_largura
            // 
            this.tb_largura.Location = new System.Drawing.Point(81, 94);
            this.tb_largura.Name = "tb_largura";
            this.tb_largura.Size = new System.Drawing.Size(57, 20);
            this.tb_largura.TabIndex = 9;
            // 
            // tb_profundidade
            // 
            this.tb_profundidade.Location = new System.Drawing.Point(81, 122);
            this.tb_profundidade.Name = "tb_profundidade";
            this.tb_profundidade.Size = new System.Drawing.Size(56, 20);
            this.tb_profundidade.TabIndex = 10;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(81, 178);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(56, 20);
            this.tb_quantidade.TabIndex = 12;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(692, 72);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(97, 53);
            this.btn_adicionar.TabIndex = 13;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(692, 124);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(97, 51);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(692, 27);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(97, 46);
            this.btn_novo.TabIndex = 15;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dgBox
            // 
            this.dgBox.AutoGenerateColumns = false;
            this.dgBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBox.DataSource = this.bsCaixa;
            this.dgBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgBox.Location = new System.Drawing.Point(0, 220);
            this.dgBox.Name = "dgBox";
            this.dgBox.RowHeadersVisible = false;
            this.dgBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBox.Size = new System.Drawing.Size(866, 255);
            this.dgBox.TabIndex = 17;
            // 
            // bsCaixa
            // 
            this.bsCaixa.DataSource = typeof(ControleDeCaixas2.Box);
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Location = new System.Drawing.Point(32, 153);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(42, 13);
            this.label_volume.TabIndex = 6;
            this.label_volume.Text = "Volume";
            // 
            // tb_volume
            // 
            this.tb_volume.Location = new System.Drawing.Point(81, 150);
            this.tb_volume.Name = "tb_volume";
            this.tb_volume.Size = new System.Drawing.Size(57, 20);
            this.tb_volume.TabIndex = 11;
            // 
            // caixaDB
            // 
            this.caixaDB.DataSetName = "CaixaDB";
            this.caixaDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 475);
            this.Controls.Add(this.dgBox);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.tb_volume);
            this.Controls.Add(this.tb_profundidade);
            this.Controls.Add(this.tb_largura);
            this.Controls.Add(this.tb_altura);
            this.Controls.Add(this.label_quantidade);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.label_profundidade);
            this.Controls.Add(this.label_largura);
            this.Controls.Add(this.label_altura);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label_BoxId);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "addBox";
            this.Text = "Adicionar caixa";
            this.Load += new System.EventHandler(this.addBox_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caixaDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_BoxId;
        private System.Windows.Forms.MaskedTextBox tb_id;
        private System.Windows.Forms.Label label_altura;
        private System.Windows.Forms.Label label_largura;
        private System.Windows.Forms.Label label_profundidade;
        private System.Windows.Forms.Label label_quantidade;
        private System.Windows.Forms.TextBox tb_altura;
        private System.Windows.Forms.TextBox tb_largura;
        private System.Windows.Forms.TextBox tb_profundidade;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgBox;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.TextBox tb_volume;
        private System.Windows.Forms.BindingSource bsCaixa;
        private CaixaDB caixaDB;
    }
}