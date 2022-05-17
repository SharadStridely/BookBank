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
    public class OrdersController : ControllerBase
    {
        private readonly GenericRepository<Order> genericRepository;
        public OrdersController(GenericRepository<Order> genericRepository)
        {
            this.genericRepository = genericRepository;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public async Task<IEnumerable<Order>> Get()
        {
            return await genericRepository.GetAll();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return genericRepository.GetById(id);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post(Order order)
        {
            genericRepository.Add(order);
            genericRepository.Save();
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, Order order)
        {
            genericRepository.Modify(order);
            genericRepository.Save();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Order order = genericRepository.GetById(id);
            genericRepository.Remove(order);
            genericRepository.Save();
        }
    }
}
