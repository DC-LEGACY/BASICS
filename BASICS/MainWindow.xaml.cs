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

namespace BASICS
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.DescriptionText.Text);
            

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
             this.One.IsChecked = this.Two.IsChecked = this.Three.IsChecked = this.Four.IsChecked = this.Five.IsChecked =
                 this.Six.IsChecked = this.Seven.IsChecked = this.Eight.IsChecked = this.Nine.IsChecked = this.Ten.IsChecked = false;

        }
    }
}
