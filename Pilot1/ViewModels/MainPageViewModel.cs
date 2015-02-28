using Newtonsoft.Json;
using Pilot1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Pilot1.ViewModels
{
    public class LinkedinJob
    {
        public LinkedinCompany Company { get; set; }

        public string DescriptionSnippet { get; set; }

        public string Id { get; set; }

        public LinkedinJobPoster JobPoster { get; set; }

        public string LocationDescription { get; set; }

    }
}