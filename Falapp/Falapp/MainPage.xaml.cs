using Falapp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Falapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetValue(NavigationPage.HasNavigationBarProperty, false);
        }
        private async void Iniciar_Selecao_Jogo(object sender, EventArgs args)
        {
            try
            {
                await Navigation.PushAsync(new SelecaoDeJogo());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private async void Iniciar_Criar_Perfil(object sender, EventArgs args)
        {
            try
            {
                await Navigation.PushAsync(new Criar_Perfil());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private async void Iniciar_Progresso(object sender, EventArgs args)
        {
            try
            {
                await Navigation.PushAsync(new Progresso());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async void Iniciar_Definicoes(object sender, EventArgs args)
        {
            try
            {
                await Navigation.PushAsync(new Definicoes());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}