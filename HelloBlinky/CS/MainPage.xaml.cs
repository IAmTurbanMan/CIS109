// Copyright (c) Microsoft. All rights reserved.
// Hello Blinky

using System;
using Windows.Devices.Gpio;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Blinky
{
    public sealed partial class MainPage : Page
    {
        private const int LED_PIN_1 = 5;
        private const int LED_PIN_2 = 26;
        private GpioPin pin_one;
        private GpioPin pin_two;
        private GpioPinValue pinValue;
        private DispatcherTimer timer1;
        private DispatcherTimer timer2;
        private SolidColorBrush redBrush = new SolidColorBrush(Windows.UI.Colors.Red);
        private SolidColorBrush grayBrush = new SolidColorBrush(Windows.UI.Colors.LightGray);

        public MainPage()
        {
            InitializeComponent();

            timer1 = new DispatcherTimer();
            timer1.Interval = TimeSpan.FromMilliseconds(500);
            timer1.Tick += Timer_Tick_one;
            timer2 = new DispatcherTimer();
            timer2.Interval = TimeSpan.FromMilliseconds(1000);
            timer2.Tick += Timer_Tick_two;
            InitGPIO();
            if (pin_one != null)
            {
                timer1.Start();
            }        

            if (pin_two != null)
            {
                timer2.Start();
            }
        }

        private void InitGPIO()
        {
            var gpio = GpioController.GetDefault();

            // Show an error if there is no GPIO controller
            if (gpio == null)
            {
                pin_one = null;
                pin_two = null;
                GpioStatus.Text = "There is no GPIO controller on this device.";
                return;
            }

            pin_one = gpio.OpenPin(LED_PIN_1);
            pin_two = gpio.OpenPin(LED_PIN_2);
            pinValue = GpioPinValue.High;
            pin_one.Write(pinValue);
            pin_two.Write(pinValue);
            pin_one.SetDriveMode(GpioPinDriveMode.Output);
            pin_two.SetDriveMode(GpioPinDriveMode.Output);

            GpioStatus.Text = "GPIO pin initialized correctly.";

        }

   




        private void Timer_Tick_one(object sender, object e)
        {
            if (pinValue == GpioPinValue.High)
            {
                pinValue = GpioPinValue.Low;
                pin_one.Write(pinValue);
                LED1.Fill = redBrush;
            }
            else
            {
                pinValue = GpioPinValue.High;
                pin_one.Write(pinValue);
                LED1.Fill = grayBrush;
            }
        }

        private void Timer_Tick_two(object sender, object e)
        {
            if (pinValue == GpioPinValue.High)
            {
                pinValue = GpioPinValue.Low;
                pin_two.Write(pinValue);
                LED2.Fill = redBrush;
            }
            else
            {
                pinValue = GpioPinValue.High;
                pin_two.Write(pinValue);
                LED2.Fill = grayBrush;
            }
        }

    }
}
