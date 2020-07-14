using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Models;

namespace MyProject.Repository
{
    public class Userrepository : RepositoryUser
       
    {
        public DataContext dbdata;
        public Userrepository(DataContext data)
        {
            dbdata = data;
        }
         public List<User> Get()
        {
            return dbdata.users.ToList();
        }

        public void AddUser(User Userdata)
        {
            dbdata.users.Add(Userdata);
        }

        public void Delete(User user)
        {
            dbdata.users.Remove(user);
        }

        public  async Task<bool> SaveChanges()
        {
            return await dbdata.SaveChangesAsync() > 0;
        }

        public User GetDetails(int id)
        {
            return dbdata.users.FirstOrDefault(p => p.Id == id);
        }
        public User GetFirstName(string firstname) {

            return dbdata.users.FirstOrDefault(q=> q.FirstName == firstname);
        }

        public User GetPassword(string password) {

            return dbdata.users.FirstOrDefault(r => r.Password == password);
        }
    }
}
