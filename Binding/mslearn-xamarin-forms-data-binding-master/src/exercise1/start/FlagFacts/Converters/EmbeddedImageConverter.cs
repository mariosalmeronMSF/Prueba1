using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FlagFacts.Converters
{
    public class EmbeddedImageConverter : IValueConverter
    {
        public Type RevolvingAssemblyType { get; set; }

        public object Convert(object value, Type targetType, object parametrer, CultureInfo culture)
        {
            var imageUrl = (value ?? " ").ToString();
            if (string.IsNullOrEmpty(imageUrl))
                return null;

            return ImageSource.FromResource(imageUrl, RevolvingAssemblyType?.GetTypeInfo().Assembly);
        }

        public object ConvertBack(object value, Type targetType, object parametrer, CultureInfo culture)
        {
            throw new NotSupportedException(
                $"{nameof(EmbeddedImageConverter)} cannot be used on two-way bindings.");
        }
    }
}
