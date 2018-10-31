using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kelompok17.Model;
using System.IO;
using SQLite;

using Xamarin.Forms;

namespace Kelompok17.View
{
	public class HalamanLihatData : ContentPage
	{
        private ListView _listview;
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db4");
        public HalamanLihatData ()
		{
            this.Title = "Data Mahasiswa";

            var db = new SQLiteConnection(_dbPath);
            StackLayout stackLayout = new StackLayout();

            _listview = new ListView();
            _listview.ItemsSource = db.Table<DataMahasiswa>().OrderBy(x => x.Nama).ToList();
            stackLayout.Children.Add(_listview);

            Content = stackLayout;

			}
		}
	}
