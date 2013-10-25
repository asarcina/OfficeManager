using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OfficeManager.DAL;
using OfficeManager.DataLayerModel;
using OfficeManager.LowMapper;

namespace OfficeManager.DataManager
{
    public class UserManager
    {
        private readonly DownMapper mapper;
        private readonly LoginManager loginManager;

        public UserManager()
        {
            mapper = new DownMapper();
            loginManager = new LoginManager();
        }

        public UserModel GetUserById(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                User user = uow.UserRepository.GetById(id);
                UserModel result = mapper.Mapping<UserModel>(user);
                return result;
            }
        }

        public List<UserModel> GetUsers()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                List<User> users = uow.UserRepository.Get().ToList();
                List<UserModel> usersModel = users.Select(user => mapper.Mapping<UserModel>(user)).ToList();
                return usersModel;
            }
        }

        public List<UserModel> GetUserBySurname(string surname)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                List<User> users = uow.UserRepository.Get(filter:q=>q.Surname.Equals(surname,StringComparison.InvariantCultureIgnoreCase)).ToList();
                List<UserModel> usersModel = users.Select(user => mapper.Mapping<UserModel>(user)).ToList();
                return usersModel;
            }
        }

        public int Insert(UserModel newUser)
        {
            User user = mapper.Mapping<User>(newUser);

            using (UnitOfWork uow = new UnitOfWork())
            {
                //TODO: Verificare univocità alcune voci di User e Login
                if (loginManager.LoginExist(user.Login))
                {
                    return 0;
                }
                uow.UserRepository.Insert(user);
                uow.Save();
                return user.UserId;
            }
        }
    }
}
