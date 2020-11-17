using Microsoft.AspNet.Identity;
using MovieRater.Models.Show;
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
    public class ShowController : ApiController
    {
        private ShowService CreateShowService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var showService = new ShowService(userId);
            return showService;
        }

        public IHttpActionResult Post(ShowCreate show)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateShowService();

            if (!service.CreateShow(show))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get()
        {
            ShowService showService = CreateShowService();
            var shows = showService.GetShows();
            return Ok(shows);
        }

        //public IHttpActionResult Get(int id)
        //{
        //    ShowService showService = CreateShowService();
        //    var show = showService.GetShowById(id);
        //    return Ok(show);
        //}
    }
}
