﻿using ProjetoEmCamadas_WindowsForms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEmCamadas_WindowsForms
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastroCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria frmCategoria = new frmCadastroCategoria();
            frmCategoria.ShowDialog();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListagemCategorias frmListaCategorias = new frmListagemCategorias();
            frmListaCategorias.ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            frmApagandoCategoria frmApagarCategoria = new frmApagandoCategoria();
            frmApagarCategoria.ToString("Qual a categoria deseja apagar")
        }
    }
}
