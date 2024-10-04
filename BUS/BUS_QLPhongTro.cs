using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using static DTO.DTO_QLPhongTro;
namespace BUS
{
    public class BUS_QLPhongTro
    {
        DatabaseAccessGet dag= new DatabaseAccessGet();
        public List<Phong> GetListPhong()
        {
            return dag.GetListPhong();
        }
        public List<LoaiPhong> GetListLoaiPhong()
        {
            return dag.GetListLoaiPhong();
        }
        public List<Tang> GetListTang()
        {
            return dag.GetListTang();
        }
        public List<SoPhong> GetListSoPhong()
        {
            return dag.GetListSoPhong();
        }
        
        
        

    }
}
