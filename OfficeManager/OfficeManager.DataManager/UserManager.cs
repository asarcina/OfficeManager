using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OfficeManager.DAL;
using OfficeManager.DataLayerModel;

namespace OfficeManager.DataManager
{
    public class UserManager
    {
        public UserModel GetUserById(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                User user = uow.UserRepository.GetById(id);
                UserModel result = new UserModel(user);
                return result;
            }
        }

        public List<UserModel> GetUsers()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                List<User> users = uow.UserRepository.Get().ToList();
                List<UserModel> usersModel = users.Select(user => new UserModel(user)).ToList();
                return usersModel;
            }
        }

        public List<UserModel> GetUserBySurname(string surname)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                List<User> users = uow.UserRepository.Get(filter:q=>q.Surname.Equals(surname,StringComparison.InvariantCultureIgnoreCase)).ToList();
                List<UserModel> usersModel = users.Select(user => new UserModel(user)).ToList();
                return usersModel;
            }
        }
    }
}
