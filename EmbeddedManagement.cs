using ConfiguratorNewest.Enum;
using ConfiguratorNewest.Instalation.Ricoh;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorNewest
{
    public class EmbeddedManagement
    {
        public EmbeddedManagement()
        { }

        #region Public methods
        /// <summary>
        /// Instalar o sofware no equipamento (Embarcar)
        /// </summary>
        /// <param name="info">Modelo preenchido com os dados para instalação</param>
        public void Install(EmbeddedParamsInfo info, Company company, bool isConfigurate)
        {
            //UpdateDalp(info);

            if (info.CheckIsAndroid() || company == Company.Brother)
                ValidateUrl(info.DsUrlWebService);

            switch (company)
            {
                case Company.Ricoh:
                    new ManagementRICOH().Install(info, isConfigurate, company);
                    break;
            }

        }

        /// <summary>
        /// Desinstalar o software do equipamento (Desembarcar)
        /// </summary>
        /// <param name="info">Modelo preenchido com os dados para instalação</param>
        public void Uninstall(EmbeddedParamsInfo info, Company company)
        {
            switch (company)
            {
                case Company.Ricoh:
                    new ManagementRICOH().Uninstall(info, company);
                    break;
            }

        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Atualiza URL do WebService no .dalp
        /// </summary>
        private void UpdateDalp(EmbeddedParamsInfo info)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }


        private async Task ValidateUrl(string url)
        {
            var request = new RestRequest("isAlive", Method.Get);
            request.AddParameter("application/json; charset=utf-8", ParameterType.RequestBody);
            var client = new RestClient(url);
            var response = await client.ExecuteAsync(request);
            if (response.StatusCode != HttpStatusCode.OK)
                throw new HttpRequestException(response.StatusCode.ToString());
        }

        #endregion

    }
}
