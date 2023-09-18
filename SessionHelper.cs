using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project
{
    public class SessionHelper
    {
        public static string name
        {
            get
            {
                object value = HttpContext.Current.Session["name"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["name"] = value;
            }
        }

        public static int roll
        {
            get
            {
                object value = HttpContext.Current.Session["roll"];
                return value == null ? 0 : Convert.ToInt32(value);
            }
            set
            {
                HttpContext.Current.Session["roll"] = value;
            }
        }

        public static string mail
        {
            get
            {
                object value = HttpContext.Current.Session["mail"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["mail"] = value;
            }
        }

        public static string gender
        {
            get
            {
                object value = HttpContext.Current.Session["gender"];
                return value == null ? string.Empty : (string)value;
            }
            set
            {
                HttpContext.Current.Session["gender"] = value;
            }
        }

        public static string education
        {
            get
            {
                object value = HttpContext.Current.Session["education"];
                return value == null ? string.Empty : (string)value;
            }
            set
            {
                HttpContext.Current.Session["education"] = value;
            }
        }
        public static string password
        {
            get
            {
                object value = HttpContext.Current.Session["password"];
                return value == null ? "" : (string)value;
            }
            set
            {
                HttpContext.Current.Session["password"] = value;
            }
        }
    }
}