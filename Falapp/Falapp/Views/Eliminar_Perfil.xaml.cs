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
    public partial class Eliminar_Perfil : ContentPage
    {
        public Eliminar_Perfil()
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




    }
}