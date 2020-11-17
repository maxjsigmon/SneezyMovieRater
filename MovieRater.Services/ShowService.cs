using MovieRater.Data;
using MovieRater.Models.Show;
using SneeziMovieRater.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services
{
   public class ShowService
    {
        private readonly Guid _userId;
        public ShowService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateShow(ShowCreate model)
        {
            var entity =
                new Show()
                {
                    AuthorId = _userId,
                    Title = model.Title,
                    Description = model.Description,
                    MaturityRating = model.MaturityRating,
                    SeasonCount = model.SeasonCount
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Shows.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ShowListItem> GetShows()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Shows
                        .Where(e => e.AuthorId == _userId)
                        .Select(
                            e =>
                                new ShowListItem
                                {
                                    Title = e.Title,
                                    Description = e.Description,
                                    MaturityRating = e.MaturityRating,
                                    SeasonCount = e.SeasonCount
                                }
                        );

                return query.ToArray();
            }
        }
    }
}
