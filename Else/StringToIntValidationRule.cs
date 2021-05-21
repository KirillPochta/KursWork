using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ValidationResult = System.Windows.Controls.ValidationResult;

namespace WpfApp1.Else
{
    public class StringToIntValidationRule : ValidationRule
    {
      
        public int p;
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            int i;
            if (int.TryParse(value.ToString(), out i))
                return new ValidationResult(true, null);

            return new ValidationResult(false, "\nВведите разумное количество");
        }
    }
}
