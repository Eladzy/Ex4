using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class SliderObjectVM:IDataErrorInfo//,INotifyPropertyChanged
    {
        public double MaxValue { get; set; }
        public double CurrentValue { get; set; }



        public string Error
        {
            get
            {
                return string.Empty;
            }
        }

        public string this[string PropertyName ]
        {
            get
            {
                return GetErrorForProperty(PropertyName);
            }
        }

        public string GetErrorForProperty(string propertyName)
        {
            if (CurrentValue >= MaxValue - MaxValue / 10)
            {
                return "Volume Too Damn High";
            }
            return string.Empty;
        }

        public SliderObjectVM(double maxValue,double startValue)
        {
            this.MaxValue = maxValue;
            this.CurrentValue = startValue;
           
        }
    }
}
