using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrancProje
{
    class TasKontrol 
    {
       
        public bool tasKontrolAsagi(int oi, int oj, int si)
        {
            int i = oi + 1;
            bool kontrol = true;
            while (i < si)
            {
                if (Form1.taslar[i, oj].İsBlack != -1)
                {
                    break;
                }
                i++;
            }
            if (i < si)
            {
                kontrol = false;
            }

            return kontrol;


        }
        public bool tasKontrolYukari(int oi, int oj, int si)
        {
            int i = oi - 1;
            bool kontrol = true;
            if (i != -1)
            {
                while (i >= si)
                {
                    if (Form1.taslar[i, oj].İsBlack != -1)
                    {
                        break;
                    }
                    i--;
                }
            }

            if (i > si)
            {
                kontrol = false;
            }
            return kontrol;

        }

        public bool tasKontrolSaga(int oi, int oj, int sj)
        {
            int j = oj + 1;
            bool kontrol = true;
            while (j < sj)
            {
                if (Form1.taslar[oi, j].İsBlack != -1)
                {
                    break;
                }
                j++;
            }
            if (j < sj)
            {
                kontrol = false;
            }
            return kontrol;

        }
        public bool tasKontrolSola(int oi, int oj, int sj)
        {
            int j = oj - 1;
            bool kontrol = true;
            if (j != -1)
            {
                while (j > sj)
                {
                    if (Form1.taslar[oi, j].İsBlack != -1)
                    {
                        break;
                    }
                    j--;
                }
            }


            if (j > sj)
            {
                kontrol = false;
            }
            return kontrol;
        }
        public bool tasKontrolAsagiSag(int oi, int oj, int si, int sj)
        {
            int i = oi + 1;
            int j = oj + 1;
            bool kontrol = true;
            while (i < si && j < sj)
            {
                if (Form1.taslar[i, j].İsBlack != -1)
                {

                    break;
                }

                i++;
                j++;
            }
            if (i < si && j < sj)
                kontrol = false;

            return kontrol;
        }
        public bool tasKontrolUstSol(int oi, int oj, int si, int sj)
        {
            int i = oi - 1;
            int j = oj - 1;
            bool kontrol = true;
            while (i > si && j > sj)
            {
                if (Form1.taslar[i, j].İsBlack != -1)
                {

                    break;
                }
                i--;
                j--;
            }
            if (i > si && j > sj)
                kontrol = false;
            return kontrol;
        }
        public bool tasKontrolAsagiSol(int oi, int oj, int si, int sj)
        {
            int i = oi + 1;
            int j = oj - 1;
            bool kontrol = true;
            while (i < si && j > sj)
            {
                if (Form1.taslar[i, j].İsBlack != -1)
                {

                    break;
                }
                i++;
                j--;
            }
            if (i < si && j > sj)
                kontrol = false;
            return kontrol;
        }
        public bool tasKontrolYukariSag(int oi, int oj, int si, int sj)
        {
            int i = oi - 1;
            int j = oj + 1;
            bool kontrol = true;
            while (i > si && j < sj)
            {
                if (Form1.taslar[i, j].İsBlack != -1)
                {
                    kontrol = false;
                    break;
                }
                i--;
                j++;
            }
            if (i > si && j < sj)
                kontrol = false;
            return kontrol;
        }

        public bool sahtasKontrolAsagi(int oi, int oj, int si)
        {
            int i = oi + 1;
            bool kontrol = true;
            while (i < si)
            {
                if (Form1.kopyataslar[i, oj].İsBlack != -1)
                {
                    break;
                }
                i++;
            }
            if (i < si)
            {
                kontrol = false;
            }

            return kontrol;


        }
        public bool sahtasKontrolYukari(int oi, int oj, int si)
        {
            int i = oi - 1;
            bool kontrol = true;
            if (i != -1)
            {
                while (i >= si)
                {
                    if (Form1.kopyataslar[i, oj].İsBlack != -1)
                    {
                        break;
                    }
                    i--;
                }
            }

            if (i > si)
            {
                kontrol = false;
            }
            return kontrol;

        }

        public bool sahtasKontrolSaga(int oi, int oj, int sj)
        {
            int j = oj + 1;
            bool kontrol = true;
            while (j < sj)
            {
                if (Form1.kopyataslar[oi, j].İsBlack != -1)
                {
                    break;
                }
                j++;
            }
            if (j < sj)
            {
                kontrol = false;
            }
            return kontrol;

        }
        public bool sahtasKontrolSola(int oi, int oj, int sj)
        {
            int j = oj - 1;
            bool kontrol = true;
            if (j != -1)
            {
                while (j > sj)
                {
                    if (Form1.kopyataslar[oi, j].İsBlack != -1)
                    {
                        break;
                    }
                    j--;
                }
            }


            if (j > sj)
            {
                kontrol = false;
            }
            return kontrol;
        }
        public bool sahtasKontrolAsagiSag(int oi, int oj, int si, int sj)
        {
            int i = oi + 1;
            int j = oj + 1;
            bool kontrol = true;
            while (i < si && j < sj)
            {
                if (Form1.kopyataslar[i, j].İsBlack != -1)
                {

                    break;
                }

                i++;
                j++;
            }
            if (i < si && j < sj)
                kontrol = false;

            return kontrol;
        }
        public bool sahtasKontrolUstSol(int oi, int oj, int si, int sj)
        {
            int i = oi - 1;
            int j = oj - 1;
            bool kontrol = true;
            while (i > si && j > sj)
            {
                if (Form1.kopyataslar[i, j].İsBlack != -1)
                {

                    break;
                }
                i--;
                j--;
            }
            if (i > si && j > sj)
                kontrol = false;
            return kontrol;
        }
        public bool sahtasKontrolAsagiSol(int oi, int oj, int si, int sj)
        {
            int i = oi + 1;
            int j = oj - 1;
            bool kontrol = true;
            while (i < si && j > sj)
            {
                if (Form1.kopyataslar[i, j].İsBlack != -1)
                {

                    break;
                }
                i++;
                j--;
            }
            if (i < si && j > sj)
                kontrol = false;
            return kontrol;
        }
        public bool sahtasKontrolYukariSag(int oi, int oj, int si, int sj)
        {
            int i = oi - 1;
            int j = oj + 1;
            bool kontrol = true;
            while (i > si && j < sj)
            {
                if (Form1.kopyataslar[i, j].İsBlack != -1)
                {
                    kontrol = false;
                    break;
                }
                i--;
                j++;
            }
            if (i > si && j < sj)
                kontrol = false;
            return kontrol;
        }
    }

}
