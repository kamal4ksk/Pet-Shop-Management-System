namespace petshopmanagementsystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.resetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.gunaTransfarantPictureBox2 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.nameTB = new Guna.UI.WinForms.GunaTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paswordTB = new Guna.UI.WinForms.GunaTextBox();
            this.adminBtn = new System.Windows.Forms.Button();
            this.gunaElipsePanel5 = new Guna.UI.WinForms.GunaElipsePanel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).BeginInit();
            this.gunaElipsePanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.resetBtn.Location = new System.Drawing.Point(303, 196);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(77, 38);
            this.resetBtn.TabIndex = 14;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "SIGN IN";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.loginBtn.Location = new System.Drawing.Point(168, 196);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(77, 38);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // gunaTransfarantPictureBox2
            // 
            this.gunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox2.Image")));
            this.gunaTransfarantPictureBox2.Location = new System.Drawing.Point(28, 31);
            this.gunaTransfarantPictureBox2.Name = "gunaTransfarantPictureBox2";
            this.gunaTransfarantPictureBox2.Size = new System.Drawing.Size(149, 117);
            this.gunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox2.TabIndex = 21;
            this.gunaTransfarantPictureBox2.TabStop = false;
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.Transparent;
            this.nameTB.BaseColor = System.Drawing.Color.White;
            this.nameTB.BorderColor = System.Drawing.Color.Gray;
            this.nameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTB.FocusedBaseColor = System.Drawing.Color.White;
            this.nameTB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nameTB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTB.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.nameTB.Location = new System.Drawing.Point(276, 28);
            this.nameTB.Name = "nameTB";
            this.nameTB.PasswordChar = '\0';
            this.nameTB.Radius = 7;
            this.nameTB.SelectedText = "";
            this.nameTB.Size = new System.Drawing.Size(160, 30);
            this.nameTB.TabIndex = 36;
            this.nameTB.TextChanged += new System.EventHandler(this.loginTB_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 22);
            this.label12.TabIndex = 37;
            this.label12.Text = "PASSWORD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 22);
            this.label2.TabIndex = 38;
            this.label2.Text = "EMPLOYEE NAME";
            // 
            // paswordTB
            // 
            this.paswordTB.BackColor = System.Drawing.Color.Transparent;
            this.paswordTB.BaseColor = System.Drawing.Color.White;
            this.paswordTB.BorderColor = System.Drawing.Color.Gray;
            this.paswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paswordTB.FocusedBaseColor = System.Drawing.Color.White;
            this.paswordTB.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.paswordTB.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.paswordTB.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.paswordTB.Location = new System.Drawing.Point(276, 91);
            this.paswordTB.Name = "paswordTB";
            this.paswordTB.PasswordChar = '*';
            this.paswordTB.Radius = 7;
            this.paswordTB.SelectedText = "";
            this.paswordTB.Size = new System.Drawing.Size(160, 30);
            this.paswordTB.TabIndex = 39;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.adminBtn.Location = new System.Drawing.Point(438, 196);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(77, 38);
            this.adminBtn.TabIndex = 40;
            this.adminBtn.Text = "ADMIN";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // gunaElipsePanel5
            // 
            this.gunaElipsePanel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.gunaElipsePanel5.Controls.Add(this.label2);
            this.gunaElipsePanel5.Controls.Add(this.adminBtn);
            this.gunaElipsePanel5.Controls.Add(this.label12);
            this.gunaElipsePanel5.Controls.Add(this.paswordTB);
            this.gunaElipsePanel5.Controls.Add(this.resetBtn);
            this.gunaElipsePanel5.Controls.Add(this.nameTB);
            this.gunaElipsePanel5.Controls.Add(this.loginBtn);
            this.gunaElipsePanel5.Location = new System.Drawing.Point(277, 97);
            this.gunaElipsePanel5.Name = "gunaElipsePanel5";
            this.gunaElipsePanel5.Radius = 20;
            this.gunaElipsePanel5.Size = new System.Drawing.Size(676, 248);
            this.gunaElipsePanel5.TabIndex = 41;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 956);
            this.Controls.Add(this.gunaElipsePanel5);
            this.Controls.Add(this.gunaTransfarantPictureBox2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).EndInit();
            this.gunaElipsePanel5.ResumeLayout(false);
            this.gunaElipsePanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginBtn;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox2;
        private Guna.UI.WinForms.GunaTextBox nameTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox paswordTB;
        private System.Windows.Forms.Button adminBtn;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel5;
    }
}