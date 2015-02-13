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
using SQLite.Net;
using System.IO;

namespace MasterDetailApp.Models
{
    static class ConnectionProvider
    {
        static ConnectionProvider()
        {
            using (var conn = GetConnection())
            {
                conn.CreateTable<Person>();
            }
        }

        public static SQLiteConnection GetConnection()
        {
            var databasePath = Path.Combine(
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), 
                "database.db3");

            return new SQLiteConnection(
                new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(),
                databasePath);
        }
    }
}