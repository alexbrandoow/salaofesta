using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using DevExpress.Data.Utils;

namespace salaoPortfolio
{
    public partial class Consultar : Form
    {
        readonly Helpers helpers = new Helpers();

        public Consultar()
        {
            InitializeComponent();
        }
        public void TodosCadastros()
        {
            dgvEventos.DataSource = helpers.DgvGet();
        }
        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
            TodosCadastros();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            string selectedOption = cbOptions.Text;
            string filter = textBoxConsulta.Text;
            switch (selectedOption)
            {
                case "Apartamento":
                    dgvEventos.DataSource = helpers.DgvGet(" WHERE apartamento LIKE '%" + filter + "%'");
                    break;
                case "Nome":
                    dgvEventos.DataSource = helpers.DgvGet(" WHERE nome LIKE '%" + filter + "%'");
                    break;
            }
        }

        private void dgvEventos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEventos.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dgvEventos.Columns)
            {
                switch (column.Name)
                {
                    case "id":
                        column.Width = 45;
                        column.HeaderText = "ID";
                        break;
                    case "nome":
                        column.Width = 260;
                        column.HeaderText = "Nome";
                        break;
                    case "apartamento":
                        column.Width = 200;
                        column.HeaderText = "Apartamento";
                        break;
                    case "data":
                        column.Width = 75;
                        column.HeaderText = "Data Evento";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
