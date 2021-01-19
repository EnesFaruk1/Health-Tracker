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
    public partial class Assessment : ContentPage
    {
        public Assessment()
        {
            InitializeComponent();
            var progressBar = new ProgressBar
            {
                Progress = 1.0,
            };
        }
         async private void  But_Assessment_Clicked(object sender, EventArgs e)
         {
            if ((Smoke.IsChecked == true) && (Alcohol.IsChecked == true)&& (Sport.IsChecked == true))
            {
                await progressBar.ProgressTo(.2, 250, Easing.Linear);
            }
            else if ((Smoke.IsChecked == true) && (Alcohol.IsChecked == true) && (Sport2.IsChecked == true))
            {
                await progressBar.ProgressTo(.6, 250, Easing.Linear);
            }
            else if ((Smoke.IsChecked == false) && (Alcohol.IsChecked == true) && (Sport.IsChecked == true))
            {
                await progressBar.ProgressTo(.4, 250, Easing.Linear);
            }
            else if ((Smoke.IsChecked == true) && (Alcohol.IsChecked == false) && (Sport.IsChecked == true))
            {
                await progressBar.ProgressTo(.4, 250, Easing.Linear);
            }
            else if ((Smoke.IsChecked == true) && (Alcohol.IsChecked == false) && (Sport1.IsChecked == true))
            {
                await progressBar.ProgressTo(.5, 250, Easing.Linear);
            }
            else if ((Smoke.IsChecked == true) && (Alcohol.IsChecked == false) && (Sport2.IsChecked == true))
            {
                await progressBar.ProgressTo(.6, 250, Easing.Linear);
            }
            else if ((Smoke.IsChecked == true) && (Alcohol.IsChecked == true) && (Sport1.IsChecked == true))
            {
                await progressBar.ProgressTo(.5, 250, Easing.Linear);
            }
            else if ((Smoke.IsChecked == false) && (Alcohol.IsChecked == true) && (Sport2.IsChecked == true))
            {
                await progressBar.ProgressTo(.7, 250, Easing.Linear);
            }
            else if ((Smoke.IsChecked == false) && (Alcohol.IsChecked == true) && (Sport1.IsChecked == true))
            {
                await progressBar.ProgressTo(.6, 250, Easing.Linear);
            }
            else if ((Smoke.IsChecked == false) && (Alcohol.IsChecked == false) && (Sport2.IsChecked == true))
            {
                await progressBar.ProgressTo(1.0, 250, Easing.Linear);
            }
            else if ((Smoke.IsChecked == false) && (Alcohol.IsChecked == false) && (Sport1.IsChecked == true))
            {
                await progressBar.ProgressTo(.9, 250, Easing.Linear);
            }
            else if ((Smoke.IsChecked == false) && (Alcohol.IsChecked == false) && (Sport.IsChecked == true))
            {
                await progressBar.ProgressTo(.8, 250, Easing.Linear);
            }
        }
    }
}