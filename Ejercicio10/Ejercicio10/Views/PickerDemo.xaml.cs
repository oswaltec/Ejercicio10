using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerDemo : ContentPage
    {
        public PickerDemo()
        {
            InitializeComponent();
            this.BindingContext = new MonkeysPageViewModel();
        }
    }
}