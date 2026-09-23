using Microsoft.UI.Xaml.Input;
using Windows.UI.Notifications;

namespace CITA_255_Assignment_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TaskCollection.ItemsSource = tasks;
            AmountOfHours.ItemsSource = hours;
        }
        List<string> tasks = new List<string>
        {
            "Go to class", "Do homework","Go to football practice","Go to the gym","Go to sleep","Eat dinner","Play Videgames","Pray","Watch Film","Do laundry"
        };

        List<int> hours = new List<int>
        {
            2, 3, 4, 1, 8, 2, 1, 1, 2, 1
        };
        private void OnCounterClicked(object? sender, EventArgs e)
        {
          double totalHours = 0;
            foreach (double hour in hours)
            {
                totalHours += hour;
            }
            TotalHours.Text = $"Total Hours: {totalHours}";
        }
    }
}
