using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace SatrancProje
{
    public partial class Form1 : Form
    {
        SahKontrol s = new SahKontrol();
        TasKontrol tasKontrol = new TasKontrol();
        public static Taslar[,] taslar = new Taslar[8, 8];
        public static Taslar[,] kopyataslar = new Taslar[8, 8];
        public static PictureBox[,] kareler = new PictureBox[8, 8];
        public PictureBox onceki_secilen = null, secilen = null;
        public PictureBox nesne = new PictureBox();
        public Taslar tasTut;
        public int siyahsahkonumx = 7, siyahsahkonumy = 3, beyazsahkonumx = 0, beyazsahkonumy = 3, sahtesiyahsahkonumx = 7, sahtesiyahsahkonumy = 3, sahtebeyazsahkonumx = 0, sahtebeyazsahkonumy = 3;
        public String comboboxsecim = "";
        public Boolean sahinkontrolü = true;
        public Boolean kaleSiyahSol = true, kaleSiyahSag = true, kaleBeyazSol = true, kaleBeyazSag = true, sahBeyaz = true, sahSiyah = true;
        public String nameOnceki, nameSecilen, gerinameOnceki, gerinameSecilen;
        public String name;
        Boolean sahinyenmekontrolu = true, rok_yapildi = false;
        int sayac = 0;
        int si = 1;
        int sj = 1;
        int oj = 1;
        int oi = 1;
        int hangirok;
        int puanBeyaz = 0, puanSiyah = 0;
        int yendi;
       public static  Boolean oyuncuBeyaz = true, oyuncuSiyah = false;
      

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
            int x = 0, y = 0;
            int ik = 0, jk = 0, xk = 0, yk = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    TahtaOlusturSingleton.Tahta(i, j, x, y);
                  
                    kareler[i, j].Click += new EventHandler(f_tiklandi);
                    kareler[i, j].MouseDown += new MouseEventHandler(renklendirme);
                    y += 80;
                    this.panel1.Controls.Add(kareler[i, j]);
                }
                y = 0;
                x += 80;
            }

            f_tas_koy();

            for (int i = 0; i < kareler.GetLength(0); i++)
            {
                for (int j = 0; j < kareler.GetLength(1); j++)
                {
                    if (taslar[i, j].İsBlack != -1)
                        kareler[i, j].BackgroundImage = taslar[i, j].D_img.BackgroundImage;
                }
            }
        }
        void f_tas_koy()
        {
            Facade f = new Facade();
        }

        void f_tiklandi(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            onceki_secilen = secilen;
            secilen = pb;



            if (onceki_secilen != null)
            {
                nameOnceki = Convert.ToString(onceki_secilen.Name);
                nameSecilen = Convert.ToString(secilen.Name);
                name = pb.Name.ToString();
                si = Convert.ToInt16(name.Substring(1, 1));
                sj = Convert.ToInt16(name.Substring(2, 1));

                name = onceki_secilen.Name.ToString();
                oi = Convert.ToInt16(name.Substring(1, 1));
                oj = Convert.ToInt16(name.Substring(2, 1));

                yendi = taslar[si, sj].İsBlack;



                if (secilen != onceki_secilen)
                {
                    if (onceki_secilen.BackgroundImage != null)
                    {
                        if (taslar[si, sj].İsBlack != taslar[oi, oj].İsBlack)
                        {
                            sahinyenmekontrolu = true;
                        
                              if (taslar[oi, oj].İsBlack == 0)
          {
 sahinyenmekontrolu = s.sahKontrolu(beyazsahkonumx, beyazsahkonumy, si, sj, oi, oj);

          }
          else
          {
              sahinyenmekontrolu = s.sahKontrolu(siyahsahkonumx, siyahsahkonumy, si, sj, oi, oj);
          }

                            if ((taslar[oi, oj].Ad == "piyon_beyaz" || taslar[oi, oj].Ad == "piyon_siyah") && sahinyenmekontrolu)
                            {
                                if ((taslar[si, sj].İsBlack == -1 || (Math.Abs(sj - oj) == 1 && taslar[si, sj].İsBlack == 1)) &&
                                    (sj == oj || (Math.Abs(sj - oj) == 1 && taslar[si, sj].İsBlack == 1)) &&
                                    taslar[oi, oj].Ad == "piyon_beyaz" &&
                                    si > oi &&
                                    ((oi == 1 && (si - oi == 1 || (si - oi == 2 && taslar[si, sj].İsBlack == -1))) || ((oi != 1) && (si - oi == 1)))
                                    || (taslar[si, sj].İsBlack == -1 || (Math.Abs(sj - oj) == 1 && taslar[si, sj].İsBlack == 0)) &&
                                    (sj == oj || (Math.Abs(sj - oj) == 1 && taslar[si, sj].İsBlack == 0)) &&
                                     taslar[oi, oj].Ad == "piyon_siyah" &&
                                    oi > si &&
                                    ((oi == 6 && (oi - si == 1 || (oi - si == 2 && taslar[si, sj].İsBlack == -1))) || ((oi != 6) && (oi - si == 1))))

                                {

                                    if ((taslar[oi, oj].Ad == "piyon_beyaz" && oyuncuBeyaz == true) || (taslar[oi, oj].Ad == "piyon_siyah" && oyuncuSiyah == true) )
                                    {
                                        hareketEt();
                                      
                                    }
                                  
                                    if (si==7 || si==0)
                                        {
                                            PiyonSec pyn = new PiyonSec(taslar[si,sj],si,sj);
                                            pyn.ShowDialog();
                                    }


                                }
                            }
                            else if ((taslar[oi, oj].Ad == "kale_beyaz" || taslar[oi, oj].Ad == "kale_siyah") && sahinyenmekontrolu)
                            {

                                if ((taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 0) && (si == oi || sj == oj) &&
                                   (tasKontrol.tasKontrolSaga(oi, oj, sj) && tasKontrol.tasKontrolSola(oi, oj, sj)) && (tasKontrol.tasKontrolAsagi(oi, oj, si) && tasKontrol.tasKontrolYukari(oi, oj, si))
                                   || (taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 1) && (si == oi || sj == oj) &&
                                   (tasKontrol.tasKontrolSaga(oi, oj, sj) && tasKontrol.tasKontrolSola(oi, oj, sj)) && (tasKontrol.tasKontrolAsagi(oi, oj, si) && tasKontrol.tasKontrolYukari(oi, oj, si)))

                                {
                                    if (taslar[oi, oj].Ad == "kale_siyah" && oi == 7 && oj == 7)
                                    {
                                        kaleSiyahSag = false;
                                        
                                    }
                                  
                                      
                                    if (taslar[oi, oj].Ad == "kale_siyah" && oi == 7 && oj == 0)
                                    {
                                        kaleSiyahSol = false;
                                    }
                                    
                                    if (taslar[oi, oj].Ad == "kale_beyaz" && oi == 0 && oj == 0)
                                    {
                                        kaleBeyazSol = false;
                                    }
                                    
                                    if (taslar[oi, oj].Ad == "kale_beyaz" && oi == 0 && oj == 7)
                                    {
                                        kaleBeyazSag = false;
                                    }
                                    if (kaleSiyahSol==false&&kaleSiyahSag==false)                                 {
                                        button3.Enabled = false;
                                    }
                                    if (kaleBeyazSol == false && kaleBeyazSag == false)
                                    {
                                        button2.Enabled = false;
                                    }
                                    if ((taslar[oi, oj].Ad == "kale_beyaz" && oyuncuBeyaz == true) || (taslar[oi, oj].Ad == "kale_siyah" && oyuncuSiyah == true))
                                    {
                                        hareketEt();
                                    }

                                }
                            }
                            else if ((taslar[oi, oj].Ad == "at_beyaz" || taslar[oi, oj].Ad == "at_siyah") && sahinyenmekontrolu)
                            {
                                if ((taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 0) &&
                                    ((oi == si + 2 && oj == sj + 1) || (oi == si + 1 && oj == sj + 2) || (oi == si - 1 && oj == sj + 2) || (oi == si - 2 && oj == sj + 1) ||
                                    (oi == si - 2 && oj == sj - 1) || (oi == si - 1 && oj == sj - 2) || (oi == si + 1 && oj == sj - 2) || (oi == si + 2 && oj == sj - 1)) ||
                                    (taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 1) &&
                                    ((oi == si + 2 && oj == sj + 1) || (oi == si + 1 && oj == sj + 2) || (oi == si - 1 && oj == sj + 2) || (oi == si - 2 && oj == sj + 1) ||
                                    (oi == si - 2 && oj == sj - 1) || (oi == si - 1 && oj == sj - 2) || (oi == si + 1 && oj == sj - 2) || (oi == si + 2 && oj == sj - 1))

                                    )
                                {
                                    if ((taslar[oi, oj].Ad == "at_beyaz" && oyuncuBeyaz == true) || (taslar[oi, oj].Ad == "at_siyah" && oyuncuSiyah == true))
                                    {

                                        hareketEt();
                                    }
                                }
                            }
                            else if ((taslar[oi, oj].Ad == "fil_beyaz" || taslar[oi, oj].Ad == "fil_siyah") && sahinyenmekontrolu)
                            {
                                if ((taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 0) && Math.Abs(si - oi) == Math.Abs(sj - oj) &&
                                    (tasKontrol.tasKontrolAsagiSag(oi, oj, si, sj) && tasKontrol.tasKontrolUstSol(oi, oj, si, sj) && (tasKontrol.tasKontrolAsagiSol(oi, oj, si, sj) && tasKontrol.tasKontrolYukariSag(oi, oj, si, sj)))
                                     || (taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 1) && Math.Abs(si - oi) == Math.Abs(sj - oj) &&
                                    (tasKontrol.tasKontrolAsagiSag(oi, oj, si, sj) && tasKontrol.tasKontrolUstSol(oi, oj, si, sj) && (tasKontrol.tasKontrolAsagiSol(oi, oj, si, sj) && tasKontrol.tasKontrolYukariSag(oi, oj, si, sj)))
                                    )
                                {

                                    if ((taslar[oi, oj].Ad == "fil_beyaz" && oyuncuBeyaz == true) || (taslar[oi, oj].Ad == "fil_siyah" && oyuncuSiyah == true))
                                    {

                                        hareketEt();
                                    }
                                }

                            }
                            else if ((taslar[oi, oj].Ad == "vezir_beyaz" || taslar[oi, oj].Ad == "vezir_siyah") && sahinyenmekontrolu)
                            {
                                if ((taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 0) && (si == oi || sj == oj) &&
                                   (tasKontrol.tasKontrolSaga(oi, oj, sj) && tasKontrol.tasKontrolSola(oi, oj, sj)) && (tasKontrol.tasKontrolAsagi(oi, oj, si) && tasKontrol.tasKontrolYukari(oi, oj, si))
                                   || (taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 1) && (si == oi || sj == oj) &&
                                   (tasKontrol.tasKontrolSaga(oi, oj, sj) && tasKontrol.tasKontrolSola(oi, oj, sj)) && (tasKontrol.tasKontrolAsagi(oi, oj, si) && tasKontrol.tasKontrolYukari(oi, oj, si))
                                   || (taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 0) && Math.Abs(si - oi) == Math.Abs(sj - oj) &&
                                    (tasKontrol.tasKontrolAsagiSag(oi, oj, si, sj) && tasKontrol.tasKontrolUstSol(oi, oj, si, sj) && (tasKontrol.tasKontrolAsagiSol(oi, oj, si, sj) && tasKontrol.tasKontrolYukariSag(oi, oj, si, sj)))
                                     || (taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 1) && Math.Abs(si - oi) == Math.Abs(sj - oj) &&
                                    (tasKontrol.tasKontrolAsagiSag(oi, oj, si, sj) && tasKontrol.tasKontrolUstSol(oi, oj, si, sj) && (tasKontrol.tasKontrolAsagiSol(oi, oj, si, sj) && tasKontrol.tasKontrolYukariSag(oi, oj, si, sj)))
                                    )

                                {
                                    if ((taslar[oi, oj].Ad == "vezir_beyaz" && oyuncuBeyaz == true) || (taslar[oi, oj].Ad == "vezir_siyah" && oyuncuSiyah == true))
                                    {
                                        hareketEt();

                                    }

                                }
                            }
                            else if (taslar[oi, oj].Ad == "sah_beyaz" || taslar[oi, oj].Ad == "sah_siyah")
                            {
                                if ((taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 1) &&
                                   (Math.Abs(si - oi) == 1 && Math.Abs(oj - sj) == 1) || (oi == si && Math.Abs(oj - sj) == 1) || (oj == sj && Math.Abs(si - oi) == 1)
                                   || (taslar[si, sj].İsBlack == -1 || taslar[si, sj].İsBlack == 0) &&
                                   (Math.Abs(si - oi) == 1 && Math.Abs(oj - sj) == 1) || (oi == si && Math.Abs(oj - sj) == 1) || (oj == sj && Math.Abs(si - oi) == 1))
                                {
                                    if (taslar[oi, oj].Ad == "sah_beyaz" && oi == 0 && oj == 3)
                                    {
                                        sahBeyaz = false;
                                        button2.Enabled = false;
                                    }
                                        
                                    if (taslar[oi, oj].Ad == "sah_siyah" && oi == 7 && oj == 3)
                                    {
                                        sahSiyah = false;
                                        button3.Enabled = false;
                                    }
                                    if ((taslar[oi, oj].Ad == "sah_beyaz" && oyuncuBeyaz == true) || (taslar[oi, oj].Ad == "sah_siyah" && oyuncuSiyah == true))
                                    {
                                        hareketEt();  
                                    }
                                    if (taslar[si, sj].Ad == "sah_siyah")
                                    {
                                        siyahsahkonumx = si;
                                        siyahsahkonumy = sj;
                                    }
                                    if (taslar[si, sj].Ad == "sah_beyaz")
                                    {
                                        beyazsahkonumx = si;
                                        beyazsahkonumy = sj;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        void matKontrol()
        {
            if (taslar[si, sj].Ad == "sah_siyah")
            {
                MessageBox.Show("Beyaz oyuncu kazandı");
                this.Close();
            }
            else if(taslar[si, sj].Ad == "sah_beyaz")
            {
                MessageBox.Show("Siyah oyuncu kazandı");
                this.Close();
            }
            
        }
        



       
        public void puanHesapla(int oi, int oj, int si, int sj)
        {
            if (taslar[oi, oj].İsBlack == 0)
            {

                if (taslar[si, sj].Ad == "piyon_siyah")
                    puanBeyaz += 1;
                else if (taslar[si, sj].Ad == "kale_siyah")
                    puanBeyaz += 5;
                else if (taslar[si, sj].Ad == "at_siyah")
                    puanBeyaz += 3;
                else if (taslar[si, sj].Ad == "at_siyah")
                    puanBeyaz += 3;
                else if (taslar[si, sj].Ad == "fil_siyah")
                    puanBeyaz += 3;
                else if (taslar[si, sj].Ad == "vezir_siyah")
                    puanBeyaz += 9;
            }


            if (taslar[oi, oj].İsBlack == 1)
            {

                if (taslar[si, sj].Ad == "piyon_beyaz")
                    puanSiyah += 1;
                else if (taslar[si, sj].Ad == "kale_beyaz")
                    puanSiyah += 5;
                else if (taslar[si, sj].Ad == "at_beyaz")
                    puanSiyah += 3;
                else if (taslar[si, sj].Ad == "at_beyaz")
                    puanSiyah += 3;
                else if (taslar[si, sj].Ad == "fil_beyaz")
                    puanSiyah += 3;
                else if (taslar[si, sj].Ad == "vezir_beyaz")
                    puanSiyah += 9;
            }


            labelBeyaz.Text = "PUAN BEYAZ :" + puanBeyaz;
            labelSiyah.Text = "PUAN SİYAH :" + puanSiyah;
        }
        public void oyuncuSirasi(int oi, int oj)
        {
          
            if (taslar[oi, oj].İsBlack == 0)
            {
              
                oyuncuBeyaz = false;
                oyuncuSiyah = true;
                label1.Text = "Sıra Siyah Oyuncuda";
            }
            else if (taslar[oi, oj].İsBlack == 1)
            {
               

                oyuncuSiyah = false;
                oyuncuBeyaz = true;
                label1.Text = "Sıra Beyaz Oyuncuda";
            }
        }
        private void geriAl(object sender, EventArgs e)
        {
            if (rok_yapildi)
            {
                button1.Enabled = false;
                rok_yapildi = false;
                sayac = 0;
                if (hangirok == 0)
                {
                    
                    sahSiyah = true;
                    sahSiyah = true;
                    if (taslar[7, 0].İsBlack == -1 && taslar[7, 3].İsBlack == -1)
                    {
                        ses();
                        siyahsahkonumx = 0;
                        siyahsahkonumy = 3;
                        rok(7, 2, 0, 1, 3);
                        button3.Enabled = true;
                    }
                    else if (taslar[7, 3].İsBlack == -1 && taslar[7, 6].İsBlack == -1 && taslar[7, 7].İsBlack == -1)
                    {
                        ses();
                        siyahsahkonumx = 0;
                        siyahsahkonumy = 3;
                        rok(7, 4, 7, 5, 3);
                        button3.Enabled = true;
                    }

                }
                else if (hangirok == 1)
                {
                    sahBeyaz = true;
                    sahBeyaz = true;
                    if (taslar[0, 0].İsBlack == -1 && taslar[0, 3].İsBlack == -1)
                    {
                        ses();
                        beyazsahkonumx = 7;
                        beyazsahkonumy = 3;
                        rok(0, 2, 0, 1, 3);
                        button2.Enabled = true;
                    }
                    else if (taslar[0, 3].İsBlack == -1 && taslar[0, 6].İsBlack == -1 && taslar[0, 7].İsBlack == -1)
                    {
                        ses();
                        beyazsahkonumx = 7;
                        beyazsahkonumy = 3;
                        rok(0, 4, 7, 5, 3);
                        button2.Enabled = true;
                    }

                }
            }
            else
            {
                rok_yapildi = false;
                sayac = 0;
                si = Convert.ToInt16(gerinameSecilen.Substring(1, 1));
                sj = Convert.ToInt16(gerinameSecilen.Substring(2, 1));
                oi = Convert.ToInt16(gerinameOnceki.Substring(1, 1));
                oj = Convert.ToInt16(gerinameOnceki.Substring(2, 1));
                onceki_secilen = kareler[si, sj];
                secilen = kareler[oi, oj];

                if (onceki_secilen != null)
                {
                    if (secilen != onceki_secilen)
                    {

                        if (yendi == -1)
                        {
                            ses();
                            taslar[oi, oj] = taslar[si, sj];
                            kareler[oi, oj].BackgroundImage = kareler[si, sj].BackgroundImage;
                            onceki_secilen.BackgroundImage = null;
                            secilen = null; onceki_secilen = null;
                            taslar[si, sj] = new Taslar(-1);
                            button1.Enabled = false;

                            if (taslar[oi, oj].İsBlack == 0)
                            {
                                oyuncuBeyaz = true;
                                oyuncuSiyah = false;
                            }
                            else if (taslar[oi, oj].İsBlack == 1)
                            {
                                oyuncuSiyah = true;
                                oyuncuBeyaz = false;
                            }
                        }
                        else
                        {
                            ses();
                            taslar[oi, oj] = taslar[si, sj];
                            taslar[si, sj] = tasTut;
                            kareler[oi, oj].BackgroundImage = kareler[si, sj].BackgroundImage;
                            kareler[si, sj].BackgroundImage = nesne.BackgroundImage;
                            nesne.BackgroundImage = null;
                            secilen = null; onceki_secilen = null;
                            button1.Enabled = false;

                            if (taslar[oi, oj].İsBlack == 0)
                            {
                                oyuncuBeyaz = true;
                                oyuncuSiyah = false;
                            }
                            else if (taslar[oi, oj].İsBlack == 1)
                            {

                                oyuncuSiyah = true;
                                oyuncuBeyaz = false;
                            }
                        }
                    }
                }
            }
        }
        private void siyahROK(object sender, EventArgs e)
        {
            hangirok = 0;
            if (taslar[7, 1].İsBlack == -1 && taslar[7, 2].İsBlack == -1 && oi == 7 && oj == 0 && kaleSiyahSol == true && sahSiyah == true)
            {
                ses();
                siyahsahkonumx = 7;
                siyahsahkonumy = 1;
                rok(7, 0, 2, 3, 1);
                button3.Enabled = false;
                
            }
            else if (taslar[7, 5].İsBlack == -1 && taslar[7, 6].İsBlack == -1 && taslar[7, 4].İsBlack == -1 && oi == 7 && oj == 7 && kaleSiyahSag == true && sahSiyah == true)
            {
                ses();
                siyahsahkonumx = 7;
                siyahsahkonumy = 5;
                rok(7, 7, 4, 3, 5);
                button3.Enabled = false;
               
               
            }
            else
            {
                if ((taslar[7, 1].İsBlack == -1 && taslar[7, 2].İsBlack == -1)||(taslar[7, 5].İsBlack == -1 && taslar[7, 6].İsBlack == -1 && taslar[7, 4].İsBlack == -1))
                {
                    MessageBox.Show("ROK YAPACAĞINIZ KALEYE TIKLAYIN");
                }
                else
                {
                    MessageBox.Show("ROK İÇİN TAŞLAR UYGUN POZİSYONDA DEĞİL !!!");
                }
                
            }


        }
        private void beyazROK(object sender, EventArgs e)
        {
            hangirok = 1;
            if (taslar[0, 1].İsBlack == -1 && taslar[0, 2].İsBlack == -1 && oi == 0 && oj == 0 && kaleBeyazSol == true && sahBeyaz == true)
            {
                ses();
                rok(0, 0, 2, 3, 1);
                beyazsahkonumx = 0;
                beyazsahkonumy = 1;
                button2.Enabled = false;
             

            }
            else if (taslar[0, 5].İsBlack == -1 && taslar[0, 6].İsBlack == -1 && taslar[0, 4].İsBlack == -1 && oi == 0 && oj == 7 && kaleBeyazSag == true && sahBeyaz == true)
            {
                ses();
                rok(0, 7, 4, 3, 5);
                beyazsahkonumx = 0;
                beyazsahkonumy = 5;
                button2.Enabled = false;
                

            }
            else
            {
                if ((taslar[0, 1].İsBlack == -1 && taslar[0, 2].İsBlack == -1) || (taslar[0, 5].İsBlack == -1 && taslar[0, 6].İsBlack == -1 && taslar[0, 4].İsBlack == -1))
                {
                    MessageBox.Show("ROK YAPACAĞINIZ KALEYE TIKLAYIN");
                }
                else
                {
                    MessageBox.Show("ROK İÇİN TAŞLAR UYGUN POZİSYONDA DEĞİL !!!");
                }
            }

        }
        public void rok(int i, int kj, int kjY, int sj, int sjY)
        {
            oyuncuSirasi(i, kj);
            taslar[i, kjY] = taslar[i, kj];
            kareler[i, kjY].BackgroundImage = kareler[i, kj].BackgroundImage;
            taslar[i, kj] = new Taslar(-1);
            kareler[i, kj].BackgroundImage = null;

            taslar[i, sjY] = taslar[i, sj];
            kareler[i, sjY].BackgroundImage = kareler[i, sj].BackgroundImage;
            taslar[i, sj] = new Taslar(-1);
            kareler[i, sj].BackgroundImage = null;
            rok_yapildi = true;
            

        }
        public void hareketEt()
        {
            ses();
            matKontrol();
            rok_yapildi = false;
            gerinameOnceki = Convert.ToString(onceki_secilen.Name);
            gerinameSecilen = Convert.ToString(secilen.Name);
            puanHesapla(oi, oj, si, sj);
            oyuncuSirasi(oi, oj);
            sayac++;
            nesne.BackgroundImage = kareler[si, sj].BackgroundImage;
            tasTut = taslar[si, sj];
            taslar[si, sj] = taslar[oi, oj];
            secilen.BackgroundImage = onceki_secilen.BackgroundImage;
            onceki_secilen.BackgroundImage = null;
            secilen = null; onceki_secilen = null;
            taslar[oi, oj] = new Taslar(-1);
            if (sayac == 2)
            {
                button1.Enabled = true;
                sayac = 0;
            }
            tahtayiRenklendir();

        }
        void tahtayiRenklendir()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j % 2 == 0 && i % 2 == 0)
                        kareler[i, j].BackColor = Color.DarkRed;
                    else if (j % 2 != 0 && i % 2 != 0)
                        kareler[i, j].BackColor = Color.DarkRed;
                    else
                        kareler[i, j].BackColor = Color.DarkSlateBlue;
                }
            }

        }
        void renklendirme(object sender, EventArgs e) 
        {
            tahtayiRenklendir();
            PictureBox pb = sender as PictureBox;
            name = pb.Name.ToString();
            oi = Convert.ToInt16(name.Substring(1, 1));
            oj = Convert.ToInt16(name.Substring(2, 1));

            Taslar piyon = new Piyon();
            Taslar at    = new At();
            Taslar fil = new   Fil();
            Taslar sah = new Sah();
            Taslar vezir = new Vezir();
            Taslar kale = new Kale();

            piyon.SonrakiHandler = at;
            at.SonrakiHandler = fil;
            fil.SonrakiHandler = sah;
            sah.SonrakiHandler = vezir;
            vezir.SonrakiHandler = kale;
            kale.SonrakiHandler = null;

            piyon.renklendirme(taslar[oi,oj], oi, oj, si, sj);



        }
        public void ses()
        {
            SoundPlayer player = new SoundPlayer();
            string path = "ses.wav"; 
            player.SoundLocation = path;
            player.Play();
        }
      
    }
}
