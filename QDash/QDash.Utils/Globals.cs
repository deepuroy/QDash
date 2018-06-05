using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Microsoft.VisualStudio.Services.WebApi;

namespace QDash.Utils
{
    public class Globals
    {
        public static string Cookie { get; set; }
        public static string Authorization { get; set; }
        public static string XCsrfToken { get; set; }
        public static HttpWebRequest Request { get; set; }
        public static HttpWebResponse Response { get; set; }
        public static VssConnection Connection { get; set; }
    }
}