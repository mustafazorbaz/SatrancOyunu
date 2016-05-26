using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SatrancProje
{
    class At:Taslar
    {
        private string ad;

        public At()
        {
        }

        public At(int isBlack, string ad) : base(isBlack, ad)
        {
            this.Ad1 = ad;
            PictureBox img = new PictureBox();
            if (isBlack==1)
            {
                img.BackgroundImage = SatrancProje.Properties.Resources.at2;
            }
            else if(isBlack==0)
            {
                img.BackgroundImage = SatrancProje.Properties.Resources.at;
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

            if ( taslar.Ad=="at_beyaz" && Form1.oyuncuBeyaz || taslar.Ad == "at_siyah" && Form1.oyuncuSiyah)
            {
                
                    base.Rnk.tasKonrolAtRenklendirme(oi, oj, si, sj);
            }
            else
            {
               
                if (base._SonrakiHandler != null)
                    base._SonrakiHandler.renklendirme(taslar, oi, oj, si, sj);
            }
        }
    }
}
