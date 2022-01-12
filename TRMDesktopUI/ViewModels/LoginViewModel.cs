using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using TRMDesktopUI.Helpers;
using TRMDesktopUI.Models;

namespace TRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;
        private IApiHelper _apiHelper;

        public LoginViewModel(IApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }
        public bool CanLogIn
        {
            get { return UserName?.Length > 0 && Password?.Length > 0 ? true : false; }
        }

        public async Task<AuthenticatedUser> LogIn() 
        {
            try
            {
                return await _apiHelper.Authenticate(UserName, Password);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
