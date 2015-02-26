using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using Purevision.Web.DataContexts;
using Purevision.Web.Models;

namespace Purevision.Web.Controllers
{
    public class MeetingsController : Controller
    {
        private PurevisionDb db = new PurevisionDb();
        private SchedulerMeetingService meetingService;


        public MeetingsController()
        {
            this.meetingService = new SchedulerMeetingService();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Partial()
        {
            return PartialView("_meetingsPartial");
        }


        // GET: Meetings
        public async Task<ActionResult> Index()
        {
            var meetings = db.Meetings.Include(m => m.Meeting1);
            return View(await meetings.ToListAsync());
        }

        // GET: Meetings/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meeting meeting = await db.Meetings.FindAsync(id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            return View(meeting);
        }

        // GET: Meetings/Create
        public ActionResult Create()
        {
            ViewBag.RecurrenceID = new SelectList(db.Meetings, "MeetingID", "Title");
            return View();
        }

        // POST: Meetings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MeetingID,Start,End,Title,Description,RoomID,IsAllDay,RecurrenceRule,RecurrenceID,RecurrenceException,StartTimezone,EndTimezone")] Meeting meeting)
        {
            if (ModelState.IsValid)
            {
                db.Meetings.Add(meeting);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.RecurrenceID = new SelectList(db.Meetings, "MeetingID", "Title", meeting.RecurrenceID);
            return View(meeting);
        }

        // GET: Meetings/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meeting meeting = await db.Meetings.FindAsync(id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            ViewBag.RecurrenceID = new SelectList(db.Meetings, "MeetingID", "Title", meeting.RecurrenceID);
            return View(new MeetingViewModel {
                MeetingID = meeting.MeetingID,
                Start = meeting.Start.ToLocalTime(),
                End = meeting.End.ToLocalTime(),
                Title = meeting.Title,
                Description = meeting.Description,
                RoomID = meeting.RoomID,
                IsAllDay = meeting.IsAllDay,
                RecurrenceRule = meeting.RecurrenceRule,
                RecurrenceID = meeting.RecurrenceID,
                RecurrenceException = meeting.RecurrenceException,
                StartTimezone = meeting.StartTimezone,
                EndTimezone = meeting.EndTimezone
                });
        }

        // POST: Meetings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MeetingID,Start,End,Title,Description,RoomID,IsAllDay,RecurrenceRule,RecurrenceID,RecurrenceException,StartTimezone,EndTimezone")] MeetingViewModel meeting)
        {
            if (ModelState.IsValid)
            {
                Meeting meeting2 = await db.Meetings.FindAsync(meeting.MeetingID);
                if (meeting2 != null)
                {
                    meeting2.Start = meeting.Start.ToLocalTime();
                    meeting2.End = meeting.End.ToLocalTime();
                    meeting2.Title = meeting.Title;
                    meeting2.Description = meeting.Description;
                    meeting2.RoomID = meeting.RoomID;
                    meeting2.IsAllDay = meeting.IsAllDay;
                    meeting2.RecurrenceRule = meeting.RecurrenceRule;
                    meeting2.RecurrenceID = meeting.RecurrenceID;
                    meeting2.RecurrenceException = meeting.RecurrenceException;
                    meeting2.StartTimezone = meeting.StartTimezone;
                    meeting2.EndTimezone = meeting.EndTimezone;
                }
                db.Entry(meeting2).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.RecurrenceID = new SelectList(db.Meetings, "MeetingID", "Title", meeting.RecurrenceID);
            return View(meeting);
        }

        // GET: Meetings/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Meeting meeting = await db.Meetings.FindAsync(id);
            if (meeting == null)
            {
                return HttpNotFound();
            }
            return View(meeting);
        }

        // POST: Meetings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Meeting meeting = await db.Meetings.FindAsync(id);
            db.Meetings.Remove(meeting);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Kendo Scheduler CRUD
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        
        public virtual JsonResult Meeting_Create([DataSourceRequest] DataSourceRequest request, MeetingViewModel meeting)
        {
            if (ModelState.IsValid)
            {
                meetingService.Insert(meeting, ModelState);
            }

            return Json(new[] { meeting }.ToDataSourceResult(request, ModelState));
        }

        public virtual JsonResult Meeting_Read([DataSourceRequest] DataSourceRequest request)
        {
            JsonResult result = Json(meetingService.GetAll().ToDataSourceResult(request));
            return result;
        }

        public virtual JsonResult Meeting_Update([DataSourceRequest] DataSourceRequest request, MeetingViewModel meeting)
        {
            if (ModelState.IsValid)
            {
                meetingService.Update(meeting, ModelState);
            }

            return Json(new[] { meeting }.ToDataSourceResult(request, ModelState));
        }

        public virtual JsonResult Meeting_Destroy([DataSourceRequest] DataSourceRequest request, MeetingViewModel meeting)
        {
            if (ModelState.IsValid)
            {
                meetingService.Delete(meeting, ModelState);
            }

            return Json(new[] { meeting }.ToDataSourceResult(request, ModelState));
        }
    }
}
