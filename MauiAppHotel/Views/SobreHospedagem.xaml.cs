namespace MauiAppHotel.Views;

public partial class SobreHospedagem : ContentPage
{
	public SobreHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            DisplayAlertAsync("Ops", ex.Message, "OK");
        }
    }
}