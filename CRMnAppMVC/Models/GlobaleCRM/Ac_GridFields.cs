using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CRMnAppMVC.Models
{
    public abstract class Ac_GridFields
    {
        public const string NoDataText= "_No_Data!_";

        public string DrawNumberField(int? fieldValue)
        {
            //byte[] bytes = Encoding.Default.GetBytes(&#9885;);
            //myString = Encoding.UTF8.GetString(bytes);

            string result = "";
            string symbol = System.Net.WebUtility.HtmlDecode("&#9734;"); //&#9885;
            // enconding characters in.NET --\n ..de studiat..
            string spaceBwn = " ";

            if (fieldValue != null)
                for (int i = 0; i < fieldValue; i++)
                {
                    result += symbol+spaceBwn;
                }

            return result;
        }

        public string TextFieldNotNull(string fieldValue)  // Are rolul sa nu returneze null -pt ca HtmlLink nu merge cu TEXT NULL
        {
            string result = fieldValue;

            if (fieldValue == null)
                result = Ac_GridFields.NoDataText;

            return result;
        }
    }
}