using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrancProje
{
    
    class  TahtaOlusturSingleton
    {
        private static TahtaOlusturSingleton nesne = new TahtaOlusturSingleton();
        private  TahtaOlusturSingleton()
        {
          
        }
        
        public static TahtaOlusturSingleton Nesne()
        {
              return nesne;
        }
        public static void Tahta(int i,int j,int x,int y)
        {
            Form1.kareler[i, j] = new PictureBox();
            Form1.kareler[i, j].Name = "p" + Convert.ToString(i) + Convert.ToString(j);
            Form1.kareler[i, j].Width = 80;
            Form1.kareler[i, j].Height = 80;

            if (j % 2 == 0 && i % 2 == 0)
                Form1.kareler[i, j].BackColor = Color.DarkRed;
            else if (j % 2 != 0 && i % 2 != 0)
                Form1.kareler[i, j].BackColor = Color.DarkRed;
            else
                Form1.kareler[i, j].BackColor = Color.DarkSlateBlue;

            Form1.kareler[i, j].Top = x;
            Form1.kareler[i, j].Left = y;
        }
    }
}
