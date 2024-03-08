using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace quanlithuvientruongdaihoc.model
{
    public class sachmodel
    {
        private int Ma_sach;
        private string Ten_sach;
        private string The_loai;
        private string Tac_gia;
        private string Vi_tri;
        private string Ngon_ngu;
        private string Nam_xb;
        private string Gia_bia;

        public int Ma_Sach { get { return Ma_sach; } set { Ma_sach = value; } }
        public string Ten_Sach { get { return Ten_sach; } set { Ten_sach = value; } }
        public string The_Loai { get { return The_loai; } set { The_loai = value; } }
        public string Tac_Gia { get { return Tac_gia; } set { Tac_gia = value; } }
        public string Vi_Gri { get
            {
                return Vi_tri;
            }
            set
            {
                Vi_tri = value;
            } }
        public string Ngon_Ngu { get
            {
                return Ngon_ngu;
            }
            set
            {
                Ngon_ngu = value;
            } }
        public string Nam_XB { get
            {
                return Nam_xb;
            }
            set
            {
                Nam_xb = value;
            } }
        public string Gia_Bia { get
            {
                return Gia_bia;
            }
            set
            {
                Gia_bia = value;
            } }
    }
}
