﻿using _2.OdeToFood4.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2.OdeToFood4.Controllers
{
    public class ReviewsController : Controller
    {

        OdeToFoodDb _db = new OdeToFoodDb();
        // GET: Reviews
        public ActionResult Index([Bind(Prefix="id")]int restaurandId)
        {
            var restaurant = _db.Restaurants.Find(restaurandId);
            if (restaurant != null)
            {
                return View(restaurant);
            }
                return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestaurantReview review)
        {
            if (ModelState.IsValid)
            {
                _db.Reviews.Add(review);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }

        [HttpGet]
        public ActionResult Edit (int id)
        {
            var model = _db.Reviews.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit (RestaurantReview review)
        {
            if(ModelState.IsValid)
            {
                _db.Entry(review).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = review.RestaurantId });
            }
            return View(review);
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
