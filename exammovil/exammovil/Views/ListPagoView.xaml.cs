using exammovil.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace exammovil.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPagoView : ContentPage
    {
        public ListPagoView()
        {
            InitializeComponent();
            this.BindingContext = new ListViewModel();

        }
    }
}