using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CustomerRenderDemo
{
    public partial class MyMainPage : ContentPage
    {
        public MyMainPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MyTapPage());
        }
    }
}
