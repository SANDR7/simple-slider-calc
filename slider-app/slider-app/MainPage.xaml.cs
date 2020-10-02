using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace slider_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MijnSlider.ValueChanged += MijnSlider_ValueChanged;
            MijnLabel.Text = "Vermeningvuldigfactor = 0";
        }
        private void Berekenen(object sender, EventArgs e)
        {
            string FactorValue = MijnSlider.Value.ToString("N0");
            int y = int.Parse(FactorValue);

            string number = InputValue.Text;
            int x = int.Parse(number);
            AntwoordLabel.Text = "Antwoord: " + x * y;

        }
        private void MijnSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            string FactorValue = MijnSlider.Value.ToString("N0");

            //int y = int.Parse(FactorValue);

            MijnLabel.Text = "Vermeningvuldigfactor = " + FactorValue;
        }


    }
}