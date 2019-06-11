using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GettingStarted2.Models;
using Xamarin.Forms;

namespace GettingStarted2.Views {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }
    }

    class IsSelectedToColorConverter : IValueConverter {
        public Color DefaultColor { get; set; }
        public Color SelectedColor { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (!(value is bool boolValue)) return DefaultColor;
            return (boolValue) ? SelectedColor : DefaultColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
