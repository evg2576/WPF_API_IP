using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WPF_API_IP
{
    internal class APIHandler
    {
        public static async Task<RootObject> GetDataAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetFromJsonAsync<RootObject>(url);
            }
        }
    }
}
