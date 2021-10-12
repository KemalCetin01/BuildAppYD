
using BuildAppYD.WebUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BuildAppYD.WebUI.ApiService
{
    public class BuildingApiService
    {
        private readonly HttpClient _httpClient;
        public BuildingApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IEnumerable<BuildingModel>> getListAsyc()
        {
            IEnumerable<BuildingModel> buildingModels;
            var response = await _httpClient.GetAsync("Building/getList");
            if (response.IsSuccessStatusCode)
            {
                buildingModels = JsonConvert.DeserializeObject<IEnumerable<BuildingModel>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                buildingModels = null;
            }
            return buildingModels;

        }

        public  async Task<string> AddAsync(BuildingModel buildingModel)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(buildingModel),Encoding.UTF8,"application/json");


            var response = await _httpClient.PostAsync("Building/Add",stringContent);

            if (response.IsSuccessStatusCode)
            {
               // buildingModel = JsonConvert.DeserializeObject<BuildingModel>(await response.Content.ReadAsStringAsync());
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                //loglama yapılabilir
                return response.Content.ReadAsStringAsync().Result;
            }
        }

        public async Task<BuildingModel> getDetailAsycn(int id)
        {
            var response = await _httpClient.GetAsync($"Building/getDetail?id={id}");
            if (response.IsSuccessStatusCode)
            {
               return JsonConvert.DeserializeObject<BuildingModel>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                return null;
            }
        }
        public async Task<string> UpdateAsync(BuildingModel buildingModel)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(buildingModel), Encoding.UTF8, "application/json");


            var response = await _httpClient.PutAsync("Building/Update", stringContent);

            if (response.IsSuccessStatusCode)
            {
                // buildingModel = JsonConvert.DeserializeObject<BuildingModel>(await response.Content.ReadAsStringAsync());
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                //loglama yapılabilir
                return response.Content.ReadAsStringAsync().Result;
            }
        }
        public async Task<string> Delete(int id)
        {
            var response = await _httpClient.DeleteAsync($"Building/Delete?id={id}");

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                //loglama yapılabilir
                return response.Content.ReadAsStringAsync().Result;
            }
        }

    }
}
