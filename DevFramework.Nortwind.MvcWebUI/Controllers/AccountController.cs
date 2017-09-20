using DevFramework.Core.CrossCuttingConcerns.Security.Web;
using System;
using System.Web.Mvc;
using DevFramework.Nortwind.Business.Abstract;

namespace DevFramework.Nortwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        // GET: Account
        public string Login(string UserName,string password)
        {
            var user = _userService.GetByUserNameAndPassword(UserName, password);
            if (user!= null) 
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(), user.UserName,
                    user.Email,
                    DateTime.Now.AddDays(15),
                    new[] {"Student"},
                    false,
                    user.FirstName,
                    user.LastName);
                return "User is authenticated!";
            }
            return "User is NOT authenticated";
        }
    }
}