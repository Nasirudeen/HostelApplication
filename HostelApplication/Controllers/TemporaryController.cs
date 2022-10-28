using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HostelApplication.Models;
using Microsoft.Data.SqlClient;

namespace HostelApplication.Controllers
{
    public class displayhostel
    {
        public int MatricNo { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Hall { get; set; }
        public string  Block  { get; set; }
        public string Room { get; set; }
        public string Bunk { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
    public class TemporaryController : Controller
    {
        IHostelRepository HostelRepository;

        public TemporaryController(IHostelRepository Hhostel)
        {
            HostelRepository = Hhostel;
        }
        public ActionResult Index()
        {

            // TempData["status"] = TempData["status"];
            var List = HostelRepository.Temporarys;

            return View(List);
        }
        public ActionResult displayhostel(string MatricNo)
        {
            var ip = HttpContext.Connection.RemoteIpAddress.ToString();

            AuditTrail auditTrail = new AuditTrail
            {
                Action = "displayhostel",
                NewValue = "Temporary",
                //  OldValue = "",
                IpAddress = ip,
                CreatedBy = HttpContext.User.Identity.Name,
                ObjectName = "displayhostel",
                Created = DateTime.Now,
                Updated = DateTime.Now,
            };
            HostelRepository.AddAuditTrail(auditTrail);
            HostelRepository.Save();


            List<displayhostel> display = new List<displayhostel>();
            using (SqlConnection connection = new SqlConnection("Server=.;Database=HostelApps;Trusted_Connection=True;MultipleActiveResultSets=true"))
            {
                SqlCommand command = new SqlCommand();
                command.CommandText = @"select MatricNo, LastName, Department, Hall, Block, Room, Bunk, StartDate, ExpireDate
               from Temporary";
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                command.Connection = connection;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Close();
                        connection.Close();
                    }
                }
            }

            return View(display);
        }
        // GET: TemporaryController/Create
        public ActionResult Create()
        {
            ViewBag.Department = Department();
            ViewBag.Faculty = Faculty();
            ViewBag.Course = Course();


            ViewBag.Hall = Hall();
            ViewBag.Block = Block();
            ViewBag.Room = Room();
            ViewBag.Bunk = Bunk();
            ViewBag.User = User();
            return View();
        }

        // POST: TemporaryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Temporary app)
        {
            try
            {

                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Create",
                    NewValue = "Department",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Create",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);
                HostelRepository.Save();
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                app.Created = DateTime.Now;
                app.Updated = DateTime.Now;

                HostelRepository.AddTemporary(app);
                HostelRepository.Save();
                TempData["status"] = "Allocation Created successfully";
                // return View();
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                return View();
            }
        }

        public List<SelectListItem> Faculty()
        {
            var dept = new List<SelectListItem>();
            var items = HostelRepository.Facultys.ToList();
            foreach (var t in items)
            {
                dept.Add(new SelectListItem { Text = t.FacultyName, Value = t.FacultyId.ToString() });
            }
            return dept;
        }
        public List<SelectListItem> Department()
        {
            var dept = new List<SelectListItem>();
            var items = HostelRepository.Departments.ToList();
            foreach (var t in items)
            {
                dept.Add(new SelectListItem { Text = t.DepartmentName, Value = t.DepartmentId.ToString() });
            }
            return dept;
        }
        public List<SelectListItem> Course()
        {
            var dept = new List<SelectListItem>();
            var items = HostelRepository.Courses.ToList();
            foreach (var t in items)
            {
                dept.Add(new SelectListItem { Text = t.CourseName, Value = t.CourseId.ToString() });
            }
            return dept;
        }

        public List<SelectListItem> Hall()
        {
            var day = new List<SelectListItem>();
            var items = HostelRepository.Halls.ToList();
            foreach (var t in items)
            {
                day.Add(new SelectListItem { Text = t.HallName, Value = t.HallId.ToString() });
            }
            return day;
        }
        public List<SelectListItem> Block()
        {
            var hall = new List<SelectListItem>();
            var items = HostelRepository.Blocks.ToList();
            foreach (var t in items)
            {
                hall.Add(new SelectListItem { Text = t.BlockNo, Value = t.BlockId.ToString() });
            }
            return hall;
        }

        public List<SelectListItem> Room()
        {
            var course = new List<SelectListItem>();
            var items = HostelRepository.Rooms.ToList();
            foreach (var t in items)
            {
                course.Add(new SelectListItem { Text = t.RoomNo, Value = t.RoomId.ToString() });
            }
            return course;
        }
        public List<SelectListItem> Bunk()
        {
            var course = new List<SelectListItem>();
            var items = HostelRepository.Bunks.ToList();
            foreach (var t in items)
            {
                course.Add(new SelectListItem { Text = t.BunkNo, Value = t.BunkId.ToString() });
            }
            return course;
        }


        public List<SelectListItem> User()
        {
            var user = new List<SelectListItem>();
            var items = HostelRepository.Users.ToList();
            foreach (var t in items)
            {
                user.Add(new SelectListItem { Text = t.EmailAddress, Value = t.UserId.ToString() });
            }
            return user;
        }



        // GET: AllocationController/Edit/5
        public ActionResult Edit(int Id)
        {
            var apps = HostelRepository.Allocations;
            Allocation dba = HostelRepository.Allocations.FirstOrDefault(d => d.AllocationId == Id);
            return View(dba);
        }

        // POST:AllocationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Temporary apps)
        {
            try
            {
                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Edit",
                    NewValue = "Department",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Edit",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);
                HostelRepository.Save();
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // TODO:  Edit logic here

                var app = HostelRepository.Temporarys;
                Temporary dba = HostelRepository.Temporarys.FirstOrDefault(d => d.TemporaryId == apps.TemporaryId);
                // dba.DepartmentName = apps.EntryName;

                dba.Created = apps.Created;
                dba.Updated = apps.Updated;
                HostelRepository.Save();
                //return View(app);
                return RedirectToAction("Index");
            }

            catch (Exception e)
            {
                return View();
            }
        }

        // GET: TemporaryController/Delete/5
        //[Authorize]
        public ActionResult Delete(int Id)
        {
            var apps = HostelRepository.Temporarys;
            Temporary dba = HostelRepository.Temporarys.Single(d => d.TemporaryId == Id);
            return View(dba);
        }

        // POST: TemporaryController/Delete/5
        // [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Temporary apps)
        {
            try
            {
                var ip = HttpContext.Connection.RemoteIpAddress.ToString();

                AuditTrail auditTrail = new AuditTrail
                {
                    Action = "Delete",
                    NewValue = "Department",
                    //  OldValue = "",
                    IpAddress = ip,
                    CreatedBy = HttpContext.User.Identity.Name,
                    ObjectName = "Delete",
                    Created = DateTime.Now,
                    Updated = DateTime.Now,
                };
                HostelRepository.AddAuditTrail(auditTrail);
                HostelRepository.Save();


                var app = HostelRepository.Temporarys;
                Temporary dba = HostelRepository.Temporarys.FirstOrDefault(d => d.TemporaryId == apps.TemporaryId);
                HostelRepository.RemoveTemporary(dba);
                HostelRepository.Save();
                //  return View(apps);
                return RedirectToAction("Index");


            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}
