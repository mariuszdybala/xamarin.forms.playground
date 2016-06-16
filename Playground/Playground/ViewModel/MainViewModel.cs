using GalaSoft.MvvmLight;

namespace Playground.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public string Title { get; set; }

        public MainViewModel()
        {
            //IsInDesignMode
            Title = "Well Done It !";
        }
    }
}