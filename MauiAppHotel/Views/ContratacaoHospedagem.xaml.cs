namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();

		pck_quarto.ItemsSource = App.Lista_quartos;

		dtpck_checkin.MinimumDate = DateTime.Now;
		dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date?.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date?.AddMonths(2);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new HospedagemContratada());

		}catch (Exception ex)
		{
			DisplayAlertAsync("Ops", ex.Message, "OK");
		}
    }

    private void Button_Clicked_1(object sender, EventArgs e)
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

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        dtpck_checkout.MinimumDate = e.NewDate?.AddDays(1);
        dtpck_checkout.MaximumDate = e.NewDate?.AddMonths(2);
    }
}