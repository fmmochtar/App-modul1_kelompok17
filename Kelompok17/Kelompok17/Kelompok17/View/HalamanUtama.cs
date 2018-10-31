using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Kelompok17.View
{
	public class HalamanUtama : ContentPage
	{
		public HalamanUtama ()
		{
            this.Title = "Data Mahasiswa";

            StackLayout stacklayout = new StackLayout();
            Button button = new Button();
            button.Text = "Tambah Data";
            button.Clicked += Button_Tambah_Clicked;
            stacklayout.Children.Add(button);

            button = new Button();
            button.Text = "Lihat Data";
            button.Clicked += Button_Lihat_Clicked;
            stacklayout.Children.Add(button);

            button = new Button();
            button.Text = "Edit";
            button.Clicked += Button_Edit_Clicked;
            stacklayout.Children.Add(button);

            button = new Button();
            button.Text = "Hapus";
            button.Clicked += Button_Delete_Clicked;
            stacklayout.Children.Add(button);

            Content = stacklayout;
        }

        private async void Button_Tambah_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.HalamanTambahData());
        }
        private async void Button_Lihat_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.HalamanLihatData());
        }
        private async void Button_Edit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HalamanEdit());
        }
        private async void Button_Delete_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HalamanDelete());
        }

    }
}