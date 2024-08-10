using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_45_08_08_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void telasDeFormulárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(); 
            clientes.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedores = new Fornecedores(); 
            fornecedores.Show();    
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.Show();    
        }
    }
}
