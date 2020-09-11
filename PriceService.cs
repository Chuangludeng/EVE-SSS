using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EVE_SSS.PriceStructure
{
    public class All
    {
        public int max { get; set; }
        public double min { get; set; }
        public long volume { get; set; }
    }

    public class Buy
    {
        public double max { get; set; }
        public double min { get; set; }
        public long volume { get; set; }
    }

    public class Sell
    {
        public int max { get; set; }
        public int min { get; set; }
        public long volume { get; set; }
    }

    public class Root
    {
        public All all { get; set; }
        public Buy buy { get; set; }
        public Sell sell { get; set; }
    }
}

namespace EVE_SSS
{
    public class PriceService
    {
        public PriceService()
        {

        }

        public static PriceStructure.Root GetPrice(int type_id)
        {
            var task = GetCallAPI("https://www.ceve-market.org/api/market/region/10000002/type/" + type_id.ToString() + ".json");

            task.Wait();

            return task.Result;
        }

        public static async Task<PriceStructure.Root> GetCallAPI(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    if (response != null)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<PriceStructure.Root>(jsonString);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
    }
}
