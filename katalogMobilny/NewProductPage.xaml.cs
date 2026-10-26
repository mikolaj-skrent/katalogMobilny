namespace katalogMobilny;

public partial class NewProductPage : ContentPage
{
    private int licznik = 0;
    public NewProductPage()
		
		private void NowyProdukt_Clicked(object sender, EventArgs e)
	{
		licznik++;
		EtykietaWyniku.Text = $"Kliknięto {licznik} razy"; 
	}
	

	
		InitializeComponent();
	
}