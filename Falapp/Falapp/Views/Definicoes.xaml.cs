using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Falapp;



namespace Falapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Definicoes : ContentPage
    {
        public Definicoes()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
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

        private void Desativar_Som(object sender, EventArgs args)
        {
            try
            {
               
                
                ImageButton IB = (ImageButton)sender;
                if(IB.Source.ToString()== "File: Ativar_Som.png") { 
                    IB.Source = "Desativar_Som.png";
                }else
                {
                    IB.Source = "Ativar_Som.png";
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async void Eliminar_Perfil(object sender, EventArgs args)
        {
            try
            {
                await Navigation.PushAsync(new Eliminar_Perfil());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       



    }
}