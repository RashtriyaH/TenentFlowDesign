using Android.Content;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenentFlowDesign.Controls;
using Android.Graphics.Drawables;
using AndroidX.AppCompat.Widget;

//[assembly: ExportRenderer(typeof(CustomEntryForCreateTransPage), typeof(CustomRendersTransactionPage))]
//namespace TenentFlowDesign.Platforms.Android.Renders
//{
//     class CustomRendersTransactionPage : EntryRenderer
//    {
//        public CustomRendersTransactionPage(Context context) : base(context)
//        {
//          //  AutoPackage = false;
//        }
//        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
//        {
//            base.OnElementChanged(e);
//            if (e.OldElement == null)
//            {
//                Control.Background= null;
//            }
//        }
//    }


//}

using TenentFlowDesign.Android;

[assembly: ExportRenderer(typeof(CustomEntryForCreateTransPage), typeof(CustomRendersTransactionPage))]
namespace TenentFlowDesign.Android
{
    class CustomRendersTransactionPage : EntryRenderer
    {
        public CustomRendersTransactionPage(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }

}

