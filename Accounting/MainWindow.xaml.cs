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
        public MainWindow()
        {
            InitializeComponent();
            MyCommand.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
            this.WindowState = WindowState.Maximized;
            Booking booking = new Booking();
            booking.Show();
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

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            MainContent.Width = Plutos.ActualWidth - (Plutos.ActualWidth * 0.07);
            MainContent.Height = Plutos.ActualHeight - (Plutos.ActualHeight * 0.07);
            MainContent.Margin = new Thickness(Plutos.ActualWidth * 0.07, Plutos.ActualHeight * 0.07,0,0);
        }

        private void NewCompany(object sender, RoutedEventArgs e)
        {
            companySettings = new CompanySettings();
            companySettings.Show();
        }
    }
}
