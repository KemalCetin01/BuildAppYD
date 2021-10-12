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
    public class StoreApiService
    {

        private readonly HttpClient _httpClient;

        public StoreApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<StoreModel>> getListAsyc()
        {
            IEnumerable<StoreModel> storeModels;
            var response = await _httpClient.GetAsync("Store/getListStore");
            if (response.IsSuccessStatusCode)
            {
                storeModels = JsonConvert.DeserializeObject<IEnumerable<StoreModel>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                storeModels = null;
            }
            return storeModels;

        }

        public async Task<string> AddAsync(StoreModel storeModel)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(storeModel), Encoding.UTF8, "application/json");


            var response = await _httpClient.PostAsync("Store/AddStore", stringContent);

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

        public async Task<StoreModel> getDetailAsycn(int id)
        {
            var response = await _httpClient.GetAsync($"Store/getDetail?id={id}");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<StoreModel>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                return null;
            }
        }
        public async Task<string> UpdateAsync(StoreModel StoreModel)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(StoreModel), Encoding.UTF8, "application/json");


            var response = await _httpClient.PutAsync("Store/UpdateStore", stringContent);

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
        public async Task<string> Delete(int id)
        {
            var response = await _httpClient.DeleteAsync($"Store/DeleteStore?id={id}");

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

        public async Task<IEnumerable<StoreModel>> GetListWtihBuildingAsync()
        {
            IEnumerable<StoreModel> storeModel;
            var response = await _httpClient.GetAsync("Store/GetListWtihBuilding");
            if (response.IsSuccessStatusCode)
            {
                storeModel = JsonConvert.DeserializeObject<IEnumerable<StoreModel>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                storeModel = null;
            }
            return storeModel;

        }

        public async Task<StoreModel> getByIdAsycn(int id)
        {
            var response = await _httpClient.GetAsync($"Store/getById?id={id}");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<StoreModel>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                return null;
            }
        }

    }
}