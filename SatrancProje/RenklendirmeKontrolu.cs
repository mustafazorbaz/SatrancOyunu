using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrancProje
{
    class RenklendirmeKontrolu
    {
        public void tasKonrolAtRenklendirme(int oi, int oj, int si, int sj)
        {


            if (Form1.taslar[oi, oj].Ad == "at_beyaz")
            {
                if (oi + 2 >= 0 && oi + 2 <= 7 && oj + 1 >= 0 && oj + 1 <= 7 && Form1.taslar[oi + 2, oj + 1].İsBlack != 0)
                {
                   
                    renkKoyulastir(oi + 2, oj + 1);
                }

                if (oi + 1 >= 0 && oi + 1 <= 7 && oj + 2 >= 0 && oj + 2 <= 7 && Form1.taslar[oi + 1, oj + 2].İsBlack != 0)
                {
                   
                    renkKoyulastir(oi + 1, oj +2);
                }

                if (oi - 1 >= 0 && oi - 1 <= 7 && oj + 2 >= 0 && oj + 2 <= 7 && Form1.taslar[oi - 1, oj + 2].İsBlack != 0)
                {
                   
                    renkKoyulastir(oi -1, oj +2);
                }

                if (oi - 2 >= 0 && oi - 2 <= 7 && oj + 1 >= 0 && oj + 1 <= 7 && Form1.taslar[oi - 2, oj + 1].İsBlack != 0)
                {
                   
                    renkKoyulastir(oi - 2, oj + 1);
                }

                if (oi - 2 >= 0 && oi - 2 <= 7 && oj - 1 >= 0 && oj - 1 <= 7 && Form1.taslar[oi - 2, oj - 1].İsBlack != 0)
                {
                    
                    renkKoyulastir(oi - 2, oj - 1);
                }

                if (oi - 1 >= 0 && oi - 1 <= 7 && oj - 2 >= 0 && oj - 2 <= 7 && Form1.taslar[oi - 1, oj - 2].İsBlack != 0)
                {
                    
                    renkKoyulastir(oi -1, oj - 2);
                }

                if (oi + 1 >= 0 && oi + 1 <= 7 && oj - 2 >= 0 && oj - 2 <= 7 && Form1.taslar[oi + 1, oj - 2].İsBlack != 0)
                {
                  
                    renkKoyulastir(oi +1, oj - 2);
                }

                if (oi + 2 >= 0 && oi + 2 <= 7 && oj - 1 >= 0 && oj - 1 <= 7 && Form1.taslar[oi + 2, oj - 1].İsBlack != 0)
                {
                    
                    renkKoyulastir(oi + 2, oj - 1);
                }
            }
            if (Form1.taslar[oi, oj].Ad == "at_siyah")
            {
                if (oi + 2 >= 0 && oi + 2 <= 7 && oj + 1 >= 0 && oj + 1 <= 7 && Form1.taslar[oi + 2, oj + 1].İsBlack != 1)
                {
                    renkKoyulastir(oi + 2, oj + 1);
                }

                if (oi + 1 >= 0 && oi + 1 <= 7 && oj + 2 >= 0 && oj + 2 <= 7 && Form1.taslar[oi + 1, oj + 2].İsBlack != 1)
                {
                  
                    renkKoyulastir(oi + 1, oj+2);
                }

                if (oi - 1 >= 0 && oi - 1 <= 7 && oj + 2 >= 0 && oj + 2 <= 7 && Form1.taslar[oi - 1, oj + 2].İsBlack != 1)
                {
                  
                    renkKoyulastir(oi -1, oj +2);
                }

                if (oi - 2 >= 0 && oi - 2 <= 7 && oj + 1 >= 0 && oj + 1 <= 7 && Form1.taslar[oi - 2, oj + 1].İsBlack != 1)
                {
                  
                    renkKoyulastir(oi- 2, oj + 1);
                }

                if (oi - 2 >= 0 && oi - 2 <= 7 && oj - 1 >= 0 && oj - 1 <= 7 && Form1.taslar[oi - 2, oj - 1].İsBlack != 1)
                {
                  
                    renkKoyulastir(oi - 2, oj - 1);
                }

                if (oi - 1 >= 0 && oi - 1 <= 7 && oj - 2 >= 0 && oj - 2 <= 7 && Form1.taslar[oi - 1, oj - 2].İsBlack != 1)
                {
                   
                    renkKoyulastir(oi-1, oj - 2);
                }

                if (oi + 1 >= 0 && oi + 1 <= 7 && oj - 2 >= 0 && oj - 2 <= 7 && Form1.taslar[oi + 1, oj - 2].İsBlack != 1)
                {
                   
                    renkKoyulastir(oi +1, oj - 2);
                }

                if (oi + 2 >= 0 && oi + 2 <= 7 && oj - 1 >= 0 && oj - 1 <= 7 && Form1.taslar[oi + 2, oj - 1].İsBlack != 1)
                {
                 
                    renkKoyulastir(oi + 2, oj - 1);

                }

            }





        }
        public void tasKontrolAsagiRenklendirme(int oi, int oj)
        {
            int yolKisitlamasi = 0, kendiTasim = -1;
            if (Form1.taslar[oi, oj].Ad == "piyon_beyaz" && oi == 1 && Form1.taslar[oi + 2, oj].İsBlack == -1)
            {
                yolKisitlamasi = 2;
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "piyon_beyaz")
            {
                yolKisitlamasi = 1;
                kendiTasim = 0;
            }
            else if ((Form1.taslar[oi, oj].Ad == "kale_beyaz" || Form1.taslar[oi, oj].Ad == "vezir_beyaz") && (oi != 7))
            {
                yolKisitlamasi = 7;
                kendiTasim = 0;

            }
            else if ((Form1.taslar[oi, oj].Ad == "kale_siyah" || Form1.taslar[oi, oj].Ad == "vezir_siyah") && (oi != 7))
            {
                yolKisitlamasi = 7;
                kendiTasim = 1;

            }
            else if (Form1.taslar[oi, oj].Ad == "sah_beyaz")
            {
                yolKisitlamasi = 1;
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_siyah")
            {
                yolKisitlamasi = 1;
                kendiTasim = 1;

            }

            int i = oi + 1;
            int sayac = 0;
            while (sayac < yolKisitlamasi)
            {
                // MessageBox.Show("i "+ i+"oi :"+oi);

                if (i <= -1 || i >= 8)
                    break;



                if (Form1.taslar[i, oj].İsBlack == kendiTasim)
                {

                    break;
                }
                if (Form1.taslar[oi, oj].Ad == "piyon_beyaz" && Form1.taslar[oi + 1, oj].İsBlack != -1)
                {

                }
                else
                    renkKoyulastir(i, oj);

                if (Form1.taslar[i, oj].İsBlack == Math.Abs(kendiTasim - 1)) //kendi taşı ise renklendirme sonlanır
                    break;


                i++;
                sayac++;


            }
        }
        public void tasKontrolYukariRenklendirme(int oi, int oj)
        {
            int yolKisitlamasi = 0, kendiTasim = -1;
            int i = oi - 1;

            if (Form1.taslar[oi, oj].Ad == "piyon_beyaz" && oi == 1)
            {
                yolKisitlamasi = 2;
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "piyon_beyaz")
            {
                yolKisitlamasi = 1;
                kendiTasim = 0;
            }
            if (Form1.taslar[oi, oj].Ad == "piyon_siyah" && oi == 6 && Form1.taslar[oi - 2, oj].İsBlack == -1)
            {
                yolKisitlamasi = 2;
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "piyon_siyah")
            {
                yolKisitlamasi = 1;
                kendiTasim = 1;
            }
            else if ((Form1.taslar[oi, oj].Ad == "kale_beyaz" || Form1.taslar[oi, oj].Ad == "vezir_beyaz"))
            {
                yolKisitlamasi = 7;
                kendiTasim = 0;

            }
            else if ((Form1.taslar[oi, oj].Ad == "kale_siyah" || Form1.taslar[oi, oj].Ad == "vezir_siyah"))
            {
                yolKisitlamasi = 7;
                kendiTasim = 1;

            }
            else if (Form1.taslar[oi, oj].Ad == "sah_beyaz")
            {
                yolKisitlamasi = 1;
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_siyah")
            {
                yolKisitlamasi = 1;
                kendiTasim = 1;

            }

            int sayac = 0;

            while (sayac < yolKisitlamasi)
            {
                if (i <= -1 || i >= 8)
                    break;



                if (Form1.taslar[i, oj].İsBlack == kendiTasim)
                {

                    break;
                }
                if (Form1.taslar[oi, oj].Ad == "piyon_siyah" && Form1.taslar[oi - 1, oj].İsBlack != -1)
                {

                }
                else
                    renkKoyulastir(i, oj);

                if (Form1.taslar[i, oj].İsBlack == Math.Abs(kendiTasim - 1))
                    break;

                i--;
                sayac++;


            }




        }
        public void tasKontrolSagaRenklendirme(int oi, int oj)
        {
            int yolKisitlamasi = 0, sayac = 0, kendiTasim = -1;

            if (Form1.taslar[oi, oj].Ad == "kale_beyaz")
            {
                yolKisitlamasi = 7;
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "kale_siyah")
            {
                yolKisitlamasi = 7;
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "vezir_beyaz")
            {
                yolKisitlamasi = 7;
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "vezir_siyah")
            {
                yolKisitlamasi = 7;
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_beyaz")
            {
                yolKisitlamasi = 1;
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_siyah")
            {
                yolKisitlamasi = 1;
                kendiTasim = 1;
            }


            int j = oj + 1;
            while (sayac < yolKisitlamasi)
            {

                if (j <= -1 || j >= 8)
                    break;


                if (Form1.taslar[oi, j].İsBlack == kendiTasim)
                {

                    break;
                }
                renkKoyulastir(oi, j);

                if (Form1.taslar[oi, j].İsBlack == Math.Abs(kendiTasim - 1))
                    break;

                j++;
                sayac++;
                // MessageBox.Show("j " + j + "oi :" + Math.Abs(-oi));
            }

        }
        public void tasKontrolSolaRenklendirme(int oi, int oj)
        {
            int yolKisitlamasi = 0, sayac = 0, kendiTasim = -1;

            if (Form1.taslar[oi, oj].Ad == "kale_beyaz")
            {
                yolKisitlamasi = 7;
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "kale_siyah")
            {
                yolKisitlamasi = 7;
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "vezir_beyaz")
            {
                yolKisitlamasi = 7;
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "vezir_siyah")
            {
                yolKisitlamasi = 7;
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_beyaz")
            {
                yolKisitlamasi = 1;
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_siyah")
            {
                yolKisitlamasi = 1;
                kendiTasim = 1;
            }


            int j = oj - 1;
            while (sayac < yolKisitlamasi)
            {

                if (j <= -1 || j >= 8)
                    break;

                if (Form1.taslar[oi, j].İsBlack == kendiTasim)
                {

                    break;
                }
                renkKoyulastir(oi, j);

                if (Form1.taslar[oi, j].İsBlack == Math.Abs(kendiTasim - 1))
                    break;
                j--;
                sayac++;
                // MessageBox.Show("j " + j + "oi :" + oi);
            }

        }
        public void tasKontrolAsagiSagRenklendirme(int oi, int oj)
        {
            int yolKisitlamasi = 7, sayac = 0, kendiTasim = -1;

            if (Form1.taslar[oi, oj].Ad == "fil_beyaz" || Form1.taslar[oi, oj].Ad == "vezir_beyaz")
            {
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "fil_siyah" || Form1.taslar[oi, oj].Ad == "vezir_siyah")
            {
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_siyah")
            {
                yolKisitlamasi = 1;
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_beyaz")
            {
                yolKisitlamasi = 1;
                kendiTasim = 0;
            }



            int j = oj + 1;
            int i = oi + 1;
            while (sayac < yolKisitlamasi)
            {

                if (j == -1 || j == 8 || i == -1 || i == 8)
                    break;

                if (Form1.taslar[i, j].İsBlack == kendiTasim)
                {

                    break;
                }
                renkKoyulastir(i, j);
                if (Form1.taslar[i, j].İsBlack == Math.Abs(kendiTasim - 1))
                    break;

                j++;
                i++;
                sayac++;
                // MessageBox.Show("j " + j + "oi :" + oi);
            }
        }
        public void tasKontrolUstSolRenklendirme(int oi, int oj)
        {
            int yolKisitlamasi = 7, sayac = 0, kendiTasim = -1;
            if (Form1.taslar[oi, oj].Ad == "fil_beyaz" || Form1.taslar[oi, oj].Ad == "vezir_beyaz")
            {
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "fil_siyah" || Form1.taslar[oi, oj].Ad == "vezir_siyah")
            {
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_siyah")
            {
                yolKisitlamasi = 1;
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_beyaz")
            {
                yolKisitlamasi = 1;
                kendiTasim = 0;
            }



            int j = oj - 1;
            int i = oi - 1;
            while (sayac < yolKisitlamasi)
            {

                if (j == -1 || j == 8 || i == -1 || i == 8)
                    break;

                if (Form1.taslar[i, j].İsBlack == kendiTasim)
                {

                    break;
                }
                renkKoyulastir(i, j);
                if (Form1.taslar[i, j].İsBlack == Math.Abs(kendiTasim - 1))
                    break;

                j--;
                i--;
                sayac++;
                // MessageBox.Show("j " + j + "oi :" + oi);
            }
        }
        public void tasKontrolAsagiSolRenklendirme(int oi, int oj)
        {
            int yolKisitlamasi = 7, sayac = 0, kendiTasim = -1; //Yol kısıtlaması 7 olmasının sebebi ise max  8 gidebilir olmasıdır.
            if (Form1.taslar[oi, oj].Ad == "fil_beyaz" || Form1.taslar[oi, oj].Ad == "vezir_beyaz")
            {
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "fil_siyah" || Form1.taslar[oi, oj].Ad == "vezir_siyah")
            {
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_siyah")
            {
                yolKisitlamasi = 1;
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_beyaz")
            {
                yolKisitlamasi = 1;
                kendiTasim = 0;
            }


            int i = oi + 1;
            int j = oj - 1;
            while (sayac < yolKisitlamasi)
            {

                if (j == -1 || j == 8 || i == -1 || i == 8)
                    break;

                if (Form1.taslar[i, j].İsBlack == kendiTasim)
                {


                    break;
                }
                renkKoyulastir(i,j);
                if (Form1.taslar[i, j].İsBlack == Math.Abs(kendiTasim - 1))
                    break;

                j--;
                i++;
                sayac++;

            }
        }
        public void tasKontrolYukariSagRenklendirme(int oi, int oj)
        {
            int yolKisitlamasi = 7, sayac = 0, kendiTasim = -1; //Yol kısıtlaması 7 olmasının sebebi ise max  8 gidebilir olmasıdır.

            if (Form1.taslar[oi, oj].Ad == "fil_beyaz" || Form1.taslar[oi, oj].Ad == "vezir_beyaz")
            {
                kendiTasim = 0;
            }
            else if (Form1.taslar[oi, oj].Ad == "fil_siyah" || Form1.taslar[oi, oj].Ad == "vezir_siyah")
            {
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_siyah")
            {
                yolKisitlamasi = 1;
                kendiTasim = 1;
            }
            else if (Form1.taslar[oi, oj].Ad == "sah_beyaz")
            {
                yolKisitlamasi = 1;
                kendiTasim = 0;
            }


            int i = oi - 1;
            int j = oj + 1;
            while (sayac < yolKisitlamasi)
            {

                if (j == -1 || j == 8 || i == -1 || i == 8)
                    break;

                if (Form1.taslar[i, j].İsBlack == kendiTasim)
                {

                    break;
                }
                renkKoyulastir(i, j);
                if (Form1.taslar[i, j].İsBlack == Math.Abs(kendiTasim - 1))
                    break;

                j++;
                i--;
                sayac++;

            }
        }
        public void tasKontrolPiyonCaprazRenklendirme(int oi, int oj)
        {
            if (oi + 1 <= 7 && oj + 1 <= 7)
            {
                if (Form1.taslar[oi, oj].Ad == "piyon_beyaz" && Form1.taslar[oi + 1, oj + 1].İsBlack == 1)
                {
                    renkKoyulastir(oi +1, oj + 1);

                }
            }
            if (oj - 1 >= 0 && oi + 1 <= 7)
            {

                if (Form1.taslar[oi, oj].Ad == "piyon_beyaz" && Form1.taslar[oi + 1, oj - 1].İsBlack == 1)
                {

                    renkKoyulastir(oi +1, oj - 1);
                }
            }

            if (oi - 1 >= 0 && oj - 1 >= 0)
            {
                if (Form1.taslar[oi, oj].Ad == "piyon_siyah" && Form1.taslar[oi - 1, oj - 1].İsBlack == 0)
                {

                    renkKoyulastir(oi - 1, oj - 1);

                }
            }
            if (oj + 1 <= 7 && oi - 1 >= 0)
            {
                if (Form1.taslar[oi, oj].Ad == "piyon_siyah" && Form1.taslar[oi - 1, oj + 1].İsBlack == 0)
                {

                    
                    renkKoyulastir(oi - 1, oj + 1);
                }
            }

        }
          public void renkKoyulastir(int si, int sj)
        {
            Color renk = Form1.kareler[si, sj].BackColor;
            Color lightRed = ControlPaint.LightLight(renk);
            Form1.kareler[si, sj].BackColor = lightRed;
        }
    }
}
