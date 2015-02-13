using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Practices.Unity;

namespace MasterDetailApp
{
    public static class ViewModelLocator
    {
        private static UnityContainer container = new UnityContainer();
    }
}