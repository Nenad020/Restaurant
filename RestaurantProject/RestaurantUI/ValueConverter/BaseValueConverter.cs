using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace RestaurantUI
{
    //We will use this class to directly interact with XAML
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter where T : class, new()
    {
        //A single static instance of this value converter
        private static T _converter = null;

        //Provides a static instance of the value converter 
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (_converter == null)
                _converter = new T();

            return _converter;

            //return _converter ?? (_converter = new T());
        }

        //The method to convert one type to another
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        // The method to convert a value back to it's source type
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
    }
}
