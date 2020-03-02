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
    public class ContactsController : ApiController
    {
        private ApplicationDbContext _context;

        public ContactsController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetContacts()
        {
            var contactDto = _context.Contacts.ToList().Select(Mapper.Map<Contact, ContactDto>);

            return Ok(contactDto);
        }

        [HttpPost]
        public IHttpActionResult CreateContact(ContactDto contactDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var contact = Mapper.Map<ContactDto, Contact>(contactDto);

            _context.Contacts.Add(contact);
            _context.SaveChanges();
            contactDto.Id = contact.Id;

            return Created(new Uri(Request.RequestUri + "/" + contact.Id), contactDto);
        }
    }
}
