
namespace katalogMobilny;

public partial class NewProductPage : ContentPage
{
    private int licznik;

    public NewProductPage()
    {
        InitializeComponent();
    }

    private void NazwaEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var liczbaZnakow = e.NewTextValue?.Length ?? 0;
        EtykietaWyniku.Text = $"Nazwa ma {liczbaZnakow} znaków";
    }

    private void NazwaEntry_Completed(object sender, EventArgs e)
    {
        var liczbaZnakow = NazwaEntry.Text?.Length ?? 0;
        EtykietaWyniku.Text = $"Nazwa ma {liczbaZnakow} znaków";
    }

    private void AvailableSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        DostepnoscLabel.Text = e.Value
            ? "Produkt dostępny"
            : "Produkt niedostępny";
    }

    private void KategoriaPicker_SelectedIndexChanged(
        object sender, EventArgs e)
    {
        if (KategoriaPicker.SelectedItem is string kategoria)
        {
            EtykietaWyniku.Text = $"Kategoria: {kategoria}";
        }
    }

    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NazwaEntry.Text))
        {
            EtykietaWyniku.Text = "Nazwa nie może być pusta";
            return;
        }

        if (!double.TryParse(CenaEntry.Text, out double cena))
        {
            EtykietaWyniku.Text = "Niepoprawna cena";
            return;
        }

        if (cena < 0)
        {
            EtykietaWyniku.Text = "Cena nie może być ujemna";
            return;
        }

        if (!int.TryParse(IloscEntry.Text, out int ilosc))
        {
            EtykietaWyniku.Text = "Niepoprawna ilość";
            return;
        }

        if (ilosc < 0)
        {
            EtykietaWyniku.Text = "Ilość nie może być ujemna";
            return;
        }

        if (KategoriaPicker.SelectedItem == null)
        {
            EtykietaWyniku.Text = "Wybierz kategorię";
            return;
        }

        double wartosc = cena * ilosc;
        string nazwa = NazwaEntry.Text;

        EtykietaWyniku.Text =
            $"Produkt: {nazwa}, Cena: {cena}, Ilość: {ilosc}, " +
            $"Kategoria: {KategoriaPicker.SelectedItem}, " +
            $"Wartość: {wartosc}";
    }

    private void CenaEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Entry s = (Entry)sender;

        if (double.TryParse(s.Text, out double wartosc) && wartosc >= 0)
        {
            s.BackgroundColor = Colors.Green;
        }
        else
        {
            s.BackgroundColor = Colors.Red;
        }

        if (!double.TryParse(CenaEntry.Text, out _))
        {
            EtykietaWyniku.Text = "Niepoprawna cena";
            return;
        }
    }

    private async void Powrot_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}
