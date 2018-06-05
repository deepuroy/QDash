using System;
using System.Runtime.CompilerServices;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using QDash.Utils;

namespace QDash.VSTSAdaptor
{
    public class VsClient
    {
        public VssConnection Connection { get; }

        public VsClient(Uri vstsCollectionUrl, VssBasicCredential vsCred)
        {
            try
            {
                this.Connection = new VssConnection(vstsCollectionUrl, vsCred);
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection failed:", e);
                throw;
            }
        }
    }
}