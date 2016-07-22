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

namespace Calc
{
    class Calculator
    {
        public string Calculate(string s)
        {
            string[] arr = s.Split(new char[] {'+', '*', '-', '/'});
            char[] action = new char[arr.Length-1];
            int j = 0,i;

            for (i = 0; i < s.Length; i++)
                if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/')
                    action[j++] = s[i];

            i = 0;
            double answer = Convert.ToDouble(arr[0]);
            while (i < action.Length)
            {
                j = i + 1;               
                double number1 = Convert.ToDouble(arr[j]);
                while (action[i] != '*' && action[i] != '/' && j < action.Length && (action[j] == '*' || action[j] == '/'))
                {                  
                    double number2 = Convert.ToDouble(arr[j + 1]);
                    number1 = action[j] == '*' ? number1*number2 : number1/number2;
                    j++;
                }
                answer = action[i] == '+' ? answer + number1
                    : action[i] == '-' ? answer - number1
                    : action[i] == '*' ? answer*number1
                    : answer*number1;
                i = j;
            }

            return answer.ToString();
        }
    }
}