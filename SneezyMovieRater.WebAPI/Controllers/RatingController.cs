﻿using Microsoft.AspNet.Identity;
using MovieRater.Models;
using MovieRater.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SneezyMovieRater.WebAPI.Controllers
{
    [Authorize]
    public class RatingController : ApiController
    {
        private RatingService CreateRatingService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var ratingService = new RatingService(userId);
            return ratingService;
        }

        public IHttpActionResult Get()
        {
            RatingService ratingService = CreateRatingService();
            var ratings = ratingService.GetRatings();
            return Ok(ratings);
        }

        public IHttpActionResult Post(RatingCreate rating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var service = CreateRatingService();

            if (!service.CreateRating(rating))
            {
                return InternalServerError();
            }

            return Ok();
        }
    }
}
