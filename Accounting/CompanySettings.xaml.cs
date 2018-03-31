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
    /// Interaktionslogik für CompanySettings.xaml
    /// </summary>
    public partial class CompanySettings : Window
    {
        public CompanySettings()
        {
            InitializeComponent();
            SettingContent.Content = new CompanyInformation();
            MessageBox.Show(Application.Current.MainWindow.OwnedWindows.Count.ToString());
        }

        private void SettingsClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Close Window?", "Plutos", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                // No
                MessageBox.Show(Application.Current.MainWindow.OwnedWindows.Count.ToString());
                e.Cancel = false;
            }
            else
            {
                // Yes
                e.Cancel = false;
                MessageBox.Show(Application.Current.MainWindow.OwnedWindows.Count.ToString());
            }


        }
    }
}
