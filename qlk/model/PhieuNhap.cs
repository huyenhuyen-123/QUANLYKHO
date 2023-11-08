using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLK.model
{
    internal class PhieuNhap
    {
        public String SO_PN { get; set; }
        public String NGAY_NHAP { get; set; }
        public String SO_HD { get; set; }
        public String NGAY_HD { get; set; }
        public String NOI_PH_DH { get; set; }
        public String MA_KHO { get; set; }

        public PhieuNhap() { }

        public PhieuNhap(String SO_PN, String NGAY_NHAP, String SO_HD, String NGAY_HD, String NOI_PH_DH, String MA_KHO)
        {
            this.SO_PN = SO_PN;
            this.NGAY_NHAP = NGAY_NHAP;
            this.SO_HD = SO_HD;
            this.NGAY_HD = NGAY_HD;
            this.NOI_PH_DH = NOI_PH_DH;
            this.MA_KHO = MA_KHO;
        }

    }
}
