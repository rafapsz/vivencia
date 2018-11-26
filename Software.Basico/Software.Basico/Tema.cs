using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Basico
{
    class Tema
    {
        public static string tema { get; set; }

        public static Color Principal { get; set; }
        public static Color Primaria { get; set; }
        public static Color Segundaria { get; set; }
        public static Color Terciaria { get; set; }
        public static Color Texto { get; set; }

        public void CarregarTema0()
        {
            Principal = Color.FromArgb(232, 232, 232);
            Primaria = Color.FromArgb(51, 58, 86);
            Segundaria = Color.FromArgb(82, 101, 143);
            Terciaria = Color.FromArgb(101, 100, 219);
            Texto = Color.FromArgb(232, 232, 232);

            tema = "2";
        }

        public void CarregarTema1()
        {
            Principal = Color.FromArgb(255, 217, 206);
            Primaria = Color.FromArgb(0, 0, 0);
            Segundaria = Color.FromArgb(219, 84, 97);
            Terciaria = Color.FromArgb(101, 100, 219);
            Texto = Color.FromArgb(255, 255, 255);

            tema = "1";
        }

        public void CarregarTema2()
        {
            Principal = Color.FromArgb(205, 205, 205);
            Primaria = Color.FromArgb(136, 187, 214);
            Segundaria = Color.FromArgb(153, 211, 223);
            Terciaria = Color.FromArgb(214, 73, 51);
            Texto = Color.FromArgb(255, 255, 255);

            tema = "2";
        }
    }
}
