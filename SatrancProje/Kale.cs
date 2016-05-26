using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace SatrancProje
{
    class Kale:Taslar
    {
        private string ad;

        public Kale()
        {
        }

        public Kale(int isBlack, string ad) : base(isBlack, ad)
        {
            this.Ad1 = ad;
            PictureBox img = new PictureBox();
            if (isBlack == 1)
            {
                  img.BackgroundImage = SatrancProje.Properties.Resources.kale2;
            }
            else if(isBlack==0)
            {
                img.BackgroundImage = SatrancProje.Properties.Resources.kale;
            }
           
            base.D_img = img;
        }

        public string Ad1
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }
        public override void renklendirme(Taslar taslar, int oi, int oj, int si, int sj)
        {

            if (taslar.Ad == "kale_beyaz" && Form1.oyuncuBeyaz == true || taslar.Ad == "kale_siyah" && Form1.oyuncuSiyah == true)
            {
                base.Rnk.tasKontrolAsagiRenklendirme(oi, oj);
                base.Rnk.tasKontrolYukariRenklendirme(oi, oj);
                base.Rnk.tasKontrolSagaRenklendirme(oi, oj);
                base.Rnk.tasKontrolSolaRenklendirme(oi, oj);
              
            }
            
        }
    }
}
