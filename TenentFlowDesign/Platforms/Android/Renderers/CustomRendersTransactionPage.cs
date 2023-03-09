using Android.Content;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using TenentFlowDesign;
using TenentFlowDesign.Android;

[assembly: ExportRenderer(typeof(CustomEntryForCreateTransPage), typeof(CustomRendersTransactionPage))]
namespace TenentFlowDesign.Android
{
    [Obsolete]
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

