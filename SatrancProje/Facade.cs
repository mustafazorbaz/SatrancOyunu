using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrancProje
{
    class Facade
    {
        public Facade()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Form1.taslar[i, j] = new Taslar(-1);
                }
            }
            for (int i = 0; i < 8; i++)
            {
                Form1.taslar[1, i] = new Piyon(0, "piyon_beyaz");

            }

            for (int i = 0; i < 8; i++)
            {
                Form1.taslar[6, i] = new Piyon(1, "piyon_siyah");

            }

            Form1.taslar[0, 0] = new Kale(0, "kale_beyaz");
            Form1.taslar[7, 0] = new Kale(1, "kale_siyah");
            Form1.taslar[0, 7] = new Kale(0, "kale_beyaz");
            Form1.taslar[7, 7] = new Kale(1, "kale_siyah");
            Form1.taslar[0, 1] = new At(0, "at_beyaz");
            Form1.taslar[7, 1] = new At(1, "at_siyah");
            Form1.taslar[0, 6] = new At(0, "at_beyaz");
            Form1.taslar[7, 6] = new At(1, "at_siyah");
            Form1.taslar[0, 2] = new Fil(0, "fil_beyaz");
            Form1.taslar[7, 2] = new Fil(1, "fil_siyah");
            Form1.taslar[0, 5] = new Fil(0, "fil_beyaz");
            Form1.taslar[7, 5] = new Fil(1, "fil_siyah");
            Form1.taslar[0, 4] = new Vezir(0, "vezir_beyaz");
            Form1.taslar[7, 4] = new Vezir(1, "vezir_siyah");
            Form1.taslar[0, 3] = new Sah(0, "sah_beyaz");
            Form1.taslar[7, 3] = new Sah(1, "sah_siyah");
        }
    }
}
