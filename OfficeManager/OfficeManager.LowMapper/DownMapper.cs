using System;
using OfficeManager.DAL;
using OfficeManager.DataLayerModel;

namespace OfficeManager.LowMapper
{
    public class DownMapper
    {
        public T Mapping<T>(object source) where T : class
        {
            Type destinationType = typeof (T);
            Object result;
            if (source == null)
            {
                return default(T);
            }
            switch (destinationType.Name)
            {
                case "User":
                    result = MapUserModelToUser((UserModel) source);
                    break;
                case "UserModel":
                    result = MapUserToUserModel((User) source);
                    break;
                case "Login":
                    result = MapLoginModelToLogin((LoginModel) source );
                    break;
                case "LoginModel":
                    result = MapLoginToLoginModel((Login) source);
                    break;
                default:
                    throw  new TypeLoadException(string.Format("Cannot map source type {0} in type {1}",source.GetType().Name,destinationType.Name));
            }

            return (T) result;
        }

        private LoginModel MapLoginToLoginModel(Login source)
        {
            LoginModel result = new LoginModel
                                {
                                    Create = source.Create,
                                    Enabled = source.Enabled,
                                    LoginId = source.LoginId,
                                    Password = source.Password,
                                    UserName = source.UserName
                                };
            return result;
        }

        private Login MapLoginModelToLogin(LoginModel source)
        {
            Login result = new Login
            {
                Create = source.Create,
                Enabled = source.Enabled,
                LoginId = source.LoginId,
                Password = source.Password,
                UserName = source.UserName
            };
            return result;
        }

        private UserModel MapUserToUserModel(User source)
        {
           UserModel result = new UserModel();
            result.Name = source.Name;
            result.Surname = source.Surname; 
            result.Sex = source.Sex;
            result.UserId = source.UserId;
            result.Login = Mapping<LoginModel>(source.Login);
            return result;
        }

        private User MapUserModelToUser(UserModel source)
        {
            User result = new User();
            result.Surname = source.Surname;
            result.Sex = source.Sex;
            result.Name = source.Name;
            result.UserId = source.UserId;
            result.Login = Mapping<Login>(source.Login);
            return result;
        }
    }
}
