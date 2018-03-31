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
    /// Interaktionslogik für CompanyInformation.xaml
    /// </summary>
    public partial class CompanyInformation : Page
    {
        public CompanyInformation()
        {
            InitializeComponent();
            
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            CompanySettings companySettings = new CompanySettings();
        }
    }
}
