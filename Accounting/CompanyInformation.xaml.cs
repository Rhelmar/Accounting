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

        private void NewCompany(object sender, RoutedEventArgs e)
        {
            Company company = new Company();
            foreach(var child in MainGrid.Children)
            {
                if(child is TextBox)    // is == Operator for classes
                {
                   var Textbox = child as TextBox; // Convert child to textbox 
                   if(!company.GetData(Textbox.Name,Textbox.Text))
                   {
                        MessageBox.Show("GetData function failed");
                        return;
                   }
                }
            }

            Company.companies.Add(company);
            company = null;
            AppWindows.companySettings.Close();
        }
    }
}