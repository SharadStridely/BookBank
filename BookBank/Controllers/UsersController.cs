using DataAccessLayer_BookBank.Models;
using DataAccessLayer_BookBank.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly GenericRepository<User> genericRepository;

        public UsersController(GenericRepository<User> genericRepository)
        {
            this.genericRepository = genericRepository;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await genericRepository.GetAll();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return genericRepository.GetById(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post(User user)
        {
            genericRepository.Add(user);
            genericRepository.Save();
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, User user)
        {
            genericRepository.Modify(user);
            genericRepository.Save();
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            User user = genericRepository.GetById(id);
            genericRepository.Remove(user);
            genericRepository.Save();
        }
    }
}
