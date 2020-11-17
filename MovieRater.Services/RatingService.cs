﻿using MovieRater.Data;
using MovieRater.Models;
using MovieRater.Models.Rating;
using SneeziMovieRater.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services
{
    public class RatingService
    {
        private readonly Guid _userId;

        public RatingService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateRating(RatingCreate model)
        {
            var entity = new Rating()
            {
                AuthorId = _userId,
                Rate = model.Rate,
                ReviewDescription = model.ReviewDescription

            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Ratings.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<RatingListItem> GetRatings()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Ratings
                    .Where(rating => rating.AuthorId == _userId)
                    .Select(rating => new RatingListItem
                    {
                        RatingId = rating.RatingId,
                        Rate = rating.Rate,
                        ReviewDescription = rating.ReviewDescription
                    });
                
                return query.ToArray();
                    
            }
        }
    }
}
