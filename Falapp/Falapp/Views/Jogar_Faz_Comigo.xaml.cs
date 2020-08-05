using LibVLCSharp.Shared;
using MediaManager;
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
    public partial class Jogar_Faz_Comigo : ContentPage
    {
        private string Url { get; set; }
        private bool Reproduzindo { get; set; }
        LibVLC _libVLC;
        
        
       
        public Jogar_Faz_Comigo()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();

            Core.Initialize();
            _libVLC = new LibVLC();


            //var media = new Media(_libVLC, "som_i.mp4", FromType.FromPath);
            //myvideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };

         

        }
        Stream GetStreamFromFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("Falapp.sounds." + filename);

            return stream;
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


        void btnVideo_Clicked(object sender, System.EventArgs e)
        {
          
        }

        private void Reproduzir_Clicked(object sender, EventArgs e)
        {
            var stream = GetStreamFromFile("AAA.mp3");
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(stream);
            audio.Play();
        }
    }
}