using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
using MyProject.Repository;

namespace MyProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly RepositoryUser _repo;
        // List<Userdet> UserList;
        public AuthController(RepositoryUser userrepo)
        {

            _repo = userrepo;


        }
        [HttpGet]
        public List<User> Get()
        {
            return _repo.Get();
        }

        [HttpGet("{id}")]
        public User Getdetails(int id)

        {
            return _repo.GetDetails(id);

        }

         [HttpGet("api/{firstname}")]
           public User FirstName(string firstname)

           {
               return _repo.GetFirstName(firstname);

           } 

           [HttpGet("ap/{password}")]
           public User Password(string password)

           {
               return _repo.GetPassword(password);

           }
 

        [HttpPost]
        public async Task<IActionResult> Post(User user)
        {
            if (user != null)
            {
                _repo.AddUser(user);
                if (await _repo.SaveChanges())
                {
                    return Created($"api/AuthController/{user.Id}", user);
                }



            }
            return BadRequest("Failed");
        }

          [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                if (id > 0)
                {
                    User data = _repo.GetDetails(id);
                    _repo.Delete(data);
                    if (await _repo.SaveChanges())
                    {
                    return NoContent();
                    }
                }
            return BadRequest("Failed");


            }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, User user)
        {
    
                User data = _repo.GetDetails(id);
                data.Email = user.Email;
            data.FirstName = user.FirstName;

            if (await _repo.SaveChanges())
            {
                return NoContent();
            }
            else {
                return BadRequest("Failed");

            }
           
            


        }




    }



        /* [HttpGet]
         public List<Userdet> get() {
             return UserList;

         }
         [HttpGet("{id}")]
         public Userdet getUser(string id) {
             return UserList.FirstOrDefault(p => p.id == id);

         }*/


    
    
}