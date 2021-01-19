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
    public partial class Index : ContentPage
    {
        public SQLiteConnection Conn;
        public BodyMass Body;
        public Index()
        {
            InitializeComponent();
            Conn = DependencyService.Get<DB>().GetConnection();
            Conn.CreateTable<BodyMass>();
        }
        private void But_Index_Calculate_Clicked(object sender, EventArgs e)
        {
          
            int height, weight;
            double index;
            int.TryParse(Weight_Txt.Text, out weight);
            int.TryParse(Height_Txt.Text, out height);
            index = weight * 10000 / (height * height);
            Index_Txt.Text = index.ToString();
          

            
        }

        private void But_Body_Add_Clicked(object sender, EventArgs e)
        {
            Body = new BodyMass();
            
            int weight,height, index;
            
            int.TryParse(Weight_Txt.Text, out weight);
            Body.Person_Weight = weight;
            int.TryParse(Height_Txt.Text, out height);
            Body.Person_Height = height;
            int.TryParse(Index_Txt.Text,out index);
            Body.Body_Mass = index;
            
            if (Gender.IsChecked == true)
            {
                Body.Person_Gender = Gender.Text;
            }
            else
            {
                Body.Person_Gender1 = Gender1.Text;
            }
           
            Conn.Insert(Body);

        }

        private void But_Body_Show_Clicked(object sender, EventArgs e)
        {
            var data = (from per in Conn.Table<BodyMass>() select per);
            Index_List.ItemsSource = data;
        }
    }
}