using Microsoft.AspNet.Identity;
using MovieRater.Models.Movie;
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
    public class MovieController : ApiController
    {
        private MovieService CreateMovieService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var postService = new MovieService(userId);
            return postService;
        }

        public IHttpActionResult Post(MovieCreate movie)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateMovieService();

            if (!service.CreateMovie(movie))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get()
        {
            MovieService movieService = CreateMovieService();
            var posts = movieService.GetMoviePosts();
            return Ok(posts);
        }
    }
}
