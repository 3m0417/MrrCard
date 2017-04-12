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
using MrrCard.ViewModels;

namespace MrrCard.Droid
{
    class WhatsAppEvent_Android : IWhatsAppEvents
    {
        public void OnPressWhatsApp()
        {
			/*
            Uri uri = new Uri("smsto:503440135");
            Uri msg = new Uri("Thanks ");
            Intent IntentWhatsApp = new Intent(Intent.ActionSendto, uri);

            //  IntentWhatsApp.SetPackage("com.whatsapp");
            IntentWhatsApp.PutExtra("sms_body", "Thanks for your business card . Lets Talk");
            //  IntentWhatsApp.PutExtra(Intent.ExtraProcessText,"Thanks");
            IntentWhatsApp.PutExtra("body", "Thanks body");
            IntentWhatsApp.PutExtra("message", "Thanks message");
            IntentWhatsApp.PutExtra("text", "Thanks message");

            IntentWhatsApp.SetPackage("com.whatsapp");
            StartActivity(IntentWhatsApp);
			*/
        }
    }
}