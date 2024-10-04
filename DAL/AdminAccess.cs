using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class AdminAccess:DatabaseAccessGet
    {
        public string CheckLogin(Admin admin)
        {
            string info = CheckLoginDTO(admin);
            return info;
        }
    }
}
