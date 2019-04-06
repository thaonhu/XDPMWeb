using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAdminPPP.Models
{
    public class DSSP
    {
        ArrayList dssp = new ArrayList();
        int sl = 0;
        int tonggia = 0;
        public DSSP(ArrayList dssp, int sl, int tonggia)
        {
            this.dssp = dssp;
            this.sl = sl;
            this.tonggia = tonggia;
        }
        public DSSP()
        {
        }
        
        public DSSP(DSSP dssp_old)
        {
            if (dssp_old != null)
            {
                this.dssp = dssp_old.dssp;
                this.sl = dssp_old.sl;
                this.tonggia = dssp_old.tonggia;
            }
        }
        public void ThemSP (SanPham sp)
        {
            if(dssp == null) {
                this.dssp.Add(sp);
                this.sl += sp.sl;
                this.tonggia += sp.gia;
            }
            else
            {
                int a = TimSanPham(sp);
                if (a != -1) 
                {
                    SanPham spc = (SanPham)this.dssp[a];
                    spc.sl++;
                    this.sl += sp.sl;
                    this.tonggia += sp.gia;
                }
                else
                {
                    this.dssp.Add(sp);
                    this.sl += sp.sl;
                    this.tonggia += sp.gia;
                }
            }
        }
        public int TimSanPham(SanPham spm)
        {
            int flag = -1;
            for (int i=0; i < this.dssp.Count; i++)
            {
                SanPham a = (SanPham)this.dssp[i];
                if (String.Compare(a.sp.product_id, spm.sp.product_id, true) == 0)
                {
                    flag = i;
                    return flag;
                }
            }
            return flag;
        }
    }
}