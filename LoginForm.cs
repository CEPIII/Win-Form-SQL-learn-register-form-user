using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinFormSQLearn
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.fieldPassword.AutoSize = false;
            this.fieldPassword.Height = this.fieldLogIn.Height;     //высота поля пароля = высота поля логина
        }

        private void ButtonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                //Работа с крестиком закрытия формы
        private void ButtonCloseWindow_MouseEnter(object sender, EventArgs e)
        {
            ButtonCloseWindow.ForeColor = Color.DarkCyan;            
            //ButtonCloseWindow.ForeColor = DefaultBackColor;
        }

        private void ButtonCloseWindow_MouseLeave(object sender, EventArgs e)
        {
            ButtonCloseWindow.ForeColor = DefaultBackColor;
        }


        // Цеплялка серой формы
        Point lastPoint;//  Координаты курсора 
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }



        // Цеплялка шапки формы
        private void labelHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelHead_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }




        //

    }
}
