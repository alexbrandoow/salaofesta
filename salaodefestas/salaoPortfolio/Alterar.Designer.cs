﻿
namespace salaoPortfolio
{
    partial class Alterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar));
            this.textApartamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.comboBoxAno = new System.Windows.Forms.ComboBox();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.comboBoxDia = new System.Windows.Forms.ComboBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.btnExibirTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // textApartamento
            // 
            this.textApartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textApartamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApartamento.Location = new System.Drawing.Point(12, 146);
            this.textApartamento.Name = "textApartamento";
            this.textApartamento.Size = new System.Drawing.Size(278, 26);
            this.textApartamento.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Apartamento :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome :";
            // 
            // textNome
            // 
            this.textNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(12, 98);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(278, 26);
            this.textNome.TabIndex = 23;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(94, 253);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(115, 29);
            this.BtnRegister.TabIndex = 22;
            this.BtnRegister.Text = "Salvar alteração";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.btn_SalvarAlteracao_Click);
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editar,
            this.excluir});
            this.dgvEventos.Location = new System.Drawing.Point(296, 81);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersWidth = 10;
            this.dgvEventos.Size = new System.Drawing.Size(483, 246);
            this.dgvEventos.TabIndex = 29;
            this.dgvEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvento_CellContentClick);
            this.dgvEventos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEvento_CellFormatting);
            this.dgvEventos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEvento_DataBindingComplete);
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.ToolTipText = "Clique para Editar";
            this.editar.Width = 30;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "";
            this.excluir.Image = ((System.Drawing.Image)(resources.GetObject("excluir.Image")));
            this.excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.ToolTipText = "Clique para Excluir";
            this.excluir.Width = 30;
            // 
            // comboBoxAno
            // 
            this.comboBoxAno.DropDownHeight = 100;
            this.comboBoxAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAno.DropDownWidth = 100;
            this.comboBoxAno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAno.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxAno.FormattingEnabled = true;
            this.comboBoxAno.IntegralHeight = false;
            this.comboBoxAno.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099",
            "2100"});
            this.comboBoxAno.Location = new System.Drawing.Point(201, 198);
            this.comboBoxAno.Name = "comboBoxAno";
            this.comboBoxAno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxAno.Size = new System.Drawing.Size(89, 26);
            this.comboBoxAno.TabIndex = 33;
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.DropDownHeight = 100;
            this.comboBoxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMes.DropDownWidth = 100;
            this.comboBoxMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMes.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.IntegralHeight = false;
            this.comboBoxMes.Items.AddRange(new object[] {
            "Jan.",
            "Fev.",
            "Mar.",
            "Abr.",
            "Mai.",
            "Jun.",
            "Jul.",
            "Ago.",
            "Set.",
            "Out.",
            "Nov.",
            "Dez."});
            this.comboBoxMes.Location = new System.Drawing.Point(85, 198);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxMes.Size = new System.Drawing.Size(110, 26);
            this.comboBoxMes.TabIndex = 32;
            // 
            // comboBoxDia
            // 
            this.comboBoxDia.DropDownHeight = 100;
            this.comboBoxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDia.DropDownWidth = 100;
            this.comboBoxDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDia.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxDia.FormattingEnabled = true;
            this.comboBoxDia.IntegralHeight = false;
            this.comboBoxDia.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDia.Location = new System.Drawing.Point(12, 198);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(67, 26);
            this.comboBoxDia.TabIndex = 30;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(9, 178);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(41, 17);
            this.Telefone.TabIndex = 31;
            this.Telefone.Text = "Data:";
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Location = new System.Drawing.Point(686, 52);
            this.btnExibirTodos.Name = "btnExibirTodos";
            this.btnExibirTodos.Size = new System.Drawing.Size(93, 23);
            this.btnExibirTodos.TabIndex = 34;
            this.btnExibirTodos.Text = "Exibir Todos";
            this.btnExibirTodos.UseVisualStyleBackColor = true;
            this.btnExibirTodos.Click += new System.EventHandler(this.BtnExibirTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VALORANT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 38);
            this.label1.TabIndex = 35;
            this.label1.Text = "Alterar eventos";
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(801, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExibirTodos);
            this.Controls.Add(this.comboBoxAno);
            this.Controls.Add(this.comboBoxMes);
            this.Controls.Add(this.comboBoxDia);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.textApartamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.BtnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alterar";
            this.Text = "Alterar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textApartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.ComboBox comboBoxAno;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.ComboBox comboBoxDia;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Button btnExibirTodos;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
        private System.Windows.Forms.Label label1;
    }
}