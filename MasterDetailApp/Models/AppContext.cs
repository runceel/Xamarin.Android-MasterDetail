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
using GalaSoft.MvvmLight;

namespace MasterDetailApp.Models
{
    public class AppContext : ObservableObject
    {
        public static readonly AppContext Instance = new AppContext();

        private Master master;

        public Master Master
        {
            get { return this.master; }
            private set { this.Set(ref this.master, value); }
        }

        public AppContext()
        {
            this.Master = new Master();
        }

    }
}