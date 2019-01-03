using PropertyChanged;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RestaurantUI
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #region Command Helpers
        
        //Runs a command if the updating flag is not set.
        //If the flag is true (indicating the function is already running) then the action is not run.
        //If the flag is false (indicating no running function) then the action is run.
        //Once the action is finished if it was run, then the flag is reset to false
        protected async Task RunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            // Check if the flag property is true (meaning the function is already running)
            if (ExpressionHelpers.GetPropertyValue(updatingFlag))
                return;

            // Set the property flag to true to indicate we are running
            ExpressionHelpers.SetPropertyValue(updatingFlag, true);

            try
            {
                // Run the passed in action
                await action();
            }
            finally
            {
                // Set the property flag back to false now it's finished
                ExpressionHelpers.SetPropertyValue(updatingFlag, false);
            }
        }

        #endregion
    }
}
