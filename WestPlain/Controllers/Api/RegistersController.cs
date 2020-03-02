using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WestPlain.Dtos;
using WestPlain.Models;

namespace WestPlain.Controllers.Api
{
    public class RegistersController : ApiController
    {
        private ApplicationDbContext _context;

        public RegistersController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetRegisters()
        {
            var registerDto = _context.Registers.Include(r => r.BusinessType).ToList().Select(Mapper.Map<Register, RegisterDto>);

            return Ok(registerDto);
        }

        [HttpPost]
        public IHttpActionResult CreateRegister(RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var register = Mapper.Map<RegisterDto, Register>(registerDto);
           
            _context.Registers.Add(register);
            _context.SaveChanges();
            registerDto.Id = register.Id;

            return Created(new Uri(Request.RequestUri + "/" + register.Id), registerDto);
        }
    }
}
