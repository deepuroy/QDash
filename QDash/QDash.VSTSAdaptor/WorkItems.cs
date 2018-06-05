using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.WebApi;
using QDash.Utils;

namespace QDash.VSTSAdaptor
{
    public class WorkItems
    {
        public WorkItemTrackingHttpClient witClient { get; set; }

        public WorkItems(VsClient client)
        {
            if (Globals.Connection != null)
            {
                this.witClient = client.Connection.GetClient<WorkItemTrackingHttpClient>();
            }
            else
                Console.WriteLine("Connection object is null");
        }

        public WorkItemQueryResult RunQuery(string q)
        {
            Wiql query = new Wiql() { Query = q };
            var queryResults = witClient.QueryByWiqlAsync(query).Result;
            if (queryResults == null || !queryResults.WorkItems.Any())
            {
                Console.WriteLine("Query did not find any results");
            }
            else
            {
                return queryResults;
            }

            return null;
        }
    }
}