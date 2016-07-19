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

namespace BluetoothController
{
    [Activity(Label = "ControllerActivity")]
    public class ControllerActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Controller.ControllerView cv = new Controller.ControllerView(this);
            SetContentView(cv);
        }
    }
}