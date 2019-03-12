using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App18
{
    public partial class MainPage : ContentPage
    {
        List<UserModel> items = new List<UserModel>();

        public MainPage()
        {
            InitializeComponent();

            items.Clear();
            //items = new List<ListViewItem>();

            items.Add(new UserModel("홍길동", "hong", "서울"));
            items.Add(new UserModel("이명박", "MB", "포항"));
            items.Add(new UserModel("박근혜", "Park", "503"));

            exampleListView.ItemsSource = items;
            exampleListView.ItemTapped += ExampleListView_ItemTapped;
        }
                
        private void ExampleListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                UserModel selItem = (UserModel)e.Item;

                Navigation.PushAsync(new DetailViewPage(selItem));
            }
        }

        private void OnListViewSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                UserModel selItem = (UserModel)e.SelectedItem;

                DisplayAlert("선택 데이터", selItem.Name, "닫기");
            }
        }

        private void Sb_search_SearchButtonPressed(object sender, EventArgs e)
        {
            FilterItem(sb_search.Text);
        }

        private void Sb_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterItem(sb_search.Text);
        }

        private void FilterItem(string searchText)
        {
            exampleListView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                exampleListView.ItemsSource = items;
            }
            else
            {
                exampleListView.ItemsSource = items.Where(x => x.Name.ToLower().Contains(searchText.ToLower()));
            }

            exampleListView.EndRefresh();
        }

        private void BtnSearch_Clicked(object sender, EventArgs e)
        {
            //InitList();
        }
    }
}
