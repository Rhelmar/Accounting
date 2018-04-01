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

namespace Accounting
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Sortierfunktion
        //Mitarbeiterkonfiguration
        public MainWindow()
        {
            InitializeComponent();
            MyCommand.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
        }

        public static RoutedCommand MyCommand = new RoutedCommand();
        CompanySettings companySettings;
        
        private void NewClick(object sender, RoutedEventArgs e)
        {
            /* this.Hide();
             MainWindow window = new MainWindow();
             window.Show();
             this.Close();*/
            
        }

        private void OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if ((Keyboard.IsKeyDown(Key.RightCtrl) || (Keyboard.IsKeyDown(Key.LeftCtrl)) && (Keyboard.IsKeyDown(Key.S))))
            {
                MessageBox.Show("Content saved");
            }
        }

        private void NewCompany(object sender, RoutedEventArgs e)
        {
            if (AppWindows.companySettings == null)
            {
                AppWindows.companySettings = new CompanySettings();
                AppWindows.companySettings.Show();
            }
        }

        private void NewBooking(object sender, RoutedEventArgs e)
        {
            if (AppWindows.booking == null)
            {
                AppWindows.booking = new Booking();
                AppWindows.booking.Show();
            }
        }
    }
}
