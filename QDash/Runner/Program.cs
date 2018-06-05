using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Services.Common;
using QDash.VSTSAdaptor;

namespace Runner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var vstsUrl = ConfigurationManager.AppSettings["VSTS_URL"];
            var vstsUserName = ConfigurationManager.AppSettings["VSTS_USERNAME"];
            var vstsPassword = ConfigurationManager.AppSettings["VSTS_PASSWORD"];
            var client = new VsClient(new Uri(vstsUrl), new VssBasicCredential(vstsUserName, vstsPassword));
            var workItems = new WorkItems(client);
            var result = workItems.RunQuery(@"SELECT[Id], [Title], [State] FROM workitems WHERE[Work Item Type] = 'Bug'");
            if (result != null)
            {
                foreach (var item in result.WorkItems)
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}