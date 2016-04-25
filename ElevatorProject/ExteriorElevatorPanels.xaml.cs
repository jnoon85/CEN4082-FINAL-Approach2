using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ElevatorProject
{
    /// <summary>
    /// Interaction logic for ExteriorElevatorPanels.xaml
    /// </summary>
    public partial class ExteriorElevatorPanels : Window
    {
        public ExteriorElevatorPanels()
        {
            InitializeComponent();
        }

       private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button btn = sender as Button;

            illuminateButton(btn);

            //updateDisplay(2000, btn);

        }

        private void illuminateButton(Button btn)
        {
            if (btn.Background == Brushes.Yellow)
            {
                btn.ClearValue(Control.BackgroundProperty);
            }
            else
            {
                btn.Background = Brushes.Yellow;
            }
        }


        //public Display(int floor, int location, Label display)
        //{
        //    this.floor = floor;
        //    this.location = location;
        //    this.display = display;
        //    this.display.Content = location;
        //}

        //public void updateDisplay(int floor)
        //{
        //    this.location = floor;
        //    this.display.Content = floor;
        //}

        //public int getLocation()
        //{
        //    return this.location;
        //}

        //private async void updateDisplay(int timeToDelay, Button btn)
        //{

        //    int selected = random.Next(0, 4);
        //    Display display = this.mainPanel.displays[selected];

        //    int floor = Convert.ToInt32(floorNum.Content);
        //    int position = display.getLocation();
        //    if (floor > position)
        //    {
        //        while (floor > position)
        //        {
        //            await Task.Delay(timeToDelay);
        //            position += 1;
        //            display.updateDisplay(position);
        //        }

        //    }
        //    else if (floor < position)
        //    {
        //        while (floor < position)
        //        {
        //            await Task.Delay(timeToDelay);
        //            position -= 1;
        //            display.updateDisplay(position);
        //        }
        //    }

        //    illuminateButton(btn);

        //    MessageBox.Show("Elevator " + (selected + 1) + " has arrived at the floor.");

        //}
    }

    public class Display
    {
        private int floor;
        private int location;
        private string display;

        public Display(int floor, int location, string display)
        {
            this.floor = floor;
            this.location = location;
            this.display = display;
        }
    }
}