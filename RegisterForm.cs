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
    }
}
