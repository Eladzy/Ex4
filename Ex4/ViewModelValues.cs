using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class ViewModelValues
    {
       static SliderObjectVM sliderObject = new SliderObjectVM(100, 30);
        public static string GetError()
        {
           return sliderObject["MaxValue"];
        }
       public static double MaxValueGetter()
       {
        
            return sliderObject.MaxValue;
       }
        public static double InitialValueGetter()
        {
            return sliderObject.CurrentValue;
        }
    }
}
