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
        }

        private void SettingsClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if(Controlselements.count.text >= 0) {
            if (MessageBox.Show("Close company setup?", "Plutos", MessageBoxButton.YesNo, MessageBoxImage.None) == MessageBoxResult.No)
            {
                // No
                e.Cancel = true;
            }
            else
            {
                // Yes
                AppWindows.companySettings = null;
                e.Cancel = false;
            }
        }
    }
}
