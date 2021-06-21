using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salaoPortfolio
{
    public partial class Registrar : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando = new MySqlCommand();
        string strQuery;
        public Registrar()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            var sMes = "";
            if (textNome.Text == "" || textApartamento.Text == "" || comboBoxAno.SelectedIndex.ToString() == "-1" || comboBoxDia.SelectedIndex.ToString() == "-1" || comboBoxMes.SelectedIndex.ToString() == "-1")
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
                    strQuery = "INSERT INTO eventos VALUES (@ID, @NOME, @APARTAMENTO, @DATA)";
                    comando = new MySqlCommand(strQuery, conexao);
                    comando.Parameters.AddWithValue("@ID", null);
                    comando.Parameters.AddWithValue("@NOME", textNome.Text);
                    comando.Parameters.AddWithValue("@APARTAMENTO", textApartamento.Text);
                    comando.Parameters.AddWithValue("@DATA", sData);
                    conexao.Open();

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado com sucesso!");
                    textNome.Text = "";
                    textApartamento.Text = "";
                    comboBoxDia.SelectedIndex = -1;
                    comboBoxMes.SelectedIndex = -1;
                    comboBoxAno.SelectedIndex = -1;
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
