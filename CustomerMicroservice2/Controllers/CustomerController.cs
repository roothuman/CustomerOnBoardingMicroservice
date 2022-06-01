using CustomerMicroservice2.Database;
using CustomerMicroservice2.Database.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerMicroservice2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>

        DatabaseContext Db;
        public CustomerController()
        {
            Db = new DatabaseContext();
        }
        [HttpGet]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return Db.Customers.ToList();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public IActionResult OnBoardNewCustomer([FromBody] Customer model)
        {
            try
            {
                Db.Customers.Add(model);
                Db.SaveChanges();

                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        
    }
}
