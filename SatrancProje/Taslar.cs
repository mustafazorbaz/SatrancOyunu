using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SatrancProje
{

   public   class Taslar:PictureBox
    {
        Form1 frm = new Form1();
        PictureBox d_img;  
        int isBlack;
        private  string ad;
       static RenklendirmeKontrolu rnk = new RenklendirmeKontrolu();
        public Taslar(int isBlack,string ad)//0 beyaz 1 siyah
        {
            
            this.isBlack = isBlack;
            this.Ad = ad;
        }
        public Taslar(float isBlack)
        {
            this.isBlack = Convert.ToInt16(isBlack);
        }
        public Taslar()
        {

            d_img = new PictureBox(); 
        }
        public PictureBox D_img    
        {
            get
            {
                return d_img;
            }

            set
            {
                d_img = value;
            }
        }

        public int İsBlack
        {
            get
            {
                return isBlack;
            }

            set
            {
                isBlack = value;
            }
        }

        public string Ad
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
      
            protected Taslar _SonrakiHandler;
            public Taslar SonrakiHandler { set { _SonrakiHandler = value; } }

        internal RenklendirmeKontrolu Rnk
        {
            get
            {
                return rnk;
            }

            set
            {
                rnk = value;
            }
        }

        public virtual void renklendirme(Taslar taslar,int oi,int oj, int si, int sj)

        {

        }

    }
}
