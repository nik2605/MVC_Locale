using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebApplication3.Helper
{
    public class Helper
    {
        protected static CultureInfo En = new CultureInfo("en-US");
        protected static CultureInfo Fr = new CultureInfo("fr-CA");
        public static CultureInfo culture;
        public Helper()
        {
            En = new CultureInfo("en-US");
            Fr = new CultureInfo("fr-CA");
        }

        public static string LangStr {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name.ToLower())
                {
                    case "fr-ca":
                        return "fr";
                    default:
                        return "en";

                }
            }
        }

        public static int Lang
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name.ToLower())
                {
                    case "fr-ca":
                        return 1;
                    default:
                        return 0;

                }
            }
        }

        public static CultureInfo LangCultureInfo
        {
            get
            {
                switch (Thread.CurrentThread.CurrentCulture.Name.ToLower())
                {
                    case "fr-ca":
                        return Fr;
                    default:
                        return En;

                }
            }
        }

        public static int CurrentCulture
        {
            set
            {
                switch (value)
                {
                    case 1:
                        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = Fr;
                        culture = Fr;
                        break;
                    default:
                        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = En;
                        culture = En;
                        break;
                }
            }
        }

    }


  

}