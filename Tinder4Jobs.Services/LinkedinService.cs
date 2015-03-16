using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Serialization;
using Tinder4Jobs.Data;
using Tinder4Jobs.Data.Infrastructure;
using Tinder4Jobs.Data.Repository;
using Tinder4Jobs.DTO;
using Tinder4Jobs.Model;


namespace Tinder4Jobs.Services
{
    public interface ILinkedinService
    {
        string AccessToken { get; set; }
        LinkedinJobListDTO GetJobSuggestions();
        void AddJob(LinkedinJob job);
        void SaveJob(LinkedinJob job);
    }

    public class LinkedInService : ILinkedinService
    {
        private readonly ILinkedinRepository linkedinRepository;
        private readonly IUnitOfWork unitOfWork;

        //private LinkedinRepository repo= new LinkedinRepository();

        public string AccessToken { get; set; }

        public LinkedInService(ILinkedinRepository linkedinRepository, IUnitOfWork unitOfWork)
        {
            this.linkedinRepository = linkedinRepository;
            this.unitOfWork = unitOfWork;

            //repo = new LinkedinRepository(accessToken);
        }

        public LinkedinJobListDTO GetJobSuggestions()
        {
            // REFATORAR
            this.linkedinRepository.AccessToken = this.AccessToken;

            return linkedinRepository.GetJobSuggestions();
        }

        public void AddJob(LinkedinJob job)
        {
            // REFATORAR (MAPPER ? )
            //Tinder4Jobs.Data.Tb_LinkedinJob j = new Data.Tb_LinkedinJob();

            //var j = AutoMapper.Mapper.Map<LinkedinJob, Tb_LinkedinJob>(job);

            //int result;

            //if (int.TryParse(job.Company.Id, out result))
            //{
            //    j.CompanyId = int.Parse(job.Company.Id);
            //}
            
            //j.CompanyName = job.Company.Name;
            //j.DescriptionSnippet = job.DescriptionSnippet;
            //j.JobId = job.Id.ToString();
            //j.JobEvaluationApproval = null;
            //j.JobPosterFirstName = job.JobPoster.FirstName;
            //j.LocationDescription = job.LocationDescription;

            linkedinRepository.Add(job);

            this.unitOfWork.Commit();
        }

        //public void UpdateJob(LinkedinJob job)
        //{
        //    var j = AutoMapper.Mapper.Map<LinkedinJob, Tb_LinkedinJob>(job);

        //    linkedinRepository.Update(j);

        //    this.unitOfWork.Commit();
        //}

        public void UpdateJob(LinkedinJob job)
        {
            linkedinRepository.Update(job);

            this.unitOfWork.Commit();
        }

        public void SaveJob(LinkedinJob job)
        {

            // try get from database
            var j = linkedinRepository.GetByJobId(job.JobId);

            if (j == null)
                this.AddJob(job);
            else
                this.UpdateJob(j);

        }
    }  
}
