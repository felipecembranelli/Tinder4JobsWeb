using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tinder4Jobs.DTO
{
    public class LinkedinJobPoster
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }
}