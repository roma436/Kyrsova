using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using myprogram.DAL.Models;

namespace BlazorApp2.Data
{
    public class ParaService
    {
        string baseUrl = "https://localhost:44385/";

        public async Task<Para[]> GetParaAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Para/GetPara");
            return JsonConvert.DeserializeObject<Para[]>(json);
        }

        public async Task<Para> GetParaByIdAsync(string kodDial)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Para/GetPara/{kodDial}");
            return JsonConvert.DeserializeObject<Para>(json);
        }

        public async Task<HttpResponseMessage> InsertParaAsync(Para para)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/Para/AddPara", getStringContentFromObject(para));
        }

        public async Task<HttpResponseMessage> UpdateParaAsync(string id, Para para)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/Para/UpdatePara/{id}", getStringContentFromObject(para));
        }

        public async Task<HttpResponseMessage> DeleteParaAsync(string id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/Para/RemovePara/{id}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
