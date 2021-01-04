using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CdT
{
    public class CTirador
    {

        //Definición del tirador ---------------------------------------------
        private string dni;
        private string nombre;
        private string apellido1;
        private string apellido2;

        //Constructores ------------------------------------------------------
        public CTirador()
        {
        }

        public CTirador(string dni, string nombre, string apellido1, string apellido2)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
        }

        // Setters y Getters -------------------------------------------------
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }


    }
}