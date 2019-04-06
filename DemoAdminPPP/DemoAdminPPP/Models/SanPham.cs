using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAdminPPP.Models
{
    public class SanPham
    {
        public Product sp = new Product();
        public int gia = 0;
        public int sl = 0;

        public SanPham(Product sp,int gia,int sl)
        {
            this.sp = sp;
            this.gia = gia;
            this.sl = sl;
        }

        public SanPham()
        {
        }
        public SanPham(Product sp, int gia)
        {
            this.sp = sp;
            this.sl++;
            this.gia = gia;
        }

        public SanPham(Product old)
        {
            this.sp = old;
            this.sl++;
            this.gia = this.gia * 2;
        }
    }
}