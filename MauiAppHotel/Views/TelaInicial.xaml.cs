namespace MauiAppHotel.Views;

public partial class TelaInicial : ContentPage
{
	public TelaInicial()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new SobreHospedagem());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ContratacaoHospedagem());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new EstadiaHospedagem());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}