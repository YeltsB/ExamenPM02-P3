using exammovil.Models;
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
    public partial class AddPagoView : ContentPage
    {
        public AddPagoView()
        {
            InitializeComponent();
            this.BindingContext = new PagoViewModel();
            
        }

        private void Btnver_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new ListPagoView());
   

            
        }

        private void btnnuevo_Clicked(object sender, EventArgs e)
        {

        }

        private void btnguardar_Clicked(object sender, EventArgs e)
        {
            CRUD c = new CRUD();
            Pagos obj = new Pagos()
            {
                Descripcion = "Prueba",
                Monto = 5000.00,
                Fecha = DateTime.Now
            };
            c.Insertar(obj);
        }
    }
}