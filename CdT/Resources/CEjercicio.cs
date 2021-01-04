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

namespace CdT.Resources
{
    public class CEjercicio
    {

        //Definición del ejercicio ------------------------------------------------
        private int idEjercicio;
        private string nomEjercicio;
        private string descEjercicio;
        private int municion;
        private string tipoBlanco;

        //Constructores -----------------------------------------------------------
        public CEjercicio()
        {
        }

        public CEjercicio(int idEjercicio, string nomEjercicio, string descEjercicio, int municion, string tipoBlanco)
        {
            this.idEjercicio = idEjercicio;
            this.nomEjercicio = nomEjercicio;
            this.descEjercicio = descEjercicio;
            this.municion = municion;
            this.tipoBlanco = tipoBlanco;
        }

        //Setters y getters -------------------------------------------------------
        public int IdEjercicio { get => idEjercicio; set => idEjercicio = value; }
        public string NomEjercicio { get => nomEjercicio; set => nomEjercicio = value; }
        public string DescEjercicio { get => descEjercicio; set => descEjercicio = value; }
        public int Municion { get => municion; set => municion = value; }
        public string TipoBlanco { get => tipoBlanco; set => tipoBlanco = value; }
    }
}