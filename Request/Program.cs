using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Request
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Payload payload = new Payload();
            payload.dtno = 5875162;
            payload.ftno = 0;
            payload.@params = "AssignID=2609;MTPeriod=0;DTMode=0;DTRange=720;DTOrder=1;MajorTable=M059;";
            payload.keyMap = "";
            payload.assignSpid = "";

            var jsonpayload = JsonConvert.SerializeObject(payload);
            var content = new StringContent(jsonpayload, Encoding.UTF8, "application/json");
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = (HttpResponseMessage)await httpClient.PostAsync("http://192.168.99.95:5000/api/customreport", content);
            Console.WriteLine(response);
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}
