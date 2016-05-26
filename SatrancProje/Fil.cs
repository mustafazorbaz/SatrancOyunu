using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace SatrancProje
{
    class Fil:Taslar
    {
        private string ad;

        public Fil()
        {
        }

        public Fil(int isBlack, string ad) : base(isBlack, ad)
        {
            this.Ad1 = ad;
            PictureBox img = new PictureBox();
            if (isBlack==1)
            {
                img.BackgroundImage = SatrancProje.Properties.Resources.fil2;
            }
            else if(isBlack==0)
            {
                img.BackgroundImage = SatrancProje.Properties.Resources.fil;
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

            if (taslar.Ad == "fil_beyaz" && Form1.oyuncuBeyaz == true || taslar.Ad == "fil_siyah" && Form1.oyuncuSiyah == true)
            {

                base.Rnk.tasKontrolAsagiSagRenklendirme(oi, oj);
                base.Rnk.tasKontrolUstSolRenklendirme(oi, oj);
                base.Rnk.tasKontrolAsagiSolRenklendirme(oi, oj);
                base.Rnk.tasKontrolYukariSagRenklendirme(oi, oj); 
            }
            else
            {

                if (base._SonrakiHandler != null)
                    base._SonrakiHandler.renklendirme(taslar, oi, oj, si, sj);
            }
        }
    }
}
