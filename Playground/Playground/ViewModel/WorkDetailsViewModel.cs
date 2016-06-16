using System;

using Xamarin.Forms;

namespace Playground.ViewModel
{
    public class WorkDetailsViewModel : ContentPage
    {
        public WorkDetailsViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


