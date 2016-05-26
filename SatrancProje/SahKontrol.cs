using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrancProje
{
    class SahKontrol
    {
        public Boolean sahinkontrolü = true;
        public TasKontrol tasKontrol = new TasKontrol();
        public SahKontrol()
        {

        }
        public Boolean sahKontrolu(int sahkonumx,int sahkonumy,int si,int sj,int oi,int oj)
        {
            sahinkontrolü = true;
       
            Array.Copy(Form1.taslar, Form1.kopyataslar, 64);
            Form1.kopyataslar[si, sj] = Form1.kopyataslar[oi, oj];
            Form1.kopyataslar[oi, oj] = new Taslar(-1);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                        if (Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack != Form1.kopyataslar[i, j].İsBlack)
                        {

                            if (Form1.kopyataslar[i, j].Ad == "piyon_beyaz" || Form1.kopyataslar[i, j].Ad == "piyon_siyah")
                            {

                                if ((Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || (Math.Abs(sahkonumy - j) == 1 && Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 1)) &&
                                    (sahkonumy == j || (Math.Abs(sahkonumy - j) == 1 && Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 1)) &&
                                    Form1.kopyataslar[i, j].Ad == "piyon_beyaz" &&
                                    sahkonumx > i &&
                                    ((i == 1 && (sahkonumx - i == 1 || (sahkonumx - i == 2 && Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1))) || ((i != 1) && (sahkonumx - i == 1)))
                                    || (Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || (Math.Abs(sahkonumy - j) == 1 && Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 0)) &&
                                    (sahkonumy == j || (Math.Abs(sahkonumy - j) == 1 && Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 0)) &&
                                     Form1.kopyataslar[i, j].Ad == "piyon_siyah" &&
                                    i > sahkonumx &&
                                    ((i == 6 && (i - sahkonumx == 1 || (i - sahkonumx == 2 && Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1))) || ((i != 6) && (i - sahkonumx == 1))))

                                {

                                    sahinkontrolü = false;


                                }
                            }
                            else if (Form1.kopyataslar[i, j].Ad == "kale_beyaz" || Form1.kopyataslar[i, j].Ad == "kale_siyah")
                            {


                                if ((Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 0) && (sahkonumx == i || sahkonumy == j) &&
                                       (tasKontrol.sahtasKontrolSaga(i, j, sahkonumy) && tasKontrol.sahtasKontrolSola(i, j, sahkonumy)) && (tasKontrol.sahtasKontrolAsagi(i, j, sahkonumx) && tasKontrol.sahtasKontrolYukari(i, j, sahkonumx))
                                       || (Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 1) && (sahkonumx == i || sahkonumy == j) &&
                                       (tasKontrol.sahtasKontrolSaga(i, j, sahkonumy) && tasKontrol.sahtasKontrolSola(i, j, sahkonumy)) && (tasKontrol.sahtasKontrolAsagi(i, j, sahkonumx) && tasKontrol.sahtasKontrolYukari(i, j, sahkonumx)))

                                {

                                    sahinkontrolü = false;

                                }
                            }
                            else if (Form1.kopyataslar[i, j].Ad == "at_beyaz" || Form1.kopyataslar[i, j].Ad == "at_siyah")
                            {

                                if ((Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 0) &&
                                        ((i == sahkonumx + 2 && j == sahkonumy + 1) || (i == sahkonumx + 1 && j == sahkonumy + 2) || (i == sahkonumx - 1 && j == sahkonumy + 2) || (i == sahkonumx - 2 && j == sahkonumy + 1) ||
                                        (i == sahkonumx - 2 && j == sahkonumy - 1) || (i == sahkonumx - 1 && j == sahkonumy - 2) || (i == sahkonumx + 1 && j == sahkonumy - 2) || (i == sahkonumx + 2 && j == sahkonumy - 1)) ||
                                        (Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 1) &&
                                        ((i == sahkonumx + 2 && j == sahkonumy + 1) || (i == sahkonumx + 1 && j == sahkonumy + 2) || (i == sahkonumx - 1 && j == sahkonumy + 2) || (i == sahkonumx - 2 && j == sahkonumy + 1) ||
                                        (i == sahkonumx - 2 && j == sahkonumy - 1) || (i == sahkonumx - 1 && j == sahkonumy - 2) || (i == sahkonumx + 1 && j == sahkonumy - 2) || (i == sahkonumx + 2 && j == sahkonumy - 1))

                                        )
                                {
                                    sahinkontrolü = false;
                                }
                            }
                            else if (Form1.kopyataslar[i, j].Ad == "fil_beyaz" || Form1.kopyataslar[i, j].Ad == "fil_siyah")
                            {

                                if ((Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 0) && Math.Abs(sahkonumx - i) == Math.Abs(sahkonumy - j) &&
                                        (tasKontrol.sahtasKontrolAsagiSag(i, j, sahkonumx, sahkonumy) && tasKontrol.sahtasKontrolUstSol(i, j, sahkonumx, sahkonumy) && (tasKontrol.sahtasKontrolAsagiSol(i, j, sahkonumx, sahkonumy) && tasKontrol.sahtasKontrolYukariSag(i, j, sahkonumx, sahkonumy)))
                                         || (Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 1) && Math.Abs(sahkonumx - i) == Math.Abs(sahkonumy - j) &&
                                        (tasKontrol.sahtasKontrolAsagiSag(i, j, sahkonumx, sahkonumy) && tasKontrol.sahtasKontrolUstSol(i, j, sahkonumx, sahkonumy) && (tasKontrol.sahtasKontrolAsagiSol(i, j, sahkonumx, sahkonumy) && tasKontrol.sahtasKontrolYukariSag(i, j, sahkonumx, sahkonumy)))
                                        )
                                {
                                    sahinkontrolü = false;
                                }

                            }
                            else if (Form1.kopyataslar[i, j].Ad == "vezir_beyaz" || Form1.kopyataslar[i, j].Ad == "vezir_siyah")
                            {

                                if ((Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 0) && (sahkonumx == i || sahkonumy == j) &&
                                       (tasKontrol.sahtasKontrolSaga(i, j, sahkonumy) && tasKontrol.sahtasKontrolSola(i, j, sahkonumy)) && (tasKontrol.sahtasKontrolAsagi(i, j, sahkonumx) && tasKontrol.sahtasKontrolYukari(i, j, sahkonumx))
                                       || (Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 1) && (sahkonumx == i || sahkonumy == j) &&
                                       (tasKontrol.sahtasKontrolSaga(i, j, sahkonumy) && tasKontrol.sahtasKontrolSola(i, j, sahkonumy)) && (tasKontrol.sahtasKontrolAsagi(i, j, sahkonumx) && tasKontrol.sahtasKontrolYukari(i, j, sahkonumx))
                                       || (Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 0) && Math.Abs(sahkonumx - i) == Math.Abs(sahkonumy - j) &&
                                        (tasKontrol.sahtasKontrolAsagiSag(i, j, sahkonumx, sahkonumy) && tasKontrol.sahtasKontrolUstSol(i, j, sahkonumx, sahkonumy) && (tasKontrol.sahtasKontrolAsagiSol(i, j, sahkonumx, sahkonumy) && tasKontrol.sahtasKontrolYukariSag(i, j, sahkonumx, sahkonumy)))
                                         || (Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == -1 || Form1.kopyataslar[sahkonumx, sahkonumy].İsBlack == 1) && Math.Abs(sahkonumx - i) == Math.Abs(sahkonumy - j) &&
                                        (tasKontrol.sahtasKontrolAsagiSag(i, j, sahkonumx, sahkonumy) && tasKontrol.sahtasKontrolUstSol(i, j, sahkonumx, sahkonumy) && (tasKontrol.sahtasKontrolAsagiSol(i, j, sahkonumx, sahkonumy) && tasKontrol.sahtasKontrolYukariSag(i, j, sahkonumx, sahkonumy)))
                                        )

                                {
                                    sahinkontrolü = false;

                                }
                            }
                        }
                    }
            }

            if (sahinkontrolü == false && Form1.taslar[oi, oj].Ad != "sah_beyaz" && Form1.taslar[oi, oj].Ad != "sah_siyah")
            {

                MessageBox.Show("bu hamleyi yapamassınız");

            }
            return sahinkontrolü;
        }

    }
}
