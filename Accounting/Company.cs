using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace Accounting
{
    class Company
    {
        public static List<Company> companies = new List<Company>();
        private string currency = "currency";    
        private string name = "flex";
        private string phonenumber = "phonenumber";
        private string email = "email";
        private string contactperson = "contactperson";
        private string companyadress = "companyadress";
        private string website;
        private string employees;
        
        public bool GetData(string TextBox,string TextBoxValue)
        {
            switch(TextBox)
            {
                case "NameTextBox": name = TextBoxValue;
                    break;
                case "AdressTextBox": companyadress = TextBoxValue;
                    break;
                case "PhoneNumberTextBox": phonenumber = TextBoxValue;
                    break;
                case "EMailTextBox":  email = TextBoxValue;
                    break;
                case "ContactPersonTextBox": contactperson = TextBoxValue;
                    break;
                case "WebsiteTextBox": website = TextBoxValue;
                    break;
                case "EmployeesTextBox": employees = TextBoxValue;
                    break;
                default: return false;
            }
            return true;
        }

        public string ReturnData()
        {
            string propertystring = null;
            propertystring += name + ";";
            propertystring += companyadress + ";";
            propertystring += phonenumber + ";";
            propertystring += email + ";";
            propertystring += contactperson + ";";
            propertystring += website + ";";
            propertystring += employees + ";";
            return propertystring;
        }
    }
}