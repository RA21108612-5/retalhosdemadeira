using retalhosdemadeira.Services;

namespace retalhosdemadeira.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (!LoginServices.IsLogged)
            {
                OpenLogin();
            }
        }
        private async void OpenLogin()
        {
            await Navigation.PushModalAsync(new Login());

        }
    }
}
