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
    public class RoomApiService
    {
        private readonly HttpClient _httpClient;

        public RoomApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<RoomModel>> getListAsyc()
        {
            IEnumerable<RoomModel> roomModels;
            var response = await _httpClient.GetAsync("Room/getListRoom");
            if (response.IsSuccessStatusCode)
            {
                roomModels = JsonConvert.DeserializeObject<IEnumerable<RoomModel>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                roomModels = null;
            }
            return roomModels;

        }
        public async Task<IEnumerable<RoomModel>> GetListWtihBuildingAsync()
        {
            IEnumerable<RoomModel> roomModels;
            var response = await _httpClient.GetAsync("Room/GetListWtihBuilding");
            if (response.IsSuccessStatusCode)
            {
                roomModels = JsonConvert.DeserializeObject<IEnumerable<RoomModel>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                roomModels = null;
            }
            return roomModels;

        }

        public async Task<string> AddAsync(RoomModel RoomModel)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(RoomModel), Encoding.UTF8, "application/json");


            var response = await _httpClient.PostAsync("Room/AddRoom", stringContent);

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

        public async Task<RoomModel> getByIdAsycn(int id)
        {
            var response = await _httpClient.GetAsync($"Room/getById?id={id}");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<RoomModel>(response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                return null;
            }
        }
        public async Task<string> UpdateAsync(RoomModel RoomModel)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(RoomModel), Encoding.UTF8, "application/json");


            var response = await _httpClient.PutAsync("Room/UpdateRoom", stringContent);

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
            var response = await _httpClient.DeleteAsync($"Room/DeleteRoom?id={id}");

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
