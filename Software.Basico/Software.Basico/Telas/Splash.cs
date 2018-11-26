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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            Tema cor = new Tema();
            cor.CarregarTema0();

            // Inicia contagem para término da Splash Screen
            Task.Factory.StartNew(() =>
            {
                // Espera 5 segundos para iniciar o sistema
                System.Threading.Thread.Sleep(5000);

                Invoke(new Action(() =>
                {
                    // Abre a tela Inicial
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    Hide();
                }));
            });
        }
    }
}
