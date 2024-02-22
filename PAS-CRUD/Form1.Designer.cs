namespace PAS_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_showpass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PAS_CRUD.Properties.Resources.logOutIcons;
            this.pictureBox5.Location = new System.Drawing.Point(39, 496);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 64;
            this.pictureBox5.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Gilroy-SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogOut.ForeColor = System.Drawing.Color.Red;
            this.buttonLogOut.Location = new System.Drawing.Point(78, 500);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(67, 29);
            this.buttonLogOut.TabIndex = 63;
            this.buttonLogOut.Text = "Exit";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gilroy-Bold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(98, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 33);
            this.label4.TabIndex = 62;
            this.label4.Text = "Apotik Guwe";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PAS_CRUD.Properties.Resources.iconMedical;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 60;
            this.pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Gilroy-Bold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(39, 403);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(394, 47);
            this.btnLogin.TabIndex = 59;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gilroy-SemiBold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(39, 289);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 57;
            this.label3.Text = "Password";
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_username.Location = new System.Drawing.Point(45, 239);
            this.tb_username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(389, 33);
            this.tb_username.TabIndex = 56;
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.Location = new System.Drawing.Point(45, 319);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(389, 33);
            this.tb_password.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gilroy-SemiBold", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(39, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PAS_CRUD.Properties.Resources.loginHero;
            this.pictureBox1.Location = new System.Drawing.Point(495, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gilroy-Bold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(192, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 54;
            this.label1.Text = "LOGIN";
            // 
            // cb_showpass
            // 
            this.cb_showpass.AutoSize = true;
            this.cb_showpass.Location = new System.Drawing.Point(48, 366);
            this.cb_showpass.Name = "cb_showpass";
            this.cb_showpass.Size = new System.Drawing.Size(129, 24);
            this.cb_showpass.TabIndex = 65;
            this.cb_showpass.Text = "Show Password";
            this.cb_showpass.UseVisualStyleBackColor = true;
            this.cb_showpass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(928, 559);
            this.Controls.Add(this.cb_showpass);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox5;
        private Button buttonLogOut;
        private Label label4;
        private PictureBox pictureBox2;
        private Button btnLogin;
        private Label label3;
        private TextBox tb_username;
        private TextBox tb_password;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private CheckBox cb_showpass;
    }
}