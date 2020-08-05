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
    public partial class Jogar_Completa : ContentPage
    {
        public Jogar_Completa()
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
        private void Ouvir1_Clicked(object sender, EventArgs e)
        {
           
            
            if (image1.Source.ToString() == "File: Mae.png")
            {
                var stream = GetStreamFromFile("Mae.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }

            if (image1.Source.ToString() == "File: Crianca.png")
            {
                var stream = GetStreamFromFile("Crianca.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }

            if (image1.Source.ToString() == "File: Pirata.png")
            {
                var stream = GetStreamFromFile("Pirata.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }




        }

        private void Ouvir2_Clicked(object sender, EventArgs e)
        {
            if (image2.Source.ToString() == "File: Cozinha.png")
            {
                var stream = GetStreamFromFile("Cozinha.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }

            if (image2.Source.ToString() == "File: Praia.png")
            {
                var stream = GetStreamFromFile("Praia.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }

            if (image2.Source.ToString() == "File: Tesouro.png")
            {
                var stream = GetStreamFromFile("Tesouro.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }
        }

        private void Ouvir3_Clicked(object sender, EventArgs e)
        {
            if (image3.Source.ToString() == "File: Sopa.png")
            {
                var stream = GetStreamFromFile("Sopa.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }

            if (image3.Source.ToString() == "File: Peixe.png")
            {
                var stream = GetStreamFromFile("Peixe.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }

            if (image3.Source.ToString() == "File: Barco.png")
            {
                var stream = GetStreamFromFile("Barco.mp3");
                var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                audio.Load(stream);
                audio.Play();

            }
        }

        private void Proximo_Clicked(object sender, EventArgs e)
        {
            if (image1.Source.ToString() == "File: Mae.png"){
                image1.Source = "Crianca.png";
                image2.Source = "Praia.png";
                image3.Source = "Peixe.png";

            }

            else if (image1.Source.ToString() == "File: Crianca.png")
            {
                image1.Source = "Pirata.png";
                image2.Source = "Tesouro.png";
                image3.Source = "Barco.png";
            }

        }
    }
}