using System;
using System.Diagnostics;
using BlankXamlApp1.ViewModels.Base;

namespace BlankXamlApp1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _firstName;
        private int _age;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        private readonly Lazy<DelegateCommand<string>> _helloWorldCommand;
        public DelegateCommand<string> HelloWorldCommand => _helloWorldCommand.Value;

        public MainViewModel()
        {
            FirstName = "Sergio";
            Age = 40;
            _helloWorldCommand = new Lazy<DelegateCommand<string>>(() =>
                new DelegateCommand<string>(CanExecuteHelloWorldCommand, ExecuteHelloWorldCommand));
        }
        

        public bool CanExecuteHelloWorldCommand(string parameter)
        {
            if (string.IsNullOrWhiteSpace(parameter))
                return false;
            return FirstName.StartsWith("Sergio");
        }

        public void ExecuteHelloWorldCommand(string parameter)
        {
            Debug.WriteLine(parameter);
        }
    }
}
