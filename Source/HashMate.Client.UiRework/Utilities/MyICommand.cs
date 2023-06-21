using System;
using System.Windows.Input;

namespace HashMate.Client.UiRework.Utilities
{
    public class MyICommand : ICommand
    {
        private Action<object> _TargetExecuteMethod;

        private Predicate<object> _TargetCanExecuteMethod;

        public event EventHandler CanExecuteChanged = delegate
        {
        };

        public MyICommand(Action<object> executeMethod)
        {
            _TargetExecuteMethod = executeMethod;
        }

        public MyICommand(Action<object> executeMethod, Predicate<object> canExecuteMethod)
        {
            _TargetExecuteMethod = executeMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            this.CanExecuteChanged(this, EventArgs.Empty);
        }

        public bool CanExecute(object parameter)
        {
            if (_TargetCanExecuteMethod != null)
            {
                return _TargetCanExecuteMethod(parameter);
            }

            if (_TargetExecuteMethod != null)
            {
                return true;
            }

            return false;
        }

        public void Execute(object parameter)
        {
            _TargetExecuteMethod?.Invoke(parameter);
        }
    }
}
