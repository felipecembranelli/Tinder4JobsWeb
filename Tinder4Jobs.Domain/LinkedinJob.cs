//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tinder4Jobs.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LinkedinJob
    {
        public int Id { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string DescriptionSnippet { get; set; }
        public string JobId { get; set; }
        public Nullable<int> JobPosterId { get; set; }
        public string LocationDescription { get; set; }
        public string JobEvaluationApproval { get; set; }
    
        public virtual LinkedinCompany LinkedinCompany { get; set; }
        public virtual LinkedinJobPoster LinkedinJobPoster { get; set; }
    }
}
