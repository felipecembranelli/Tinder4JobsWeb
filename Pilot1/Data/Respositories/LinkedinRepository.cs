using Newtonsoft.Json;
using Owin.Security.Providers.LinkedIn;
using Pilot1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace Pilot1.Data.Repositories
{
    public class LinkedinRepository
    {
        public void Authenticate(string accessToken, string oAuthVerifier, string accessTokenSecretKey)
        {
            ////OAuthUtil oAuthUtil = new OAuthUtil();
            //string _consumerKey = "772jmojzy2vnra";
            //string _consumerSecretKey = "hQu5DFEqP5JQyPGr";
            //string _linkedInProfile = "";
            //string _requestPeopleUrl = "http://api.linkedin.com/v1/people/~";
            //string nonce = oAuthUtil.GetNonce();
            //string timeStamp = oAuthUtil.GetTimeStamp();
            //bool authenticationError = false;
            //string authenticationErrorMsg = string.Empty;


            //try
            //{

            //    System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            //    httpClient.MaxResponseContentBufferSize = int.MaxValue;
            //    httpClient.DefaultRequestHeaders.ExpectContinue = false;
            //    System.Net.Http.HttpRequestMessage requestMsg = new System.Net.Http.HttpRequestMessage();
            //    requestMsg.Method = new System.Net.Http.HttpMethod("GET");
            //    requestMsg.RequestUri = new Uri(_requestPeopleUrl, UriKind.Absolute);
            //    requestMsg.Headers.Add("x-li-format", "json");


            //    string sigBaseStringParams = "oauth_consumer_key=" + _consumerKey;
            //    sigBaseStringParams += "&" + "oauth_nonce=" + nonce;
            //    sigBaseStringParams += "&" + "oauth_signature_method=" + "HMAC-SHA1";
            //    sigBaseStringParams += "&" + "oauth_timestamp=" + timeStamp;
            //    sigBaseStringParams += "&" + "oauth_token=" + accessToken;
            //    sigBaseStringParams += "&" + "oauth_verifier=" + oAuthVerifier;
            //    sigBaseStringParams += "&" + "oauth_version=1.0";
            //    string sigBaseString = "GET&";
            //    sigBaseString += Uri.EscapeDataString(_requestPeopleUrl) + "&" + Uri.EscapeDataString(sigBaseStringParams);

            //    // LinkedIn requires both consumer secret and request token secret
            //    string signature = oAuthUtil.GetSignature(sigBaseString, _consumerSecretKey, accessTokenSecretKey);

            //    string data = "realm=\"http://api.linkedin.com/\", oauth_consumer_key=\"" + _consumerKey
            //                  +
            //                  "\", oauth_token=\"" + accessToken +
            //                  "\", oauth_verifier=\"" + oAuthVerifier +
            //                  "\", oauth_nonce=\"" + nonce +
            //                  "\", oauth_signature_method=\"HMAC-SHA1\", oauth_timestamp=\"" + timeStamp +
            //                  "\", oauth_version=\"1.0\", oauth_signature=\"" + Uri.EscapeDataString(signature) + "\"";

            //    requestMsg.Headers.Authorization = new AuthenticationHeaderValue("OAuth", data);
            //    var response = await httpClient.SendAsync(requestMsg);

            //    var text = response.Content.ReadAsStringAsync();

            //    _linkedInProfile = await text;

            //}
            //catch (Exception Err)
            //{
            //    throw;
            //}

            ////<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
            ////<person>
            ////  <first-name>Felipe</first-name>
            ////  <last-name>Cembranelli</last-name>
            ////  <headline>Manager at CI&amp;T</headline>
            ////  <site-standard-profile-request>
            ////    <url>https://www.linkedin.com/profile/view?id=3770090&amp;authType=name&amp;authToken=moVF&amp;trk=api*a3576543*s3647743*</url>
            ////  </site-standard-profile-request>
            ////</person>


            //var linkedinUser = JsonConvert.DeserializeObject<LinkedinUser>(_linkedInProfile);

            //App.LinkedinUser = linkedinUser;


            //if (linkedinUser.FirstName == null)
            //{
            //    throw new Exception("User not authenticated.");
            //}

            //LinkedInSessionInfo sessionInfo = new LinkedInSessionInfo();
            //sessionInfo.AcessToken = accessToken;
            //sessionInfo.LinkedInID = linkedinUser.FirstName;
            //sessionInfo.LinkedinUser = linkedinUser;

            //TinderSession activeSession = TinderSession.CreateNewSession(sessionInfo);

            //try
            //{
            //    if (await activeSession.LoadLinkedinJobSuggestions(_consumerKey, accessToken, oAuthVerifier, _consumerSecretKey, accessTokenSecretKey))
            //    {
            //        if (progressRing != null)
            //            progressRing.IsActive = false;

            //        pageFrame.Navigate(typeof(MainPage));

            //    }

            //}
            //catch (Exception ex)
            //{

            //    authenticationError = true;
            //    authenticationErrorMsg = ex.Message;
            //}

            ////if (authenticationError)
            ////{
            ////    var dialog = new MessageDialog("Unable to authenticate user: " + authenticationErrorMsg);
            ////    await dialog.ShowAsync();
            ////}

            //// Persist authentication data
            //oAuthData oAuthData = new oAuthData();
            //oAuthData.OAuthVerifier = oAuthVerifier;
            //oAuthData.AccessToken = accessToken;
            //oAuthData.AccessTokenSecretKey = accessTokenSecretKey;

            //oAuthSessionManager.Save(oAuthData);

        }

        public void GetUserInfo()
        {
           //var users = HttpContext.GetOwinContext().GetUserManager
            //LinkedInAuthenticatedContext context = new LinkedInAuthenticatedContext( ;


            //var user = new LinkedInService(accessToken, accessTokenSecret).GettUser();
        }

            private const string URL_BASE = "http://api.linkedin.com/v1";
        //public static string ConsumerKey { get { return ConfigurationManager.AppSettings["ConsumerKey"]; } }
        //public static string ConsumerKeySecret { get { return ConfigurationManager.AppSettings["ConsumerSecret"]; } }

        public static string ConsumerKey = "772jmojzy2vnra";
        public static string ConsumerKeySecret = "hQu5DFEqP5JQyPGr";

        public string AccessToken { get; set; }

        public LinkedinRepository(string accessToken)
        {
            this.AccessToken = accessToken;
        }

        //private OAuthCredentials AccessCredentials
        //{
        //    get
        //    {
        //        return new OAuthCredentials
        //        {
        //            Type = OAuthType.AccessToken,
        //            SignatureMethod = OAuthSignatureMethod.HmacSha1,
        //            ParameterHandling = OAuthParameterHandling.HttpAuthorizationHeader,
        //            ConsumerKey = ConsumerKey,
        //            ConsumerSecret = ConsumerKeySecret,
        //            Token = AccessToken,
        //            TokenSecret = AccessTokenSecret
        //        };
        //    }
        //}

        #region Helper

        //private RestResponse GetResponse(string path)
        //{
        //    var client = new RestClient()
        //    {
        //        Authority = URL_BASE,
        //        Credentials = AccessCredentials,
        //        Method = WebMethod.Get
        //    };

        //    var request = new RestRequest { Path = path };

        //    return client.Request(request);
        //}

        private string GetResponse(string apiUrl)
        {
            string serverResponse = string.Empty;

           
            var url = apiUrl + "?oauth2_access_token=" + this.AccessToken;

            // Create Request 
            var request = HttpWebRequest.Create(url);

            request.Headers.Add("x-li-format", "json");

            // set request method 
            request.Method = "GET";
            //request.RequestUri = new Uri(url);

            // set content type 
            //request.ContentType = "application/x-www-form-urlencoded";

            // get response for GET request 
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Error accessing API: " + response.StatusCode);
                }

                using (StreamReader reader =
                new StreamReader(response.GetResponseStream()))
                {
                    serverResponse = reader.ReadToEnd();
                }
            }

            return serverResponse;
        }

        //private T Deserialize(string xmlContent)
        //{
        //    MemoryStream memoryStream = new MemoryStream(Encoding.ASCII.GetBytes(xmlContent));
        //    XmlSerializer deserializer = new XmlSerializer(typeof(T));
        //    return (T)deserializer.Deserialize(new StringReader(xmlContent));
        //}

        private T Deserialize<T>(string jsonContent)
        {
            return (T)JsonConvert.DeserializeObject<T>(jsonContent);

        }

        #endregion

        #region People Information

        //public Person GetCurrentUser()
        //{
        //    var response = GetResponse("people/~");
        //    return Deserialize<Person>(response);
        //}

        public LinkedinUser GettUser()
        {
            var apiUrl = "https://api.linkedin.com/v1/people/~";

            var response = GetResponse(apiUrl);
            return Deserialize<LinkedinUser>(response);
        }

        public LinkedinJobList GetJobSuggestions()
        {
            string apiUrl = "https://api.linkedin.com/v1/people/~/suggestions/job-suggestions/";

            var response = GetResponse(apiUrl);
            return Deserialize<LinkedinJobList>(response);
        }


        //public Person GetPersonById(string id)
        //{
        //    var response = GetResponse("people/id=" + id.ToString());
        //    return Deserialize(response);
        //}

        //public Person GetPersonByPublicProfileUrl(string url)
        //{
        //    var response = GetResponse("people::(url=" + url + ")");
        //    return Deserialize(response.Content);
        //}

        //public PeopleSearchresult SearchPeopleByKeyWord(string keyword)
        //{
        //    var response = GetResponse("people-search?keywords=" + keyword);
        //    return Deserialize(response.Content);
        //}

        //public PeopleSearchresult GetPeopleByFirstName(string firstName)
        //{
        //    var response = GetResponse("people-search?first-name=" + firstName);
        //    return Deserialize(response.Content);
        //}

        //public PeopleSearchresult GetPeopleByLastName(string lastname)
        //{
        //    var response = GetResponse("people-search?last-name=" + lastname);
        //    return Deserialize(response.Content);
        //}

        //public PeopleSearchresult GetPeopleBySchoolName(string schoolName)
        //{
        //    var response = GetResponse("people-search?school-name=" + schoolName);
        //    return Deserialize(response.Content);
        //}

        #endregion

        #region Company information

        //public Company GetCompany(int id)
        //{
        //    var response = GetResponse("companies/" + id.ToString());
        //    return Deserialize(response.Content);
        //}

        //public Company GetCompanyByUniversalName(string universalName)
        //{
        //    var response = GetResponse("companies/universal-name=" + universalName);
        //    return Deserialize(response.Content);
        //}

        //public CompanyCollection GetCompaniesByEmailDomain(string emailDomain)
        //{
        //    var response = GetResponse("companies?email-domain=" + emailDomain);
        //    return Deserialize(response.Content);
        //}

        //public CompanyCollection GetCompaniesByIdAnduniversalName(string id, string universalName)
        //{
        //    var response = GetResponse("companies::(" + id + ",universal-name=" + universalName + ")");
        //    return Deserialize(response.Content);
        //}

        #endregion
    }

}