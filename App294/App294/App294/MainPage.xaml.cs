using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App294
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.ClassId = "0";
        }

        private async void TestBtn_Clicked(object sender, EventArgs e)
        {

            await Task.Run(() => {
                Device.StartTimer(TimeSpan.FromSeconds(4), () =>
                {
                    //if (numberOfQuestions > 0)
                    //{
                    //    HelpingMethods.Addition(numOfDecimal, min, max, Num1Lbl, Num2Lbl, SignLbl, Ch1Btn, Ch2Btn, Ch3Btn, Ch4Btn, Ch5Btn, Ch6Btn);
                    //    numberOfQuestions--;

                    //    HelpingMethods.CounterInSeconds(duration, TimerLbl);
                    //    return true;
                    //}

                    Console.WriteLine("FromSeconds(3)");
                    return false;
                });
            });



            //For subtraction method and should start after previous (Addition) is finished
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                //if (numberOfQuestionsS > 0)
                //{
                //    HelpingMethods.Subtraction(numOfDecimalS, minS, maxS, Num1Lbl, Num2Lbl, SignLbl, Ch1Btn, Ch2Btn, Ch3Btn, Ch4Btn, Ch5Btn, Ch6Btn);
                //    numberOfQuestionsS--;

                //    HelpingMethods.CounterInSeconds(durationS, TimerLbl);

                //    return true;
                //}

                Console.WriteLine("FromSeconds(5)");

                return false;
            });
        }
    }
}
