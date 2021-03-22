namespace WinFormSQLearn
{
    partial class RegisterForm
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
            this.panelRegisterGray = new System.Windows.Forms.Panel();
            this.fieldUserSurname = new System.Windows.Forms.TextBox();
            this.fieldUserName = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.fieldPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fieldLogIn = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonCloseWindow = new System.Windows.Forms.Label();
            this.labelHeadRegister = new System.Windows.Forms.Label();
            this.panelRegisterGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegisterGray
            // 
            this.panelRegisterGray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.panelRegisterGray.Controls.Add(this.fieldUserSurname);
            this.panelRegisterGray.Controls.Add(this.fieldUserName);
            this.panelRegisterGray.Controls.Add(this.buttonRegister);
            this.panelRegisterGray.Controls.Add(this.fieldPassword);
            this.panelRegisterGray.Controls.Add(this.pictureBox2);
            this.panelRegisterGray.Controls.Add(this.fieldLogIn);
            this.panelRegisterGray.Controls.Add(this.pictureBox1);
            this.panelRegisterGray.Controls.Add(this.panel2);
            this.panelRegisterGray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegisterGray.Location = new System.Drawing.Point(0, 0);
            this.panelRegisterGray.Name = "panelRegisterGray";
            this.panelRegisterGray.Size = new System.Drawing.Size(1197, 468);
            this.panelRegisterGray.TabIndex = 1;
            this.panelRegisterGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegisterGray_MouseDown);
            this.panelRegisterGray.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRegisterGray_MouseMove);
            // 
            // fieldUserSurname
            // 
            this.fieldUserSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldUserSurname.Location = new System.Drawing.Point(672, 146);
            this.fieldUserSurname.Multiline = true;
            this.fieldUserSurname.Name = "fieldUserSurname";
            this.fieldUserSurname.Size = new System.Drawing.Size(461, 64);
            this.fieldUserSurname.TabIndex = 7;
            this.fieldUserSurname.UseSystemPasswordChar = true;
            this.fieldUserSurname.Enter += new System.EventHandler(this.fieldUserSurname_Enter);
            this.fieldUserSurname.Leave += new System.EventHandler(this.fieldUserSurname_Leave);
            // 
            // fieldUserName
            // 
            this.fieldUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldUserName.Location = new System.Drawing.Point(101, 146);
            this.fieldUserName.Multiline = true;
            this.fieldUserName.Name = "fieldUserName";
            this.fieldUserName.Size = new System.Drawing.Size(432, 64);
            this.fieldUserName.TabIndex = 6;
            this.fieldUserName.Enter += new System.EventHandler(this.fieldUserName_Enter);
            this.fieldUserName.Leave += new System.EventHandler(this.fieldUserName_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(446, 355);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(289, 60);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // fieldPassword
            // 
            this.fieldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldPassword.Location = new System.Drawing.Point(672, 259);
            this.fieldPassword.Name = "fieldPassword";
            this.fieldPassword.Size = new System.Drawing.Size(461, 47);
            this.fieldPassword.TabIndex = 4;
            this.fieldPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormSQLearn.Properties.Resources.lock_299105;
            this.pictureBox2.Location = new System.Drawing.Point(611, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // fieldLogIn
            // 
            this.fieldLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldLogIn.Location = new System.Drawing.Point(101, 256);
            this.fieldLogIn.Multiline = true;
            this.fieldLogIn.Name = "fieldLogIn";
            this.fieldLogIn.Size = new System.Drawing.Size(432, 64);
            this.fieldLogIn.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormSQLearn.Properties.Resources.user_male2_172626_512;
            this.pictureBox1.Location = new System.Drawing.Point(37, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.ButtonCloseWindow);
            this.panel2.Controls.Add(this.labelHeadRegister);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 100);
            this.panel2.TabIndex = 0;
            // 
            // ButtonCloseWindow
            // 
            this.ButtonCloseWindow.AutoSize = true;
            this.ButtonCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCloseWindow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonCloseWindow.Location = new System.Drawing.Point(1172, 0);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(25, 29);
            this.ButtonCloseWindow.TabIndex = 1;
            this.ButtonCloseWindow.Text = "x";
            this.ButtonCloseWindow.Click += new System.EventHandler(this.ButtonCloseWindow_Click);
            this.ButtonCloseWindow.MouseEnter += new System.EventHandler(this.ButtonCloseWindow_MouseEnter);
            this.ButtonCloseWindow.MouseLeave += new System.EventHandler(this.ButtonCloseWindow_MouseLeave);
            // 
            // labelHeadRegister
            // 
            this.labelHeadRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeadRegister.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeadRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(119)))));
            this.labelHeadRegister.Location = new System.Drawing.Point(0, 0);
            this.labelHeadRegister.Name = "labelHeadRegister";
            this.labelHeadRegister.Size = new System.Drawing.Size(1197, 100);
            this.labelHeadRegister.TabIndex = 0;
            this.labelHeadRegister.Text = "Регистрация";
            this.labelHeadRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeadRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelHeadRegister_MouseDown);
            this.labelHeadRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelHeadRegister_MouseMove);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 468);
            this.Controls.Add(this.panelRegisterGray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panelRegisterGray.ResumeLayout(false);
            this.panelRegisterGray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegisterGray;
        private System.Windows.Forms.TextBox fieldUserSurname;
        private System.Windows.Forms.TextBox fieldUserName;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox fieldPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox fieldLogIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ButtonCloseWindow;
        private System.Windows.Forms.Label labelHeadRegister;
    }
}