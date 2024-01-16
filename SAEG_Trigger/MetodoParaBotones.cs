using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SAEG_Trigger
{
    public class MetodoParaBotones : TriggerAction<Button>
    {
        protected override async void Invoke(Button btn)
        {
            //await Task.Delay(1000);
            btn.BackgroundColor = Color.DarkOrange;
            btn.Text = "Va de núez";
            await Task.Delay(1000);
            btn.BackgroundColor = Color.DarkViolet;
            btn.Text = "Haz Click Aquí";
        }
    }
}
