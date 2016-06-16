using Playground.ViewModel;
using Playground.Views;
using Xamarin.Forms;

namespace Playground
{
    public partial class App : Application
    {
        private static readonly ViewModelLocator _locator = new ViewModelLocator();

        public static ViewModelLocator Locator { get { return _locator; } }

        public App()
        {
            InitializeComponent();
            MainPage = new Main();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

