using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Oop2Ödev
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        //private IEnumerable<string> imageList;

        //public IEnumerable<string> ImageList
        //{
        //    get => imageList;
        //    set => SetProperty(ref imageList, value);
        //}

        //public override void Initialize(INavigationService navigationService)
        //{
        //    base.Initialize(parameters);
        //    ImageList = new List<string>
        //    {

        //    };

       // }

        public MyFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MyFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class MyFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public MyFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MyFlyoutPageFlyoutMenuItem>(new[]
                {
                    // typeof(n) Parantez içinde yazan yere yönlendirme yapıyoruz. Ve Menü kısmını burda oluşturuyoruz
                    new MyFlyoutPageFlyoutMenuItem { Id = 0, Title = "Anasayfa" ,TargetType=typeof(MyFlyoutPage)  },
                    new MyFlyoutPageFlyoutMenuItem { Id = 1, Title = "Kampanyalar" ,TargetType=typeof(Kampanyalar)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 2, Title = "Bilet İptali",TargetType=typeof(Biletİptali) },
                    new MyFlyoutPageFlyoutMenuItem { Id = 3, Title = "Bilet Değişikliği" ,TargetType=typeof(BiletDeğişikliği)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 4, Title = "Bilet Sorgulama" ,TargetType=typeof(BiletSorgulama)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 5, Title = "Favori Terminallerim" ,TargetType=typeof(FavoriTerminallerim)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 6, Title = "Kayıtlı Yolcular" ,TargetType=typeof(MyFlyoutPage)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 7, Title = "Kayıtlı Araçlar" ,TargetType=typeof(MyFlyoutPage)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 8, Title = "İletişim" ,TargetType=typeof(MyFlyoutPage)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 9, Title = "Hakkında" ,TargetType=typeof(MyFlyoutPage)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 10, Title = "Yardım" ,TargetType=typeof(MyFlyoutPage)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 11, Title = "Taşıma ve Seyahat Kuralları" ,TargetType=typeof(MyFlyoutPage)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 12, Title = "İptal ve Değişiklik Kuralları" ,TargetType=typeof(MyFlyoutPage)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 13, Title = "İndirim Koşulları" ,TargetType=typeof(MyFlyoutPage)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 14, Title = "Gizlilik Politikası" ,TargetType=typeof(MyFlyoutPage)},
                });
                
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}