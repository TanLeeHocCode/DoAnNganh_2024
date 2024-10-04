using DAL;
using DTO;

namespace BUS
{
    public class BUS_Admin
    {
        private DatabaseAccessLogin dal = new DatabaseAccessLogin();

        public string CheckLogin(Admin admin)
        {
            if (string.IsNullOrEmpty(admin.TaiKhoan))
            {
                return "Quên nhập tài khoản";
            }
            if (string.IsNullOrEmpty(admin.MatKhau))
            {
                return "Quên nhập mật khẩu";
            }

            return dal.CheckLoginDTO(admin);
        }

        public Admin GetAdminByCredentials(string taiKhoan, string matKhau)
        {
            return dal.GetAdminByCredentials(taiKhoan, matKhau);
        }
    }
}
