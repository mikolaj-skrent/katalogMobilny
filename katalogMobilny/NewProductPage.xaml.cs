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
        licznik++;
        EtykietaWyniku.Text = $"Kliknięto {licznik} razy";
    }
}