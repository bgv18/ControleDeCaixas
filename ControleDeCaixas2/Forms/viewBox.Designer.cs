namespace ControleDeCaixas2.Forms
{
    partial class viewBox
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
            this.dataGridView_caixa = new System.Windows.Forms.DataGridView();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_caixa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_caixa
            // 
            this.dataGridView_caixa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_caixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_caixa.Location = new System.Drawing.Point(37, 26);
            this.dataGridView_caixa.Name = "dataGridView_caixa";
            this.dataGridView_caixa.RowHeadersVisible = false;
            this.dataGridView_caixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_caixa.Size = new System.Drawing.Size(555, 318);
            this.dataGridView_caixa.TabIndex = 0;
            this.dataGridView_caixa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_caixa_CellContentClick);
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sair.Location = new System.Drawing.Point(262, 363);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(96, 39);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // viewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 414);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.dataGridView_caixa);
            this.Name = "viewBox";
            this.Text = "viewBox";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_caixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_caixa;
        private System.Windows.Forms.Button btn_sair;
    }
}