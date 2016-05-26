using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatrancProje
{
    public partial class PiyonSec : Form
    {
        string comboboxsecim;
        Taslar t;
        Taslar olusturulantut;
        int si, sj;
        public PiyonSec(Taslar t,int si,int sj)
        {
            InitializeComponent();
            this.t = t;
            this.sj = sj;
            this.si = si;
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            comboboxsecim=comboBox1.Text;
            piyonKontrol(si,sj,t);
            this.Close();
        }
        public void piyonKontrol(int si, int sj, Taslar t)
        {
            if (comboboxsecim != "")
            {
                if (si == 7 || si == 0)
                {
                 
                    if (t.İsBlack == 0)
                    {
                      if (comboboxsecim == "Kale")
                        {
                            Form1.taslar[si, sj] = new Kale(0, "kale_beyaz");
                            Form1.kareler[si, sj].BackgroundImage = Form1.taslar[si, sj].D_img.BackgroundImage;

                        }
                        else if (comboboxsecim == "At")
                        {
                            Form1.taslar[si, sj] = new At(0, "at_beyaz");
                            Form1.kareler[si, sj].BackgroundImage = Form1.taslar[si, sj].D_img.BackgroundImage;
                        }
                        else if (comboboxsecim == "Fil")
                        {
                            Form1.taslar[si, sj] = new Fil(0, "fil_beyaz");
                            Form1.kareler[si, sj].BackgroundImage = Form1.taslar[si, sj].D_img.BackgroundImage;
                        }
                        else
                        {
                            Form1.taslar[si, sj] = new Vezir(0, "vezir_beyaz");
                            Form1.kareler[si, sj].BackgroundImage = Form1.taslar[si, sj].D_img.BackgroundImage;
                        }
                    }
                    else
                    {
                        if (comboboxsecim == "Kale")
                        {
                            Form1.taslar[si, sj] = new Kale(1, "kale_siyah");
                            Form1.kareler[si, sj].BackgroundImage = Form1.taslar[si, sj].D_img.BackgroundImage;
                        }
                        else if (comboboxsecim == "At")
                        {
                            Form1.taslar[si, sj] = new At(1, "at_siyah");
                            Form1.kareler[si, sj].BackgroundImage = Form1.taslar[si, sj].D_img.BackgroundImage;
                        }
                        else if (comboboxsecim == "Fil")
                        {
                            Form1.taslar[si, sj] = new Fil(1, "fil_siyah");
                            Form1.kareler[si, sj].BackgroundImage = Form1.taslar[si, sj].D_img.BackgroundImage;
                        }
                        else
                        {
                            Form1.taslar[si, sj] = new Vezir(1, "vezir_siyah");
                            Form1.kareler[si, sj].BackgroundImage = Form1.taslar[si, sj].D_img.BackgroundImage;
                        }
                    }
                    comboboxsecim = "";
                }
            }
        }
    }
}
