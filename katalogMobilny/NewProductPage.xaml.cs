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
        object sender,
        EventArgs e)
    {
        if (KategoriaPicker.SelectedItem is string kategoria)
        {
            EtykietaWyniku.Text = $"Kategoria: {kategoria}";
        }
    }

    private void NowyProdukt_Clicked(object sender, EventArgs e)
    {
        if (!double.TryParse(CenaEntry.Text, out double cena))
        {
            EtykietaWyniku.Text = "Niepoprawna cena";
            return;
        }

        if (cena < 0)
        {
            EtykietaWyniku.Text = "Niepoprawna cena";
            return;
        }
        if (!int.TryParse(IloscEntry.Text, out int ilosc))
        {
            EtykietaWyniku.Text = "Niepoprawna ilość";
            return;
        }

        double wartosc = cena * ilosc;
        string? nazwa = NazwaEntry.Text;
        if (string.IsNullOrWhiteSpace(nazwa))
        {
            EtykietaWyniku.Text = "Nazwa nie może być pusta";
            return;
        }

        if (KategoriaPicker.SelectedItem == null)
        {
            EtykietaWyniku.Text = "Wybierz kategorię";
            return;
        }

        EtykietaWyniku.Text = $"Produkt: {nazwa}, Cena: {cena}, Ilość: {ilosc}, " + $" Kategoria:" +
            $" {KategoriaPicker.SelectedItem}, Wartość: {wartosc}";
    }

    private void CenaEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Entry s = (Entry)sender;

        if (double.TryParse(s.Text, out double wartosc))
        {
            s.BackgroundColor = wartosc < 0
                ? Colors.Red
                : Colors.Green;
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

        if (!int.TryParse(IloscEntry.Text, out _))
        {
            EtykietaWyniku.Text = "Niepoprawna ilość";
            return;
        }
    }

}
