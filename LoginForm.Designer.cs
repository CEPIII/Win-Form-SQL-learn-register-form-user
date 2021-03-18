namespace WinFormSQLearn
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.fieldPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fieldLogIn = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonCloseWindow = new System.Windows.Forms.Label();
            this.labelHead = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.fieldPassword);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.fieldLogIn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 462);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(199, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fieldPassword
            // 
            this.fieldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldPassword.Location = new System.Drawing.Point(104, 226);
            this.fieldPassword.Name = "fieldPassword";
            this.fieldPassword.Size = new System.Drawing.Size(432, 47);
            this.fieldPassword.TabIndex = 4;
            this.fieldPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormSQLearn.Properties.Resources.lock_299105;
            this.pictureBox2.Location = new System.Drawing.Point(43, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // fieldLogIn
            // 
            this.fieldLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldLogIn.Location = new System.Drawing.Point(104, 136);
            this.fieldLogIn.Multiline = true;
            this.fieldLogIn.Name = "fieldLogIn";
            this.fieldLogIn.Size = new System.Drawing.Size(432, 64);
            this.fieldLogIn.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormSQLearn.Properties.Resources.user_male2_172626_512;
            this.pictureBox1.Location = new System.Drawing.Point(40, 136);
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
            this.panel2.Controls.Add(this.labelHead);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 100);
            this.panel2.TabIndex = 0;
            // 
            // ButtonCloseWindow
            // 
            this.ButtonCloseWindow.AutoSize = true;
            this.ButtonCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCloseWindow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonCloseWindow.Location = new System.Drawing.Point(567, 9);
            this.ButtonCloseWindow.Name = "ButtonCloseWindow";
            this.ButtonCloseWindow.Size = new System.Drawing.Size(25, 29);
            this.ButtonCloseWindow.TabIndex = 1;
            this.ButtonCloseWindow.Text = "x";
            this.ButtonCloseWindow.Click += new System.EventHandler(this.ButtonCloseWindow_Click);
            this.ButtonCloseWindow.MouseEnter += new System.EventHandler(this.ButtonCloseWindow_MouseEnter);
            this.ButtonCloseWindow.MouseLeave += new System.EventHandler(this.ButtonCloseWindow_MouseLeave);
            // 
            // labelHead
            // 
            this.labelHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHead.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(119)))));
            this.labelHead.Location = new System.Drawing.Point(0, 0);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(604, 100);
            this.labelHead.TabIndex = 0;
            this.labelHead.Text = "Авторизация";
            this.labelHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelHead_MouseDown);
            this.labelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelHead_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 462);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ButtonCloseWindow;
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox fieldPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox fieldLogIn;
        private System.Windows.Forms.Button button1;
    }
}