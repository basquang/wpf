using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace DataValidation
{
    public class RequiredRule: ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value == null || value.ToString().Equals(string.Empty))
            {
                return new ValidationResult(false, "This field is required!");
            }
            return new ValidationResult(true, null);
        }
    }
}
