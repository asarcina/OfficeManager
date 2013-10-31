using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using OfficeManager.DataLayerModel;
using OfficeManager.DataManager;

namespace OfficeManager.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public WcfResult<List<UserModel>> GetAllUser()
        {
            WcfResult<List<UserModel>> result = new WcfResult<List<UserModel>>();
            try
            {
                UserManager userManager= new UserManager();
                List<UserModel> users = userManager.GetUsers();
                result.Value = users;
                result.Success = true;
                result.ResultCode = 0;
            }
            catch (Exception e)
            {
                result.Exception= new ExceptionInfo(e);
                result.ResultMessage = e.Message;
                result.ResultCode = 1;
                result.Success = false;

            }
            return result;
        }
        
    }
}
