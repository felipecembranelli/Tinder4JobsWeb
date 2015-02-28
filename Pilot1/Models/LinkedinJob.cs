using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pilot1.Models
{
    public class LinkedinJob
    {
        [JsonProperty("company")]
        public LinkedinCompany Company { get; set; }

        [JsonProperty("descriptionSnippet")]
        [Display(Name="Description")]
        public string DescriptionSnippet { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("jobPoster")]
        [Display(Name="Job Poster")]
        public LinkedinJobPoster JobPoster { get; set; }

        [JsonProperty("locationDescription")]
        [Display(Name="Location")]
        public string LocationDescription { get; set; }

    }
}