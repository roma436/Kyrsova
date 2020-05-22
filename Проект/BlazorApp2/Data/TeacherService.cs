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
    public class TeacherService
    {
        string baseUrl = "https://localhost:44385/";

        public async Task<Teacher[]> GetTeacherAsync()
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Teacher/GetTeacher");
            return JsonConvert.DeserializeObject<Teacher[]>(json);
        }

        public async Task<Teacher> GetTeacherByIdAsync(string kodTeacher)
        {
            HttpClient http = new HttpClient();
            var json = await http.GetStringAsync($"{baseUrl}api/Teacher/GetTeacher/{kodTeacher}");
            return JsonConvert.DeserializeObject<Teacher>(json);
        }

        public async Task<HttpResponseMessage> InsertTeacherAsync(Teacher teacher)
        {
            var client = new HttpClient();
            return await client.PostAsync($"{baseUrl}api/Teacher/AddTeacher", getStringContentFromObject(teacher));
        }

        public async Task<HttpResponseMessage> UpdateTeacherAsync(string id, Teacher teacher)
        {
            var client = new HttpClient();
            return await client.PutAsync($"{baseUrl}api/Teacher/UpdateTeacher/{id}", getStringContentFromObject(teacher));
        }

        public async Task<HttpResponseMessage> DeleteTeacherAsync(string id)
        {
            var client = new HttpClient();
            return await client.DeleteAsync($"{baseUrl}api/Teacher/RemoveTeacher/{id}");
        }

        private StringContent getStringContentFromObject(object obj)
        {
            var serialized = JsonConvert.SerializeObject(obj);
            var stringContent = new StringContent(serialized, Encoding.UTF8, "application/json");
            return stringContent;
        }
    }
}
