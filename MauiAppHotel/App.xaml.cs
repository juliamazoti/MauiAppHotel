using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {

        public static List<Quarto> lista_quartos = new()
        {
            new()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca= 55.0
            },
             new()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca= 40.0
            },
              new()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50,
                ValorDiariaCrianca= 25
            },
               new()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25,
                ValorDiariaCrianca= 12.50
            },
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
