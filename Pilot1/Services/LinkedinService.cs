using Newtonsoft.Json;
using Pilot1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using Pilot1.Data.Repositories;


namespace Pilot1.Services
{
    public class LinkedInService
    {
        private LinkedinRepository repo;

        public string AccessToken { get; set; }

        public LinkedInService(string accessToken)
        {
            this.AccessToken = accessToken;

            repo = new LinkedinRepository(accessToken);
        }

        public LinkedinJobList GetJobSuggestions()
        {
            return repo.GetJobSuggestions();
        }

    }  
}
