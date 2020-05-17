namespace CarProjectV1
{
    partial class loginform
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
            this.picboxLogin = new System.Windows.Forms.PictureBox();
            this.lblTitelLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gropboxLogIn = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUSERNAME = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogin)).BeginInit();
            this.panel1.SuspendLayout();
            this.gropboxLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboxLogin
            // 
            this.picboxLogin.Location = new System.Drawing.Point(79, 153);
            this.picboxLogin.Name = "picboxLogin";
            this.picboxLogin.Size = new System.Drawing.Size(338, 154);
            this.picboxLogin.TabIndex = 0;
            this.picboxLogin.TabStop = false;
            // 
            // lblTitelLogin
            // 
            this.lblTitelLogin.AutoSize = true;
            this.lblTitelLogin.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitelLogin.ForeColor = System.Drawing.Color.White;
            this.lblTitelLogin.Location = new System.Drawing.Point(41, 16);
            this.lblTitelLogin.Name = "lblTitelLogin";
            this.lblTitelLogin.Size = new System.Drawing.Size(169, 57);
            this.lblTitelLogin.TabIndex = 1;
            this.lblTitelLogin.Text = "Sing In";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblTitelLogin);
            this.panel1.Location = new System.Drawing.Point(135, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 84);
            this.panel1.TabIndex = 2;
            // 
            // gropboxLogIn
            // 
            this.gropboxLogIn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gropboxLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gropboxLogIn.Controls.Add(this.textBox2);
            this.gropboxLogIn.Controls.Add(this.label1);
            this.gropboxLogIn.Controls.Add(this.textBox1);
            this.gropboxLogIn.Controls.Add(this.btnLogin);
            this.gropboxLogIn.Controls.Add(this.lblUSERNAME);
            this.gropboxLogIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gropboxLogIn.Location = new System.Drawing.Point(47, 333);
            this.gropboxLogIn.Name = "gropboxLogIn";
            this.gropboxLogIn.Size = new System.Drawing.Size(406, 233);
            this.gropboxLogIn.TabIndex = 3;
            this.gropboxLogIn.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = ":סיסמא";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 22);
            this.textBox1.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 3;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(43, 143);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(305, 69);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUSERNAME
            // 
            this.lblUSERNAME.AutoSize = true;
            this.lblUSERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUSERNAME.ForeColor = System.Drawing.Color.White;
            this.lblUSERNAME.Location = new System.Drawing.Point(270, 37);
            this.lblUSERNAME.Name = "lblUSERNAME";
            this.lblUSERNAME.Size = new System.Drawing.Size(135, 29);
            this.lblUSERNAME.TabIndex = 0;
            this.lblUSERNAME.Text = "User Name";
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CarProjectV1.Properties.Resources._11877793_car_background_in_blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 591);
            this.Controls.Add(this.gropboxLogIn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picboxLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "loginform";
            this.Text = "Log In";
            this.TransparencyKey = System.Drawing.SystemColors.Highlight;
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gropboxLogIn.ResumeLayout(false);
            this.gropboxLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxLogin;
        private System.Windows.Forms.Label lblTitelLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gropboxLogIn;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUSERNAME;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}