using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfDataValidationApp
{
    public class RequiredRule: ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value == null || value.ToString().Equals(string.Empty))
            {
                return new ValidationResult(false, "This field is required!");
            }
            return new ValidationResult(true, null);
        }
    }
}
