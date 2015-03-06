using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tinder4Jobs.Domain
{
    public class LinkedinJob
    {
        public LinkedinCompany Company { get; set; }

        [Display(Name="Description")]
        public string DescriptionSnippet { get; set; }

        public string Id { get; set; }

        [Display(Name="Job Poster")]
        public LinkedinJobPoster JobPoster { get; set; }

        [Display(Name="Location")]
        public string LocationDescription { get; set; }

    }
}