using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Oop2Ödev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BiletSorgulama : ContentPage
    {
        // Tasarım ekranında oluşturduğumu labelın çalışması için oluşturduğumuz fonksiyon
        public ICommand TapCommand => new Command<string>(OpenBrowser);

        private void OpenBrowser(string url)
        {
            Device.OpenUri(new Uri(url));
        }

        public BiletSorgulama()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}