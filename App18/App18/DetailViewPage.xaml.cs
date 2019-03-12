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
	public partial class DetailViewPage : ContentPage
	{
		public DetailViewPage ()
		{
			InitializeComponent ();
		}

        public DetailViewPage(UserModel item)
        {
            InitializeComponent();
            Lbl_DetailText.Text = item.Name;
        }
    }
}