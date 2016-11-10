using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DemoApp
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();

            var list = new List<DataItem>();
            for (var i = 0; i < 10; i++)
                list.Add(new DataItem {ImageUrl = $"http://lorempixel.com/400/200/sports/{i}", Name = $"{i} data item"});

            MainListView.ItemsSource = list;
        }

        void MainListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var str = e.SelectedItem as string;

            DisplayAlert("HI!", str, "OK");
        }
    }
}
