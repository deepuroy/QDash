using System;
using System.Net;

namespace QDash.Utils
{
    public class HttpService
    {
        private static void CreateHttpRequest(string method, string url)
        {
            Globals.Request = (HttpWebRequest)WebRequest.Create(url);
            Globals.Request.Method = method;
            Globals.Request.Headers["Cookie"] = Globals.Cookie;
            Globals.Request.Headers["X-CSRF-TOKEN"] = Globals.XCsrfToken;
            Globals.Request.Accept = "*/*";
            Globals.Request.Headers["userClientCulture"] = "en-US";
        }
    }
}