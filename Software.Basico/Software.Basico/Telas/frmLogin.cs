using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            TemaTela();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.ShowDialog();
            Show();
        }

        private void TemaTela()
        {
            panel1.BackColor = Tema.Primaria;
        }
    }
}
