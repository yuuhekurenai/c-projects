﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FrmDoacao : Form
    {
        public FrmDoacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.torneseumprogramador.com.br");
        }

        private void FrmDoacao_Load(object sender, EventArgs e)
        {
            dadosDaEmpresa1.Busca = "orientacao a objetos";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }
    }
}
