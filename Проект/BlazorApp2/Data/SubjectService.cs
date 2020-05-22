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
    public class SubjectService
    {
        string baseUrl = "https://localhost:44385/";

        public async Task<Subject[]> GetSubjectAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Subject/GetSubject");
            return JsonConvert.DeserializeObject<Subject[]>(json);
        }

        public async Task<Subject> GetSubjectByIdAsync(string kodSubject)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Subject/GetSubject/{kodSubject}");
            return JsonConvert.DeserializeObject<Subject>(json);
        }

        public async Task<HttpResponseMessage> InsertSubjetcAsync(Subject subject)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/Subject/AddSubject", getStringContentFromObject(subject));
        }

        public async Task<HttpResponseMessage> UpdateSubjectAsync(string id, Subject subject)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/Subject/UpdateSubject/{id}", getStringContentFromObject(subject));
        }

        public async Task<HttpResponseMessage> DeleteSubjectAsync(int id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/Subject/RemoveSubject/{id}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
