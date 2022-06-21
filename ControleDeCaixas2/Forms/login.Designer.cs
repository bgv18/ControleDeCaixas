namespace ControleDeCaixas2.Forms
{
    partial class login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(60, 177);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(99, 40);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Entrar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(84, 56);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(57, 17);
            this.label_user.TabIndex = 1;
            this.label_user.Text = "Usuario";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(92, 112);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(49, 17);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Senha";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(162, 112);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(132, 20);
            this.tb_password.TabIndex = 4;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(162, 55);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(132, 20);
            this.tb_user.TabIndex = 5;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(253, 177);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(99, 40);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 257);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.btn_login);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Button btn_exit;
    }
}