using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Data.Models;
using Xamarin.Data.Service.Common;

namespace Xamarin.Data.Service
{
    public class AmbassadorService
    {
        private const String ALL_AMBASSADORS = "https://rest-xamarinambassador.azurewebsites.net/api/values/";
        private const String DETA_AMBASSADOR = "https://rest-xamarinambassador.azurewebsites.net/api/values/{0}";

        public async Task<List<XamarinAmbassador>> GetAmbassadorsList()
        {
            HttpClient _Client = new HttpClient();
            try
            {
                HttpResponseMessage resp = await _Client.GetAsync(ALL_AMBASSADORS);
                resp.EnsureSuccessStatusCode();
                String json = await resp.Content.ReadAsStringAsync();

                List<XamarinAmbassador> result = JsonHelper.Deserialize<List<XamarinAmbassador>>(json);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<XamarinAmbassador> GetAmbassadorDetails(int id)
        {
            HttpClient _Client = new HttpClient();
            try
            {
                HttpResponseMessage resp = await _Client.GetAsync(String.Format(DETA_AMBASSADOR, id));
                resp.EnsureSuccessStatusCode();
                String json = await resp.Content.ReadAsStringAsync();

                XamarinAmbassador result = JsonHelper.Deserialize<XamarinAmbassador>(json);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
