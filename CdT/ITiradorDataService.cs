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
    public interface ITiradorDataService
    {
        IReadOnlyList<CTirador> Tiradores { get; }
        void RefreshCache();

        CTirador GetTirador(int id);
        void SaveTirador(CTirador tirador);
        void DeleteTirador(CTirador tirador);
    }
}