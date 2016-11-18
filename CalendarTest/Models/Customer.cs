using System;
using System.Linq;
using System.Collections.Generic;

using SimpleMvvmToolkit;
using System.Windows.Controls;

namespace CalendarTest
{
    public class Customer : ModelBase<Customer>
    {
        private int customerId;
        public int CustomerId
        {
            get { return customerId; }
            set
            {
                customerId = value;
                NotifyPropertyChanged(m => m.CustomerId);
            }
        }

        private string customerName;
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                NotifyPropertyChanged(m => m.CustomerName);
            }
        }

        private string city;
        public string City
        {
            get { return city; }
            set
            {
                city = value;
                NotifyPropertyChanged(m => m.City);
            }
        }
    }


    /// <summary>
    /// Validate ASM Code
    /// </summary>
    public class IsAlphaOnlyValidator : ValidationRule
    {
        /// <summary>
        /// Validate provided ASM database name
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cultureInfo"></param>
        /// <returns></returns>
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            return new ValidationResult(value.ToString().All(Char.IsLetter), "Value must be text only.");
        }
    }


}
