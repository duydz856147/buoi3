using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class hinhTamGiac
    {
        private double ma, mb, mc;
        private double chuVi, dienTich, p;
        public hinhTamGiac()
        {
            ma = 0;
            mb = 0;
            mc = 0;
        }
        public hinhTamGiac(int ma, int mb, int mc)
        {
            this.ma = ma;
            this.mb = mb;
            this.mc = mc;
        }
        public double getma()
        {
            return ma;
        }
        public void setma(int ma)
        {
            if(ma > 0)
            {
                this.ma = ma;
            }
        }
        public double getmb()
        {
            return mb;
        }
        public void setmb(int mb)
        {
            if(mb > 0)
            {
                this.mb = mb;
            }
        }
        public double getmc()
        {
            return mb;
        }
        public void setmc(int mc)
        {
            if (mc > 0)
            {
                this.mc = mc;
            }
        }
        public double chuVi()
        {
            return ma + mb + mc;
        }
        public double p()
        {
            return (ma + mb + mc) / 2;
        }
        public double dienTich()
        {
            return Math.Sqrt(p() * (p() - ma) * (p() - mb) * (p() - mc));
        }
        public void kieuTamGiac()
        {
            if (ma + mb > mc || ma + mc > mb || mb + mc > ma)
            {
                Console.WriteLine("tam giac thuong");
                    if(ma == mb || ma == mc || mb == mc)
                    {
                        Console.WriteLine("tam giac deu");
                
                    }
                    else if(ma == mb && ma == mc && mb == mc)
                    {
                        Console.WriteLine("tam giac can");
                
                    }
                    else
                    {
                        Console.WriteLine("deo phai tam giac ok");
                    }
            }
        }
        public override string ToString()
        {
            
        }
    }
}
