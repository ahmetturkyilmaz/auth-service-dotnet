using auth_service_dotnet.Entities;
using auth_service_dotnet.Models;
using System.Collections.Generic;

namespace auth_service_dotnet.service
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password = null);
        void Delete(int id);
    }
}
