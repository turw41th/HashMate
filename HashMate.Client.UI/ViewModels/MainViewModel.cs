using HashMate.Client.UI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMate.Client.UI.ViewModels
{
    public class MainViewModel : BaseNotifier
    {
        private BaseNotifier currentViewModel;

        public BaseNotifier CurrentViewModel { get => currentViewModel; set => SetProperty(ref currentViewModel, value); }
        public TextToHashViewModel TextToHashViewModel { get; set; }
        public FileToHashViewModel FileToHashViewModel { get; set; }

        public MainViewModel()
        {
            TextToHashViewModel = new TextToHashViewModel();
            FileToHashViewModel = new FileToHashViewModel();
        }
    }
}
