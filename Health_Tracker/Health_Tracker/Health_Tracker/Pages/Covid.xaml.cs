using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EnesFaruk_180201073.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Covid : ContentPage
    {
        public Covid()
        {
            InitializeComponent();
           
        }
        private void But_Covid_Result_Clicked(object sender, EventArgs e)
        {
            if ((Infected.IsChecked == false) && (Around.IsChecked == false) && (RiskZone.IsChecked == false))
            {
                Risk2.IsChecked = true;
            }
            else if ((Infected.IsChecked == true) && (Around.IsChecked == true) && (RiskZone.IsChecked == false))
            {
                Risk1.IsChecked = true;
            }
            else if ((Infected.IsChecked == true) && (Around.IsChecked == true) && (RiskZone.IsChecked == true))
            {
                Risk1.IsChecked = true;
            }
            else if ((Infected.IsChecked == true) && (Around.IsChecked == false) && (RiskZone.IsChecked == false))
            {
                Risk1.IsChecked = true;
            }
            else if ((Infected.IsChecked == false) && (Around.IsChecked == true) && (RiskZone.IsChecked == false))
            {
                Risk1.IsChecked = true;
            }
            else if ((Infected.IsChecked == false) && (Around.IsChecked == false) && (RiskZone.IsChecked == true))
            {
                Risk1.IsChecked = true;
            }
        }
    }
}