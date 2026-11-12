
namespace katalogMobilny
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void PokazClicked(object sender, EventArgs e)
        {
            EtykietaWyniku.IsVisible = true;
            EtykietaWyniku.Text = "Wybrano procesor";
        }

        private void UkryjClicked(object sender, EventArgs e)
        {
            EtykietaWyniku.IsVisible = false;
        }
    }
}
