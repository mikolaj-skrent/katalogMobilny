namespace katalogMobilny
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            //alternatywne tworzenie elementów interfejsu zamiast
            //xamla - tego nie robimy!
            //Label etykieta = new Label();
            //etykieta.Text = "Procesor";
            //etykieta.Parent = MainLayout;
        }

        private void PokazClicked(object sender, EventArgs e)
        {
            EtykietaWyniku.Text = "Wybrano procesor";
        }

        /*
        private void CounterBtn_Clicked(object sender, EventArgs e)
        {
            count++;
            EtykietaPowitania.Text = $"Kliknięto {count} razy";
        }
        */
    }
}






        //private void OnCounterClicked(object? sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterLabel.Text = $"Clicked {count} time";
        //    else
        //        CounterLabel.Text = $"Clicked {count} times";
        //    bot_image.Source = "lazerdim.jpg";

        //    SemanticScreenReader.Announce(CounterLabel.Text);
        //}


    }
}
