using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using EnesFaruk_180201073.Database;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EnesFaruk_180201073.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Health : ContentPage
    {
        public SQLiteConnection Conn;
        public Person Per;
        public Health()
        {
            InitializeComponent();
            Conn = DependencyService.Get<DB>().GetConnection();
            Conn.CreateTable<Person>();
            
        }

        private void But_Per_Add_Clicked(object sender, EventArgs e)
        {
            Per = new Person();
            int age;
            Per.Person_Fname = Name_Txt.Text;
            Per.Person_Lname = Surname_Txt.Text;
            int.TryParse(Age_Txt.Text, out age);
            Per.Person_Age = age;
            Conn.Insert(Per);
        }

        private void But_Per_Show_Clicked(object sender, EventArgs e)
        {
            var data= (from per in Conn.Table<Person>() select per);
            User_List.ItemsSource = data;
        }
        
    }
}