using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace WebApp.Common
{
    public enum TransactionStatus
    {
        [Description("Pending")]
        PENDING = 0,
        COMPLETE = 1,
        APPROVED,
        REJECTED,
        DELETED,
        WAITPERIOD
    }

    public static class Extension
    {
        public static string ToUpperCase(this string value)
        {

            return value.ToUpper();

        }

        public static string DescriptionAttr<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes.Length > 0) return attributes[0].Description;
            return source.ToString();
        }
    }



}