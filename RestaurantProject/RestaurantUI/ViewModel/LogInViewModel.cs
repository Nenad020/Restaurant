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
        #region Public Properties

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
            if (parameter == null && (parameter is Object[]) == false)
                return;
            Object[] parameters = parameter as Object[];

            await RunCommand(() => LoginIsRunning, async () =>
            {
                await Task.Delay(5000);

                var email = parameters[0];
                var pass = SecureStringHelpers.Unsecure((parameters[1] as IPassword).SecurePassword);
            });
        }
    }
}
