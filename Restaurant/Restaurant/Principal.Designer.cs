namespace Restaurant
{
    partial class Principal
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
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTexBox = new System.Windows.Forms.TextBox();
            this.UsuarioLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AcceptBtn.Location = new System.Drawing.Point(100, 148);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(182, 31);
            this.AcceptBtn.TabIndex = 2;
            this.AcceptBtn.Text = "Iniciar Sesión";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(100, 52);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(182, 20);
            this.UserTextBox.TabIndex = 0;
            // 
            // PasswordTexBox
            // 
            this.PasswordTexBox.Location = new System.Drawing.Point(100, 92);
            this.PasswordTexBox.Name = "PasswordTexBox";
            this.PasswordTexBox.Size = new System.Drawing.Size(182, 20);
            this.PasswordTexBox.TabIndex = 1;
            this.PasswordTexBox.UseSystemPasswordChar = true;
            // 
            // UsuarioLbl
            // 
            this.UsuarioLbl.AutoSize = true;
            this.UsuarioLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLbl.Location = new System.Drawing.Point(24, 54);
            this.UsuarioLbl.Name = "UsuarioLbl";
            this.UsuarioLbl.Size = new System.Drawing.Size(50, 16);
            this.UsuarioLbl.TabIndex = 2;
            this.UsuarioLbl.Text = "Usuario";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(24, 94);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(70, 16);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Contraseña";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 196);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsuarioLbl);
            this.Controls.Add(this.PasswordTexBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.AcceptBtn);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PasswordTexBox;
        private System.Windows.Forms.Label UsuarioLbl;
        private System.Windows.Forms.Label PasswordLbl;
    }
}

