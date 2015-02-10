using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Purevision.Models;

namespace Purevision.Controllers
{
    public class ClientsController : Controller
    {
        private PurevisionEntities db = new PurevisionEntities();

        private User _user;
        private IQueryable<Client> _clients;

        public ClientsController ()
        {
            var userEmail = System.Web.HttpContext.Current.User.Identity.Name;
            try
            {
                _user = db.Users.Single(user => user.Email == userEmail);
                _clients = db.Clients.Where(client => client.UserId == _user.Id);

            }
            catch (Exception ex)
            {
                RedirectToRoute("Default", (RouteTable.Routes["Default"] as Route).Defaults);
            }
        }

        // GET: Clients
        public async Task<ActionResult> Index()
        {
            if (_user == null) return RedirectToRoute("Default", (RouteTable.Routes["Default"] as Route).Defaults);
            return View(await _clients.ToListAsync());
        }

        public ActionResult Clients_Read([DataSourceRequest] DataSourceRequest request)
        {
            if (_user == null) RedirectToRoute("Default", (RouteTable.Routes["Default"] as Route).Defaults);
            //using (var purevision = new PurevisionEntities())
            //{
            //IQueryable<Client> clients = db.Clients.Where(client => client.UserId == _user.Id);
            // Convert the Client entities to ClientViewModel instances
            DataSourceResult result = _clients.ToDataSourceResult(request, client => new ClientViewModel
            {
                Id = client.Id,
                Name = client.Name
            });
            return Json(result);

            //return Json(db.Clients.ToDataSourceResult(
            //    request, client => new ClientViewModel
            //    {
            //        Id = client.Id,
            //        Name = client.Name
            //    })
            //);

                //return Json(new[] { client }.ToDataSourceResult(request, ModelState));
            //}
        }

        // GET: Clients/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = await db.Clients.FindAsync(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name")] Client client)
        {
            if (ModelState.IsValid)
            {
                client.UserId = _user.Id;
                db.Clients.Add(client);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(client);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Create([DataSourceRequest] DataSourceRequest request, Client client)
        {
            if (client != null && ModelState.IsValid)
            {
                client.UserId = _user.Id;
                //productService.Create(client);
                db.Clients.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return Json(new[] { client }.ToDataSourceResult(request, ModelState));
        }

        // GET: Clients/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = await db.Clients.FindAsync(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name")] Client client)
        {
            if (ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(client);
        }

        // Action method to update company record to database.
        // Accecpt only HTTP POST request from client side.
        // DataSourceRequest is aded into the method for the auto creation of KendoUI grid parameters like page, index etc.
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Update([DataSourceRequest] DataSourceRequest request, Client client)
        {
            // Test if company object and modelstate is valid.
            if (client != null && ModelState.IsValid)
            {
                // Update client to UoW.
                db.Entry(client).State = EntityState.Modified;
                // Save updated client to database using UoW.
                db.SaveChanges();
            }
            // Return modelstate info back to client side in json format.
            return Json(ModelState.ToDataSourceResult());
        }
 
        // GET: Clients/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = await db.Clients.FindAsync(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Client client = await db.Clients.FindAsync(id);
            db.Clients.Remove(client);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingInline_Destroy([DataSourceRequest] DataSourceRequest request, Client client)
        {
            if (client != null && ModelState.IsValid)
            {
                //Client client2 = db.Clients.Find(client.Id);
                //db.Clients.Remove(client2);
                db.Entry(client).State = EntityState.Deleted;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return Json(new[] { client }.ToDataSourceResult(request, ModelState));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
