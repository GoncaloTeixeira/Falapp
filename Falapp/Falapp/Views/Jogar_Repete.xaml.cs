using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Falapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Jogar_Repete : ContentPage
    {
        public Jogar_Repete()
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
        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("Falapp.sounds." + filename);

            return stream;
        }
        private void Ouvir_Som(object sender, EventArgs args)
        {

            if (ImageToSound.Source.ToString() == "File: Repete123.png")
            {
                var stream = GetStreamFromFile("Frigorifico.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }
            if (ImageToSound.Source.ToString() == "File: Escola.png")
            {
                var stream = GetStreamFromFile("Escola.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }
            if (ImageToSound.Source.ToString() == "File: Colher.png")
            {
                var stream = GetStreamFromFile("Colher.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }







        }

        private void ChangeImage(object sender, EventArgs args)
        {
            if (ImageToSound.Source.ToString() == "File: Colher.png")
            {

                ImageToSound.Source = "Escola.png";
            }

            if (ImageToSound.Source.ToString() == "File: Repete123.png") {

                ImageToSound.Source = "Colher.png";
            }

            

        }


    }
}