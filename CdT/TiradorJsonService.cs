using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CdT
{
    public class TiradorJsonService : ITiradorDataService
    {
        private string _storagePath;
        private List<CTirador> _tiradores = new List<CTirador>();

        //Constructores

        //Constructor que comprueba y crea el directorio de almacenamiento
        public TiradorJsonService (string storagePath)
        {
            _storagePath = storagePath;

            //Crear la ruta de almacenamiento si no existe
            if (!Directory.Exists(_storagePath))
                Directory.CreateDirectory(_storagePath);
            RefreshCache();

        }

        //Setters and getters

        // Exponemos el listado de tiradores

        public IReadOnlyList<CTirador> Tiradores
        {
            get { return _tiradores}
        }

        public IReadOnlyList<CTirador> Tiradores => throw new NotImplementedException();

        public void DeleteTirador(CTirador tirador)
        {
            throw new NotImplementedException();
        }

        public CTirador GetTirador(int id)
        {
            throw new NotImplementedException();
        }

        public void RefreshCache()
        {
            //throw new NotImplementedException();
            _tiradores.Clear();

            string[] filenames = Directory.GetFiles(_storagePath, "*.json");

            foreach (string filename in filenames)
            {
                string tiradorString = File.ReadAllText(filename);
                CTirador tirador = JsonConvert.DeserializeObject<CTirador>(tiradorString);
                _tiradores.Add(tirador);
            }
        }

        public void SaveTirador(CTirador tirador)
        {
            throw new NotImplementedException();
        }
    }
}