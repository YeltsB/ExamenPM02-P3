using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace exammovil.Models
{
    public class Pagos
    {
        private int id_pago;
        private string descripcion;
        private double monto;
        private DateTime fecha;
        //private Byte[] photo_recibo;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        [PrimaryKey, AutoIncrement]
        public int Id_pago
        {
            get
            {
                return id_pago;
            }

            set
            {
                if (id_pago != value)
                {
                    id_pago = value;
                    OnPropertyChanged("id_pago");
                }

            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                if (descripcion != value)
                {
                    descripcion = value;
                    OnPropertyChanged("descripcion");
                }
            }
        }


        public double Monto
        {
            get
            {
                return monto;
            }

            set
            {
                if (monto != value)
                {
                    monto = value;
                    OnPropertyChanged("monto");
                }
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                if (fecha != value)
                {
                    fecha = value;
                    OnPropertyChanged("fecha");
                }
            }
        }


        //public Byte[] Photo_recibo
        //{
        //    get
        //    {
        //        return photo_recibo;
        //    }

        //    set
        //    {
        //        if (photo_recibo != value)
        //        {
        //            photo_recibo = value;
        //            OnPropertyChanged("photo_recibo");
        //        }
        //    }
        //}



    }
}
