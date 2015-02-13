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
using System.Collections.ObjectModel;

namespace MasterDetailApp.Models
{
    public class Master : ObservableObject
    {
        private const int PageSize = 10;

        private int page;

        public int Page
        {
            get { return this.page; }
            private set { this.Set(ref this.page, value); }
        }

        public ObservableCollection<Person> People { get; private set; }

        public Master()
        {
            this.People = new ObservableCollection<Person>();
        }

        public void Load()
        {
            this.People.Clear();
            this.Page = 0;
            this.LoadImpl();
        }

        public void LoadMore()
        {
            this.LoadImpl();
        }

        private void LoadImpl()
        {
            using (var conn = ConnectionProvider.GetConnection())
            {
                var results = conn.Table<Person>()
                    .OrderBy(x => x.Id)
                    .Skip(this.Page++ * PageSize)
                    .Take(PageSize)
                    .ToArray();
                foreach (var p in results)
                {
                    this.People.Add(p);
                }
            }
        }

    }
}