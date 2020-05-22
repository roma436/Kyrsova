using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using myprogram.DAL.Models;
using Newtonsoft.Json.Linq;

namespace BlazorApp2.Data
{
    public class LoadService
    {
        string baseUrl = "https://localhost:44385/";

        public async Task<Load[]> GetLoadAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Load/GetLoad");
            return JsonConvert.DeserializeObject<Load[]>(json);
        }

        public async Task<Load> GetLoadByIdAsync(string kodSubject)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Load/GetLoad/{kodSubject}");
            return JsonConvert.DeserializeObject<Load>(json);
        }

        public async Task<HttpResponseMessage> InsertLoadAsync(Load load)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/Load/AddLoad", getStringContentFromObject(load));
        }

        public async Task<HttpResponseMessage> UpdateLoadAsync(string id, Load load)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/Load/UpdateLoad/{id}", getStringContentFromObject(load));
        }

        public async Task<HttpResponseMessage> DeleteLoadAsync(string id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/Load/RemoveLoad/{id}");
        }

        public async Task <IEnumerable<JObject>> GetZaputByCodDial()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Load/GetLoad12");
            Console.WriteLine(json);
            return JsonConvert.DeserializeObject <IEnumerable<JObject>> (json);
        }


        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
