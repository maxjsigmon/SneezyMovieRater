using MovieRater.Data;
using MovieRater.Models.Movie;
using SneeziMovieRater.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services
{
    public class MovieService
    {
        private readonly Guid _userId;

        public MovieService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateMovie(MovieCreate model)
        {
            var entity =
                new Movie()
                {
                    AuthorId = _userId,
                    Title = model.Title,
                    Description = model.Description,
                    RunTime = model.RunTime,
                    MaturityRating = model.MaturityRating
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Movie.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<MovieListItem> GetMoviePosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Movie
                        .Where(movie => movie.AuthorId == _userId)
                        .Select(
                            movie =>
                                new MovieListItem
                                {
                                    Title = movie.Title,
                                    Description = movie.Description,
                                    MaturityRating = movie.MaturityRating,
                                    RunTime = movie.RunTime
                                }
                        ); ;

                return query.ToArray();
            }
        }
    }
}
