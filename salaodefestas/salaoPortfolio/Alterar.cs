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

namespace salaoPortfolio
{
    public partial class Alterar : Form
    {
        readonly Helpers helpers = new Helpers();

        MySqlConnection conexao;
        MySqlCommand comando = new MySqlCommand();
        string strQuery;
        string sId;
        string sMes;

        public Alterar()
        {
            InitializeComponent();
        }

        private void BtnExibirTodos_Click(object sender, EventArgs e)
        {
            dgvEventos.DataSource = helpers.DgvGet();
        }

        private void dgvEvento_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvEventos.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dgvEventos.Columns)
            {
                switch (column.Name)
                {
                    #region Formatacao colunas
                    case "id":
                        column.Width = 45;
                        column.HeaderText = "ID";
                        break;
                    case "nome":
                        column.Width = 200;
                        column.HeaderText = "Nome";
                        break;
                    case "apartamento":
                        column.Width = 230;
                        column.HeaderText = "Apartamento";
                        break;
                    case "data":
                        column.Width = 70;
                        column.HeaderText = "Data Evento";
                        break;
                    case "editar":
                        column.DisplayIndex = 4;
                        column.Width = 30;
                        break;
                    case "excluir":
                        column.DisplayIndex = 5;
                        column.Width = 30;
                        break;
                    default:
                        break;
                    #endregion
                }
            }
        }

        private void dgvEvento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvEventos.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar.";
            dgvEventos.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir.";
        }

        private void dgvEvento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sEditar = dgvEventos.Rows[e.RowIndex].Cells["editar"].Selected;
            var sExcluido = dgvEventos.Rows[e.RowIndex].Cells["excluir"].Selected;

            if (sEditar == true)
            {
                textNome.Text = dgvEventos.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                textApartamento.Text = dgvEventos.Rows[e.RowIndex].Cells["apartamento"].Value.ToString();
                var sSeparaData = dgvEventos.Rows[e.RowIndex].Cells["data"].Value.ToString().Split('/');
                comboBoxDia.Text = sSeparaData[0];
                comboBoxAno.Text = sSeparaData[sSeparaData.Length - 1].Split(' ')[0];
                sId = dgvEventos.Rows[e.RowIndex].Cells["id"].Value.ToString();
                switch (sSeparaData[1])
                {
                    #region Meses

                    case "01":
                        comboBoxMes.Text = "Jan.";
                        break;
                    case "02":
                        comboBoxMes.Text = "Fev.";
                        break;
                    case "03":
                        comboBoxMes.Text = "Mar.";
                        break;
                    case "04":
                        comboBoxMes.Text = "Abr.";
                        break;
                    case "05":
                        comboBoxMes.Text = "Mai.";
                        break;
                    case "06":
                        comboBoxMes.Text = "Jun.";
                        break;
                    case "07":
                        comboBoxMes.Text = "Jul.";
                        break;
                    case "08":
                        comboBoxMes.Text = "Ago.";
                        break;
                    case "09":
                        comboBoxMes.Text = "Set.";
                        break;
                    case "10":
                        comboBoxMes.Text = "Out.";
                        break;
                    case "11":
                        comboBoxMes.Text = "Nov.";
                        break;
                    case "12":
                        comboBoxMes.Text = "Dez.";
                        break;
                        #endregion
                }
            }
            else if (sExcluido == true)
            {
                sId = dgvEventos.Rows[e.RowIndex].Cells["id"].Value.ToString();
                DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Excluir Evento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    try
                    {
                        conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString());
                        strQuery = "DELETE FROM eventos WHERE id =" + " '" + sId + "' ";
                        comando = new MySqlCommand(strQuery, conexao);
                        conexao.Open();

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Evento Excluido com sucesso!");

                        dgvEventos.DataSource = helpers.DgvGet();
                    }
                    catch (MySqlException msqle)
                    {
                        MessageBox.Show(msqle.ToString());
                    }
                }
            }
        }

        private void btn_SalvarAlteracao_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Salvar Alteraçao", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (string.IsNullOrEmpty(sId))
                MessageBox.Show("Favor selecionar Evento!");

            else if (confirm.ToString().ToUpper() == "YES")
            {
                var sNome = textNome.Text.ToString();
                var sApartamento = textApartamento.Text.ToString();

                if (sNome == "" || sApartamento == "" || comboBoxAno.SelectedIndex.ToString() == "-1" || comboBoxDia.SelectedIndex.ToString() == "-1" || comboBoxMes.SelectedIndex.ToString() == "-1")
                    MessageBox.Show(" Algum campo está vazio ");
                else
                {
                    try
                    {
                        switch (comboBoxMes.Text)
                        {
                            #region Meses

                            case "Jan.":
                                sMes = "01";
                                break;
                            case "Fev.":
                                sMes = "02";
                                break;
                            case "Mar.":
                                sMes = "03";
                                break;
                            case "Abr.":
                                sMes = "04";
                                break;
                            case "Mai.":
                                sMes = "05";
                                break;
                            case "Jun.":
                                sMes = "06";
                                break;
                            case "Jul.":
                                sMes = "07";
                                break;
                            case "Ago.":
                                sMes = "08";
                                break;
                            case "Set.":
                                sMes = "09";
                                break;
                            case "Out.":
                                sMes = "10";
                                break;
                            case "Nov.":
                                sMes = "11";
                                break;
                            case "Dez.":
                                sMes = "12";
                                break;

                                #endregion
                        }
                        var sData = comboBoxAno.Text + "/" + sMes + "/" + comboBoxDia.Text;
                        conexao = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySQLConnectionString"].ToString());
                        strQuery = "UPDATE eventos SET nome = " + " '" + sNome + "' " + ", apartamento = " + " '" + sApartamento + "' " + ", data = " + " '" + sData + "' " + " WHERE id = " + "'" + sId + "'";
                        comando = new MySqlCommand(strQuery, conexao);
                        conexao.Open();

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Evento Editado com sucesso!");

                        dgvEventos.DataSource = helpers.DgvGet();
                    }
                    catch (MySqlException msqle)
                    {
                        if (msqle.ToString().Contains("Duplicate entry"))
                            MessageBox.Show("Essa data já esta em uso!");
                        else
                            MessageBox.Show(msqle.ToString());
                    }
                    finally
                    {
                        conexao.Close();
                        conexao = null;
                        comando = null;
                    }
                }
            }
        }
    }
}
