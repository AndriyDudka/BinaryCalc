using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.Util;

namespace Calc
{
    [Activity(Label = "Calc", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
             
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);  
            SetContentView(Resource.Layout.Main);
            EditText editText = FindViewById<EditText>(Resource.Id.editText);
            Calculator calculator = new Calculator();

            Button button1 = FindViewById<Button>(Resource.Id.one);         
            button1.Click += delegate { editText.Text += '1'; };

            Button button2 = FindViewById<Button>(Resource.Id.two);
            button2.Click += delegate { editText.Text += '2'; };

            Button button3 = FindViewById<Button>(Resource.Id.three);
            button3.Click += delegate { editText.Text += '3'; };

            Button button4 = FindViewById<Button>(Resource.Id.four);
            button4.Click += delegate { editText.Text += '4'; };

            Button button5 = FindViewById<Button>(Resource.Id.five);
            button5.Click += delegate { editText.Text += '5'; };

            Button button6 = FindViewById<Button>(Resource.Id.six);
            button6.Click += delegate { editText.Text += '6'; };

            Button button7 = FindViewById<Button>(Resource.Id.seven);
            button7.Click += delegate { editText.Text += '7'; };

            Button button8 = FindViewById<Button>(Resource.Id.eight);
            button8.Click += delegate { editText.Text += '8'; };

            Button button9 = FindViewById<Button>(Resource.Id.nine);
            button9.Click += delegate { editText.Text += '9'; };

            Button button0 = FindViewById<Button>(Resource.Id.zero);
            button0.Click += delegate { editText.Text += '0'; };

            Button buttonAdd = FindViewById<Button>(Resource.Id.add);
            buttonAdd.Click += delegate
            {
                if (editText.Text.Length > 0)
                {
                    var length = editText.Text.Length;
                    var last = editText.Text[length - 1];
                    if (last == '+' || last == '-' || last == '*' || last == '/')
                    {
                        editText.Text = editText.Text.Substring(0, length - 1);
                    }
                }
                editText.Text += '+';
            };

            Button buttonSub = FindViewById<Button>(Resource.Id.subtract);
            buttonSub.Click += delegate
            {
                if (editText.Text.Length > 0)
                {
                    var length = editText.Text.Length;
                    var last = editText.Text[length - 1];
                    if (last == '+' || last == '-' || last == '*' || last == '/')
                    {
                        editText.Text = editText.Text.Substring(0, length - 1);
                    }
                }
                editText.Text += '-';
            };

            Button buttonMul = FindViewById<Button>(Resource.Id.multiply);
            buttonMul.Click += delegate
            {
                if (editText.Text.Length > 0)
                {
                    var length = editText.Text.Length;
                    var last = editText.Text[length - 1];
                    if (last == '+' || last == '-' || last == '*' || last == '/')
                    {
                        editText.Text = editText.Text.Substring(0, length - 1);
                    }
                }
                editText.Text += '*';
            };

            Button buttonDiv = FindViewById<Button>(Resource.Id.divide);
            buttonDiv.Click += delegate
            {
                if (editText.Text.Length > 0)
                {
                    var length = editText.Text.Length;
                    var last = editText.Text[length - 1];
                    if (last == '+' || last == '-' || last == '*' || last == '/')
                    {
                        editText.Text = editText.Text.Substring(0, length - 1);
                    }
                }
                editText.Text += '/';
            };

            Button buttonClear = FindViewById<Button>(Resource.Id.clear);
            buttonClear.Click += delegate { editText.Text = ""; };

            Button buttonResult = FindViewById<Button>(Resource.Id.result);
            buttonResult.Click += delegate { editText.Text = calculator.Calculate(editText.Text); };
        }    
    }
}



