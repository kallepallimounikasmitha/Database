using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyProject.Models;

namespace MyProject.Repository
{
    public interface RepositoryUser
    {
        public List<User> Get();

       public User GetDetails(int id);

        public User GetFirstName(string firstname);

        public User GetPassword(string password);

        public void AddUser(User Userdata);

        public Task<bool> SaveChanges();

        public void Delete(User user);
    }
}
