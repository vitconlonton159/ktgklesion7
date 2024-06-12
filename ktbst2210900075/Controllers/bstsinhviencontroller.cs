using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using baiktragiuaki.Models;

namespace baiktragiuaki.Controllers
{
    public class bstSinhViensController : Controller
    {
        private QLDEntities db = new QLDEntities();

        // GET: bstSinhViens
        public ActionResult bstIndex()
        {
            var sinhVien = db.SinhVien.Include(s => s.Khoa);
            return View(sinhVien.ToList());
        }

        // GET: bstSinhViens/Details/5
        public ActionResult bstDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhVien.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            return View(sinhVien);
        }

        // GET: bstSinhViens/Create
        public ActionResult bstCreate()
        {
            ViewBag.MAKHOA = new SelectList(db.Khoa, "bstMAKHOA", "bstTENKHOA");
            return View();
        }

        // POST: bstSinhViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult bstCreate([Bind(Include = "bstMASV,bstHOSV,bstTENSV,bstPHAI,bstNS,bstMAKHOA")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                db.SinhVien.Add(sinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MAKHOA = new SelectList(db.Khoa, "htqMAKHOA", "bstTENKHOA", sinhVien.MAKHOA);
            return View(sinhVien);
        }

        // GET: bstSinhViens/Edit/5
        public ActionResult bstEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SinhVien sinhVien = db.SinhVien.Find(id);
            if (sinhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.MAKHOA = new SelectList(db.Khoa, "bstMAKHOA", "bstTENKHOA", sinhVien.MAKHOA);
            return View(sinhVien);
        }

        // POST: bstSinhViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult bstEdit([Bind(Include = "htqMASV,bstHOSV,bstTENSV,bstPHAI,bstNS,bstMAKHOA")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sinhVien).State = EntityState.Modified;