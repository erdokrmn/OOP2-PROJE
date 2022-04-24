using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Oop2Ödev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPageDetail : ContentPage
    {
        ObservableCollection<Fotoğraf> fotoğrafs;
        public MyFlyoutPageDetail()
        {
            InitializeComponent();

            //  fotoğrafları oluşturma
            fotoğrafs = new ObservableCollection<Fotoğraf>
            {
                new Fotoğraf{Image="resim1.jpg"},
                new Fotoğraf{Image="resim2.jpg"},
                new Fotoğraf{Image="resim3.png"}
            };
            // carousel view içine aktarma
            cv.ItemsSource = fotoğrafs;
        }

        private void ImageSource_ChildAdded(object sender, ElementEventArgs e)
        {

        }
    }
}