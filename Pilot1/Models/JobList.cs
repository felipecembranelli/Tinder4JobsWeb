using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pilot1.Models
{
    public class JobList
    {
        [JsonProperty("_total")]
        public string Total { get; set; }

        [JsonProperty("values")]
        public LinkedinJob[] Values { get; set; }

    }

    public class LinkedinJobList
    {
        [JsonProperty("facets")]
        public Facets Facets { get; set; }

        [JsonProperty("jobs")]
        public JobList Jobs { get; set; }

        [JsonProperty("numResults")]
        public string NumResults { get; set; }

    }

    public class Facets
    {
        [JsonProperty("_total")]
        public string Total { get; set; }
    }
}