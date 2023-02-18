using System;
using Xamarin.Forms;

namespace Clicker_Mania_3._0
{ 
  // Business Logic (BL): Clicker Mania 3.0
    public partial class MainPage : ContentPage
{
    // Constructor
    public MainPage()
    {
        this.InitializeComponent();

        // Timer
        Device.StartTimer(TimeSpan.FromSeconds(1), TimerTick);
    }

    // Timer Tick Event Handler
    private bool TimerTick()
    {
        int T = int.Parse(this.Timer.Text);
        this.Timer.Text = (++T).ToString();
        // clicks Per Minute
        this.CPM.Text = (float.Parse(this.Clicks.Text) /
        float.Parse(this.Timer.Text) * 60).ToString("N2");
        return true;
    }

    // Button Click Event Handler
    void OnButtonClicked(object sender, EventArgs args)
    {
        int N = int.Parse(this.Clicks.Text);
        this.Clicks.Text = (++N).ToString();
    }
}
}