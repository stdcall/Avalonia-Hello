using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
namespace MyApp.ViewModels
{

    
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Hello World!";
        public ReactiveCommand TestCommand { get; set;}

        public MainWindowViewModel()
        {
            TestCommand = ReactiveCommand.Create(() => {});
        }
    }
}
