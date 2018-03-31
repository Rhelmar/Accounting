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

namespace Accounting
{
    /// <summary>
    /// Interaktionslogik für Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        
        public Booking()
        {
            InitializeComponent();
            string[] bs = new string[3]{"1","2","3" };
            target.ItemsSource = bs;
            payment.ItemsSource = bs;
            amount.Text = "Enter Amount...";
            name.Text = "Name of Recipient...";
        }

        private void LostFocusTextBox(object sender, RoutedEventArgs e)
        {
            var textboxElement = sender as TextBox;
            string placeholderText = Convert.ToString(textboxElement.Tag);
            var controlElement = sender as TextBox;
            if (String.IsNullOrWhiteSpace(controlElement.Text))
            {
                controlElement.Text = placeholderText;
            }
        }

        private void GotFocusTextBox(object sender, RoutedEventArgs e)
        {
            var textboxElement = sender as TextBox;
            string placeholderText = Convert.ToString(textboxElement.Tag);
            if (textboxElement.Text != "" && textboxElement.Text != placeholderText)
            {
                return;
            }
            textboxElement.Text = "";
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClosingBooking(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if(Controlelements.count.text >= 0) {
            if (MessageBox.Show("Close Booking?", "Plutos", MessageBoxButton.YesNo, MessageBoxImage.None) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                // Yes
                e.Cancel = false;
                AppWindows.booking = null;
            }
        }
    }
}
