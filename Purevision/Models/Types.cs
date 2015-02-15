using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Web;

namespace Purevision.Models
{
    public class Types
    {
    }

    public class PhoneNumber : IFormattable
    {
        public PhoneNumber(string phoneNumber)
        {
            Number = phoneNumber;

        }
        public string Country { get; set; }
        public string Area { get; set; }
        public string Nxx { get; set; }
        public string Station { get; set; }
        public string Number { get; set; }
        public override string ToString()
        {
            //return base.ToString();
            if (Nxx == "") return "";
            if (Station == "") return "";
            var phone = string.Format("{0}-{1}", Nxx, Station);
            if (Area == "") return phone;
            phone = string.Format("({0}) {1}", Area, phone);
            if (Country == "") return phone;
            return string.Format("+{0}{1}", Country, phone);
        }

        public string ToString(string format)
        {
            // Handle null or empty string. 
            if (String.IsNullOrEmpty(format)) format = "C";
            // Remove spaces and convert to uppercase.
            format = format.Trim().ToUpperInvariant();

            string phone = "";

            // Convert temperature to Fahrenheit and return string. 
            switch (format)
            {
                // return formatted with hyphen and paranthesis
                case "f":
                    if (Nxx == "") return "";
                    if (Station == "") return "";
                    phone = string.Format("{0}-{1}", Nxx, Station);
                    if (Area == "") return phone;
                    phone = string.Format("({0}) {1}", Area, phone);
                    if (Country == "") return phone;
                    return string.Format("+{0}{1}", Country, phone);
                // return dot notation
                case "d":
                    if (Nxx == "") return "";
                    if (Station == "") return "";
                    phone = string.Format("{0}.{1}", Nxx, Station);
                    if (Area == "") return phone;
                    phone = string.Format("{0}.{1}", Area, phone);
                    if (Country == "") return phone;
                    return string.Format("{0}.{1}", Country, phone);
                // return numerics / unformatted
                case "n":
                    if (Nxx == "") return "";
                    if (Station == "") return "";
                    phone = string.Format("{0}{1}", Nxx, Station);
                    if (Area == "") return phone;
                    phone = string.Format("{0}{1}", Area, phone);
                    if (Country == "") return phone;
                    return string.Format("{0}{1}", Country, phone);
                default:
                    throw new FormatException(String.Format("Format string '{0}' undefined.", format));
            }   
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }
    }
}