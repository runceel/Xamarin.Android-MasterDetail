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
using Codeplex.Reactive;
using MasterDetailApp.Models;

namespace MasterDetailApp.ViewModels
{
    public class MainActivityViewModel
    {
        public ReadOnlyReactiveCollection<PersonViewModel> People { get; private set; }

        public MainActivityViewModel(Activity context, AppContext app)
        {
            this.People = app.Master.People.ToReadOnlyReactiveCollection(x => new PersonViewModel(x));
        }
    }
}