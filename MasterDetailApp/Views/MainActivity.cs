using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MasterDetailApp.ViewModels;
using MasterDetailApp.Models;
using ReactiveProperty.XamarinAndroid;
using ReactiveProperty.XamarinAndroid.Extensions;

namespace MasterDetailApp.Views
{
    [Activity(Label = "MasterDetailApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var viewModel = new MainActivityViewModel(this, AppContext.Instance);
            this.ListAdapter = viewModel.People.ToAdapter(
                (_, __) => LayoutInflater.FromContext(this).Inflate(Android.Resource.Layout.SimpleListItem1, null),
                (_, x, v) => v.FindViewById<TextView>(Android.Resource.Id.Text1).SetBinding(y => y.Text, x.Name),
                (_, x) => x.Person.Id);
        }
    }
}

