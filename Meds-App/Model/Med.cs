using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Meds_App.Model
{
    public class Med
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pieces { get; set; }
        public string Type { get; set; }
        public DateTime BestBefore { get; set; }
        public byte[] Picture { get; set; }
        public string BaseSubstance { get; set; }
        public string BaseSubstanceQuantity { get; set; }
        public string Description { get; set; }
        public Med() { }

        public Med(string name, int pieces, string type, DateTime bestBefore, string baseSubstance, string baseSubstanceQuantity, string description, byte[] picture)
        {
            Name = name;
            Pieces = pieces;
            Type = type;
            BestBefore = bestBefore;
            Picture = picture;
            BaseSubstance = baseSubstance;
            BaseSubstanceQuantity = baseSubstanceQuantity;
            Description = description;
        }

        public Med(string name, int pieces, string type, DateTime bestBefore, string baseSubstance, string baseSubstanceQuantity, string description)
        {
            Name = name;
            Pieces = pieces;
            Type = type;
            BestBefore = bestBefore;
            BaseSubstance = baseSubstance;
            BaseSubstanceQuantity = baseSubstanceQuantity;
            Description = description;
        }

        public Med(string name, int pieces, string type, DateTime bestBefore, string description)
        {
            Name = name;
            Pieces = pieces;
            Type = type;
            BestBefore = bestBefore;
            Description = description;
        }

        public Med(string name, int pieces, string type, DateTime bestBefore, string description, byte[] picture)
        {
            Name = name;
            Pieces = pieces;
            Type = type;
            BestBefore = bestBefore;
            Picture = picture;
            Description = description;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name);
            stringBuilder.Append("\t");
            stringBuilder.Append(Pieces);
            stringBuilder.Append("\t");
            stringBuilder.Append(Type);
            stringBuilder.Append("\t");
            return stringBuilder.ToString();
        }
    }

    public class Http
    {
        static string uri = "http://localhost:5050/";
        static string appjson = "application/json";
        static string path = "http://localhost:5050/Meds";
        static string pathSorted = path + "/sorted";
        static string pathOutOfDate = path + "/date";
        static string pathOutOfDateSorted = path + "/sortedDate";

        public static async Task<bool> PostMedAsync(Med med)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(appjson));
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("Meds", med);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Med with name {med.Name} added on server!");
                    return true;
                }
            }
            catch
            {
                Console.WriteLine($"Med with name {med.Name} failed to add on server!");
                return false;
            }

            return false;
        }

       /*public static async Task<Med> GetMedByIdAsync(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(appjson));

            client.Timeout = TimeSpan.FromSeconds(2);
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{path}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Med with id {id} returned from server!");
                    return (Med)JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync(), typeof(Med));
                }
                throw new Exception($"Received status: {response.StatusCode}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }*/

        public static async Task<List<Med>> Get_Meds_Async(bool sorted)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(appjson));

            List<Med> meds = new List<Med>();
            client.Timeout = TimeSpan.FromSeconds(2);
            try
            {
                HttpResponseMessage response;
                if (sorted)
                {
                    response = await client.GetAsync($"{pathSorted}");
                }
                else
                {
                    response = await client.GetAsync($"{path}");
                }
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync();
                    meds = JsonConvert.DeserializeObject<List<Med>>(jsonString.Result);
                }
                Console.WriteLine($"Meds returned from server!");
                return meds;
                throw new Exception($"Received status: {response.StatusCode}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Med>();
            }
        }

        //TODO When open app call this function and count how many meds are out of date. Show messagebox
        public static async Task<List<Med>> Get_OutOfDate_Meds_Async(bool sorted)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(appjson));

            List<Med> meds = new List<Med>();
            client.Timeout = TimeSpan.FromSeconds(2);
            try
            {
                HttpResponseMessage response;
                if (sorted)
                {
                    response = await client.GetAsync($"{pathOutOfDateSorted}");
                }
                else
                {
                    response = await client.GetAsync($"{pathOutOfDate}");
                }
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync();
                    meds = JsonConvert.DeserializeObject<List<Med>>(jsonString.Result);
                }
                Console.WriteLine($"Out of date meds returned from server!");
                return meds;
                throw new Exception($"Received status: {response.StatusCode}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Med>();
            }
        }

        public static async Task<bool> PutMedAsync(Med med, int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(appjson));

            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync($"Meds/{id}", med);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Med with name {med.Name} updated on server!");
                    return true;
                }
            }
            catch
            {
                Console.WriteLine($"Med with name {med.Name} failed to update on server!");
                return false;
            }

            return false;

        }

        public static async Task<bool> DeleteMedAsync(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(uri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(appjson));
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(
                   $"Meds/{id}");
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Med with id {id} deleted from server!");
                    return true;
                }
            }
            catch
            {
                Console.WriteLine($"Med with id {id} failed to delete from server!");
                return false;
            }

            return false;
        }
    }
}
