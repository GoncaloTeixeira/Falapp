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
    public partial class Criar_Perfil : ContentPage 
    {
        public Criar_Perfil()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
        }
        

        private void Retroceder(object sender, EventArgs args){
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