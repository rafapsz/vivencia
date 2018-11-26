using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.Basico.Telas.SubTelas
{
    public partial class frmTema : UserControl
    {
        public frmTema()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tema cor = new Tema();
            cor.CarregarTema1();

            ((frmPrincipal)this.ParentForm).Fechar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tema cor = new Tema();
            cor.CarregarTema2();

            ((frmPrincipal)this.ParentForm).Fechar();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTema_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
