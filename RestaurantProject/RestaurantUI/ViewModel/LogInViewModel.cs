using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RestaurantUI
{
    public class LogInViewModel : BaseViewModel
    {
        #region Private properties
        private string email;
        #endregion

        #region Public properties
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;

                if (email.Length < 5)
                    MessageBox.Show("cao");
            }
        }
        
        //A flag indicating if the login command is running
        public bool LoginIsRunning { get; set; }
        #endregion

        #region Commands
        public ICommand LogInCommand { get; set; }
        #endregion

        public LogInViewModel()
        {
            LogInCommand = new BaseParameterizedCommand(async (parameter) => await Login(parameter));
        }
        
        //Attempts to log the user in
        public async Task Login(object parameter)
        {
            
        }
    }
}
