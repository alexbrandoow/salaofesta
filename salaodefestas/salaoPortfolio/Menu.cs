using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salaoPortfolio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            abrirFormPricipal(new Registrar());
            if(MenuLatertalEs.Width == 300)
                MenuLatertalEs.Width = 80;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            abrirFormPricipal(new Consultar());
            if (MenuLatertalEs.Width == 300)
                MenuLatertalEs.Width = 80;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            abrirFormPricipal(new Alterar());
            if (MenuLatertalEs.Width == 300)
                MenuLatertalEs.Width = 80;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (MenuLatertalEs.Width == 80)
            {
                MenuLatertalEs.Width = 300;
            }
            else
                MenuLatertalEs.Width = 80;
        }

        private Form activeForm = null;
        private void abrirFormPricipal(Form principalForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = principalForm;
            principalForm.TopLevel = false;
            principalForm.FormBorderStyle = FormBorderStyle.None;
            principalForm.Dock = DockStyle.Fill;
            panelprincipal.Controls.Add(principalForm);
            panelprincipal.Tag = principalForm;
            principalForm.BringToFront();
            principalForm.Show();
        }

        private void pictureBox_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
