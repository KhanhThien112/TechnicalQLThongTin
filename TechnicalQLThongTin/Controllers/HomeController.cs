using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechnicalQLThongTin.Models;

namespace TechnicalQLThongTin.Controllers
{
    public class HomeController : Controller
    {
        TechnicalEntities db = new TechnicalEntities();
        // GET: Employee
        public ActionResult Index(int? page)
        {
            var res = (from employees in db.Employees
                       select new EmployeeValidation
                       {
                           id = employees.ID,
                           maNV = employees.MaNV,
                           hoTen = employees.HoTen,
                           namSinh = (DateTime)employees.NamSinh,
                           email = employees.Email,
                           dienThoai = employees.DienThoai,
                           diaChi = employees.DiaChi
                       }).ToList();
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(res.ToList().ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(EmployeeValidation employeeValidation)
        {
            db.Employees_insert(employeeValidation.maNV, employeeValidation.hoTen, employeeValidation.namSinh, employeeValidation.email,
                employeeValidation.dienThoai, employeeValidation.diaChi);
            TempData["msgSuccess"] = "<script>alert('Thêm mới thành công');</script>";
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Edit(int? id)
        {
            var res = (from employees in db.Employees_searchByID(id)
                       select new EmployeeValidation
                       {
                           id = employees.ID,
                           maNV = employees.MaNV,
                           hoTen = employees.HoTen,
                           namSinh = (DateTime)employees.NamSinh,
                           email = employees.Email,
                           dienThoai = employees.DienThoai,
                           diaChi = employees.DiaChi

                       }).ToList();
            EmployeeValidation DO = new EmployeeValidation();
            if (res.Count > 0)
            {
                foreach (var co in res)
                {
                    DO.id = co.id;
                    DO.maNV = co.maNV;
                    DO.hoTen = co.hoTen;
                    DO.namSinh = co.namSinh;
                    DO.email = co.email;
                    DO.dienThoai = co.dienThoai;
                    DO.diaChi = co.diaChi;
                }
                ViewBag.namSinh = DO.namSinh.ToString("yyyy-MM-dd");
            }
            else
            {
                return HttpNotFound();
            }
   
            return PartialView(DO);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeValidation employeeValidation)
        {
            try
            {

                db.Employees_update(employeeValidation.id ,employeeValidation.maNV, employeeValidation.hoTen, employeeValidation.namSinh, employeeValidation.email,
                employeeValidation.dienThoai, employeeValidation.diaChi);

                TempData["msgSuccess"] = "<script>alert('Cập nhập thành công');</script>";
            }
            catch (Exception e)
            {
                TempData["msgSuccess"] = "<script>alert('Cập nhập thất bại " + e.Message + " ');</script>";
            }

            return RedirectToAction("Index", "Home");
        }
        public ActionResult Delete(int? id)
        {
            try
            {
                db.Employees_Delete(id);
            }
            catch (Exception e)
            {
                TempData["msgSuccess"] = "<script>alert('Xóa dữ liệu thất bại: " + e.Message + "');</script>";
            }
            return RedirectToAction("Index", "Home");
        }
    }
}