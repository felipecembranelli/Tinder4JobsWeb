using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Tinder4Jobs.Model;

namespace Tinder4Jobs.Web.ViewModels
{
    public class LinkedinJobViewModel
    {
        [Display(Name="Description")]
        public string DescriptionSnippet { get; set; }

        public string Id { get; set; }

        [Display(Name="Location")]
        public string LocationDescription { get; set; }

        public LinkedinCompany Company { get; set; }

    }
}