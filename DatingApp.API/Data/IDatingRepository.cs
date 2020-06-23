using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         ///Returns true or false in case of data save
         Task<bool> SaveAll();
         ///Get list of all user
         Task<IEnumerable<User>> GetUsers();
         ///get single user
         Task<User> GetUser(int id);
    }
}