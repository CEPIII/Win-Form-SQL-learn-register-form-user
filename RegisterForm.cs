using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSQLearn
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.fieldPassword.AutoSize = false;
            this.fieldPassword.Height = this.fieldLogIn.Height;     //высота поля пароля = высота поля

            fieldUserName.Text = "Введите имя";
            fieldUserName.ForeColor = Color.Gray;
            fieldUserSurname.Text = "Введите фамилию";
            fieldUserSurname.ForeColor = Color.Gray;
            fieldLogIn.Text = "Введите логин";
            fieldLogIn.ForeColor = Color.Gray;
            //fieldPassword.Text = "Введите пароль";    //  из за "звездочек" надпись не видна
            //fieldPassword.ForeColor = Color.Gray;
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


        /// <summary>
        /// Цеплялка шапки формы
        /// </summary>
        Point lastPoint;//  Координаты курсора 
        private void labelHeadRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelHeadRegister_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Цеплялка  серой формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelRegisterGray_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelRegisterGray_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        /// <summary>
        /// Подсказка поля серый текст ЮзТейм
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fieldUserName_Enter(object sender, EventArgs e)
        {
            if (fieldUserName.Text == "Введите имя")
            {
                fieldUserName.Text = "";
                fieldUserName.ForeColor = Color.Black;
            }

        }

        private void fieldUserName_Leave(object sender, EventArgs e)
        {
            if (fieldUserName.Text == "")
            {
                fieldUserName.Text = "Введите имя";
                fieldUserName.ForeColor = Color.LightGray;

            }
        }
        /// <summary>
        /// Подсказка поля серый текст ЮзСюрнейм
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fieldUserSurname_Enter(object sender, EventArgs e)
        {
            if (fieldUserSurname.Text == "Введите фамилию")
            {
                fieldUserSurname.Text = "";
                fieldUserSurname.ForeColor = Color.Black;
            }
        }

        private void fieldUserSurname_Leave(object sender, EventArgs e)
        {
            if (fieldUserSurname.Text == "")
            {
                fieldUserSurname.Text = "Введите фамилию";
                fieldUserSurname.ForeColor = Color.LightGray;
            }
        }
        /// <summary>
        /// Подсказка логина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fieldLogIn_Enter(object sender, EventArgs e)
        {
            if (fieldLogIn.Text == "Введите логин")
            {
                fieldLogIn.Text = "";
                fieldLogIn.ForeColor = Color.Black;
            }
        }

        private void fieldLogIn_Leave(object sender, EventArgs e)
        {
            if (fieldLogIn.Text == "")
            {
                fieldLogIn.Text = "Введите логин";
                fieldLogIn.ForeColor = Color.LightGray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`) VALUES (@login, @password, @name, @surname)");

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = fieldLogIn.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = fieldPassword.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = fieldUserName.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = fieldUserSurname.Text;


        }
    }
}

