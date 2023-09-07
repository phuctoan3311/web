using Microsoft.AspNetCore.Mvc;

namespace web.Controllers
{
    public class TongHaiSoController : Controller
    {
        public IActionResult GiaoDienTinhTong()
        {
            return View();
        }
        public IActionResult GiaoDienTinhHieu()
        {
            return View();
        }
        public IActionResult GiaoDienTinhTich()
        {
            return View();
        }
        public IActionResult GiaoDienTinhThuong()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GiaoDienTinhTong(int soNguyen1, int soNguyen2)
        {
            ViewData["SoNguyen1"] = soNguyen1;
            ViewData["SoNguyen2"] = soNguyen2;
            ViewData["KetQua"] = soNguyen1 + soNguyen2;
            return View();
        }
        [HttpPost]
        public IActionResult GiaoDienTinhHieu(int soNguyen1, int soNguyen2)
        {
            ViewData["SoNguyen1"] = soNguyen1;
            ViewData["SoNguyen2"] = soNguyen2;
            ViewData["KetQua"] = soNguyen1 - soNguyen2;
            return View();
        }
        [HttpPost]
        public IActionResult GiaoDienTinhTich(int soNguyen1, int soNguyen2)
        {
            ViewData["SoNguyen1"] = soNguyen1;
            ViewData["SoNguyen2"] = soNguyen2;
            ViewData["KetQua"] = soNguyen1*soNguyen2;
            return View();
        }
        [HttpPost]
        public IActionResult GiaoDienTinhThuong(int soNguyen1, int soNguyen2)
        {
            try
            {
                ViewData["SoNguyen1"] = soNguyen1;
                ViewData["SoNguyen2"] = soNguyen2;
                ViewData["KetQua"] = soNguyen1 / soNguyen2;
                ViewData["message"] = "";
            }
            catch (DivideByZeroException dex)
            {
                ViewData["message"] = "khong dc phep chia cho 0";
            }
            catch (Exception ex)
            {
                ViewData["message"] = ex.Message;
            }
            return View();
        }
    }
}
