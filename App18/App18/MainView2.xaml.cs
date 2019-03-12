using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App18
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView2 : ContentPage
	{
        List<UserModel> items = new List<UserModel>();
        public MainView2 ()
		{
			InitializeComponent ();

            items.Clear();

            items.Add(new UserModel("홍길동", "hong", "서울"));
            items.Add(new UserModel("이명박", "MB", "포항"));
            items.Add(new UserModel("박근혜", "Park", "503"));

            this.grid.ItemsSource = items;
        }
	}
}