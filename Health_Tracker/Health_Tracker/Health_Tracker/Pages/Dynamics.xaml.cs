using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using EnesFaruk_180201073.Database;

namespace EnesFaruk_180201073.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dynamics : ContentPage
    {
        public SQLiteConnection Conn;
        public Dynamic Dyn;
        public int Water_Index = 0;
        public int Sleep_Index = 0;
        public Dynamics()
        {
            InitializeComponent();
            Conn = DependencyService.Get<DB>().GetConnection();
            Conn.CreateTable<Dynamic>();

        }

        private void But_Water_Decrease_Clicked(object sender, EventArgs e)
        {
            if (Water_Index <= 0)
            {
                Water_Index = 0;
            }
            else
            {
                Water_Index = Water_Index - 1;
            }
            WaterIndex.Text = Water_Index.ToString();
        }

        private void But_Water_Increase_Clicked(object sender, EventArgs e)
        {
            if (Water_Index < 0)
            {
                Water_Index = 0;
            }
            else
            {
                Water_Index = Water_Index + 1;
            }
            WaterIndex.Text = Water_Index.ToString();

        }

        private void But_Sleep_Decrease_Clicked(object sender, EventArgs e)
        {
            if (Sleep_Index <= 0)
            {
                Sleep_Index = 0;
            }
            else
            {
                Sleep_Index = Sleep_Index - 1;
            }
            SleepIndex.Text = Sleep_Index.ToString();

        }

        private void But_Sleep_Increase_Clicked(object sender, EventArgs e)
        {
            if (Sleep_Index < 0)
            {
                Sleep_Index = 0;
            }
            else
            {
                Sleep_Index = Sleep_Index + 1;
            }
            SleepIndex.Text = Sleep_Index.ToString();

        }

        private void But_Dyn_Add_Clicked(object sender, EventArgs e)
        {
            Dyn = new Dynamic();
            int water;
            int sleep;
            int blood1;
            int blood2;
            int.TryParse(WaterIndex.Text, out water);
            Dyn.Index_Water_Db = water;
            int.TryParse(SleepIndex.Text, out sleep);
            Dyn.Index_Sleep_Db = sleep;
            int.TryParse(Blood_Txt.Text, out blood1);
            Dyn.Index_Blood_Db = blood1;
            int.TryParse(Blood_Txt2.Text, out blood2);
            Dyn.Index_Blood2_Db = blood2;
            Conn.Insert(Dyn);


        }

        private void But_Dyn_Show_Clicked(object sender, EventArgs e)
        {
            var data = (from per in Conn.Table<Dynamic>() select per);
           Dynamic_List.ItemsSource = data;

        }
    }
}