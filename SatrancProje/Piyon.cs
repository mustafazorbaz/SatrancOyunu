using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SatrancProje
{
    class  Piyon:Taslar
    {
        private string ad;

        public Piyon()
        {
        }

        public Piyon(int isBlack, string ad) : base(isBlack,ad)
        {
            this.Ad1 = ad;
            
            PictureBox img = new PictureBox();
            if (isBlack==1)
            {
                img.BackgroundImage = SatrancProje.Properties.Resources.piyon2;
            }
            else if (isBlack==0)
            {
                img.BackgroundImage = SatrancProje.Properties.Resources.piyon;
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

        public override void renklendirme(Taslar taslar,int oi,int oj,int si,int sj)
        {

            if (taslar.Ad == "piyon_beyaz" && Form1.oyuncuBeyaz == true)
            {
                base.Rnk.tasKontrolAsagiRenklendirme(oi, oj);
                base.Rnk.tasKontrolPiyonCaprazRenklendirme(oi, oj);
            }
            else if (taslar.Ad == "piyon_siyah" && Form1.oyuncuSiyah == true)
            {
                base.Rnk.tasKontrolPiyonCaprazRenklendirme(oi, oj);
                base.Rnk.tasKontrolYukariRenklendirme(oi, oj);
            }
            else
            {
                if (base._SonrakiHandler != null)
                {
                    base._SonrakiHandler.renklendirme(taslar, oi, oj, si, sj);
                   
                }
            }
        }
    }
}
