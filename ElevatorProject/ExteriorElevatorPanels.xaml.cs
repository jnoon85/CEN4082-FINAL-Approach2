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
        
        private void upButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void downButton_Click(object sender, RoutedEventArgs e)
        {

        }
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