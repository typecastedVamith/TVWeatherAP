using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherMsTest.Framework
{
    public static class XpathBuilder
    {
        public static String xpathByText(String index, String text)
        {
           
            return "//*[contains(text()," + text + ")]" + "[" + index + "]"; 
        }

        public static string xpathByTag(String tag, String text)
        {
            return "//"+ tag + "[contains(text(),'" + text + "')]";
        }
    }
}
