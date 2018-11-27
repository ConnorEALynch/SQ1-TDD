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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SQ1_TDD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           

        }

        private void CalculateSide_Click(object sender, RoutedEventArgs e)
        {
            Triangle myTriangle = new Triangle();
            myTriangle.sideA = double.Parse(SideA.Text);
            myTriangle.sideB = double.Parse(SideB.Text);
            myTriangle.calculateHypotenuse();
            SideResult.Text = myTriangle.sideC.ToString();
            myTriangle.calculateArea();
            Area.Text = myTriangle.Area.ToString();
        }

        private void CalculateAngle_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
