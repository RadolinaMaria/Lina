using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Fibonacci_2._0
{
    /// <summary>
    /// Business Logic (BL): Fibonacci 2.0
    /// </summary>
    public partial class MainPage : ContentPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        // Button Click Event Handler
        void OnButtonClicked(object sender, EventArgs args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(1);
            int limit = int.Parse(this.boxLimit.Text);
            int a = 1, b = 1, c = a + b;
            while (c < limit)
            {
                numbers.Add(c);
                a = b;
                b = c;
                c = a + b;
            }
            this.boxNumbers.ItemsSource = numbers;
        }
    }
}