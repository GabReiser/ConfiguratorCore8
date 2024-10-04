using ConfiguratorNewest.Enum;
using RestSharp;
using System.Net;

namespace ConfiguratorNewest
{
    public class EmbeddedParamsInfo : ICloneable
    {

        private const string SYSTEM_METHOD_ANDROID = "/rws/status/system";

        /// <summary>
        /// Url do WebService que será configurado no .dalp
        /// </summary>
        public string DsUrlWebService { get; set; }

        /// <summary>
        /// Endereço IP do equipamento (exemplo: 172.16.0.250)
        /// </summary>
        public string DsIPMFP { get; set; }

        public string DsUser { get; set; }

        public string DsPassword { get; set; }

        public bool SslActive { get; set; }

        public bool Validate(ActionType type)
        {
            if (!DsUrlWebService.EndsWith("/"))
                DsUrlWebService = String.Concat(DsUrlWebService, "/");

            if (String.IsNullOrEmpty(DsIPMFP)) throw new Exception("The property DsIPMFP cannot be null.");
            if (ActionType.Install == type)
                if (String.IsNullOrEmpty(DsUrlWebService)) throw new Exception("The property DsUrlWebService cannot be null.");

            IPAddress ipAddress;
            if (String.IsNullOrEmpty(DsIPMFP) || !IPAddress.TryParse(DsIPMFP, out ipAddress))
                throw new Exception("The IP Address is not valid");

            return true;
        }

        /// <summary>
        /// Check if it is a device that has Android making a call to a common REST service that is available. This call will
        /// response with status 400 because it needs some headers to fully satisfy its call. As the device may have SSL enabled
        /// and block http requests, it is made a call firstly to 80 and after to 443 if the previous one failed (connection refused).
        /// </summary>
        /// <returns>True if is an Android equipment and false if it is not. If it is an Android equipment the status code will be
        /// different from 404 - Not Found.
        /// </returns>
        public bool CheckIsAndroid()
        {
            string protocol = "http://";
            var originalCallback = ServicePointManager.ServerCertificateValidationCallback;
            if (SslActive)
            {
                protocol = "https://";
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            }

            RestRequest request = new RestRequest(SYSTEM_METHOD_ANDROID, Method.Head);
            RestClient client = new RestClient(protocol + DsIPMFP);
            RestResponse response = client.Execute(request);

            ServicePointManager.ServerCertificateValidationCallback = originalCallback;

            return !response.StatusCode.Equals(HttpStatusCode.NotFound) && response.StatusCode != 0;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return "DsUrlWebService:" + DsUrlWebService + " DsIPMFP:" + DsIPMFP;
        }
    }
}
