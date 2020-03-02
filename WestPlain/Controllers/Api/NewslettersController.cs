using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WestPlain.Dtos;
using WestPlain.Models;

namespace WestPlain.Controllers.Api
{
    public class NewslettersController : ApiController
    {
        private ApplicationDbContext _context;

        public NewslettersController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetNewsletters()
        {
            var newsletterDto = _context.Newsletters.ToList().Select(Mapper.Map<Newsletter, NewsletterDto>);
            return Ok(newsletterDto);
        }

        [HttpPost]
        public IHttpActionResult CreateNewsletter(NewsletterDto newsletterDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var newsletter = Mapper.Map<NewsletterDto, Newsletter>(newsletterDto);

            _context.Newsletters.Add(newsletter);
            _context.SaveChanges();
            newsletterDto.Id = newsletter.Id;

            return Created(new Uri(Request.RequestUri + "/" + newsletter.Id), newsletterDto);
        }
    }
}
