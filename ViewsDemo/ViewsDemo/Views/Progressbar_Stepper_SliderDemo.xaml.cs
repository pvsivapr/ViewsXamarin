using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ViewsDemo
{
    public partial class Progressbar_Stepper_SliderDemo : ContentPage
	{
        public Progressbar_Stepper_SliderDemo()
		{
			InitializeComponent();

            //stepper.ValueChanged += (object sender, ValueChangedEventArgs e) => 
            //{
                
            //};

		}

		void backBtnClicked(object sender, EventArgs e)
		{
			try
			{
				Navigation.PopModalAsync(false);
			}
			catch (Exception ex)
			{
				var msg = ex.Message;
			}
		}

		void startPageBtnClicked(object sender, EventArgs e)
		{
			try
			{
				App.Current.MainPage = new LabelDemo();
				//Navigation.PushModalAsync(new LabelDemo(), false);
			}
			catch (Exception ex)
			{
				var msg = ex.Message;
			}
		}


		void nextBtnClicked(object sender, EventArgs e)
		{
			try
			{
                Navigation.PushModalAsync(new LabelDemo(), false);
			}
			catch (Exception ex)
			{
				var msg = ex.Message;
			}
		}
	}
}
