using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Falapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelecaoDeJogo : ContentPage
    {
        public SelecaoDeJogo()
        {
            InitializeComponent();
            SetValue(NavigationPage.HasNavigationBarProperty, false);
           
        }
        private void Selecao_Faz_Comigo(object sender, EventArgs args)
        {
            try
            {
                Navigation.PushAsync(new Jogar_Faz_Comigo());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Selecao_Repete(object sender, EventArgs args)
        {
            try
            {
                Navigation.PushAsync(new Jogar_Repete());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Selecao_Completa(object sender, EventArgs args)
        {
            try
            {
                Navigation.PushAsync(new Jogar_Completa());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Retroceder(object sender, EventArgs args)
        {
            try
            {
                Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}