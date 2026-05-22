using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public static List<Quarto> Lista_quartos = new ()
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 100.0,
                ValorDiariaCrianca = 50.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca = 25
            },
            new Quarto()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca = 12.5
            }
        };
        public App()
        {
            InitializeComponent();

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var w = new Window(new AppShell());

            w.Width = 350;
            w.Height = 700;

            return w;
        }
    }
}