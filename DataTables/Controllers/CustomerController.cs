using Microsoft.AspNetCore.Mvc;
using DataTables.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataTables.Controllers
{
    public class CustomerController : Controller
    {
        private readonly DataDbContext _context;

        public CustomerController(DataDbContext context)
        {
            _context = context;
        }

        public IActionResult ShowGrid()
        {
            return View();
        }
        public IActionResult jsonRes( )
        {
            var customerData = from tempcustomer in _context.Customers
                               select new
                               {
                                   tempcustomer.CustomerID,
                                   tempcustomer.CompanyName,
                                   tempcustomer.ContactName,
                                   tempcustomer.ContactTitle,
                                   tempcustomer.City,
                                   tempcustomer.PostalCode,
                                   tempcustomer.Country,
                                   tempcustomer.Phone

                               };
            return Json(new { data = customerData });
        }


        [HttpPost]
        public ActionResult LoadData()
        {
            try
            {
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                var customerData = from tempcustomer in _context.Customers
                                   select new
                                   {
                                       tempcustomer.CustomerID,
                                       tempcustomer.CompanyName,
                                       tempcustomer.ContactName,
                                       tempcustomer.ContactTitle,
                                       tempcustomer.City,
                                       tempcustomer.PostalCode,
                                       tempcustomer.Country,
                                       tempcustomer.Phone

                                   };

                // Sorting
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
                {
                    customerData = customerData.OrderBy($"{sortColumn} {sortColumnDir}");
                }

                // Search
                if (!string.IsNullOrEmpty(searchValue))
                {
                    customerData = customerData.Where(m => m.CompanyName.Contains(searchValue));
                }

                recordsTotal = customerData.Count();

                var data = customerData.Skip(skip).Take(pageSize).ToList();

                Console.WriteLine( Json(new {  data = data }));
                jsonRes();   
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
            }
            catch (Exception ex)
            {
                // Log exception
                return Json(new { error = ex.Message });
            }
        }
    }
}
