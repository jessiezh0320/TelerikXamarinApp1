using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.DataControls;
using Telerik.XamarinForms.DataControls.ListView;
using Xamarin.Forms;

namespace TelerikXamarinApp1.Portable
{
    public partial class MainPage : ContentPage
    {//https://docs.telerik.com/devtools/xamarin/controls/listview/listview-cells
        public MainPage()
        {
            InitializeComponent();

            //BindingContext = new ViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
