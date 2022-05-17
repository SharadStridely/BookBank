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
    public class BooksController : ControllerBase
    {
        private readonly GenericRepository<Book> genericRepository;
        public BooksController(GenericRepository<Book> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        // GET: api/<BooksController>
        [HttpGet]
        public Task<IEnumerable<Book>> Get()
        {
            return genericRepository.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return genericRepository.GetById(id);
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post(Book book)
        {
            genericRepository.Add(book);
            genericRepository.Save();
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, Book book)
        {
            genericRepository.Modify(book);
            genericRepository.Save();
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Book book = genericRepository.GetById(id);
            genericRepository.Remove(book);
            genericRepository.Save();
        }
    }
}
