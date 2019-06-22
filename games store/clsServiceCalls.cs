using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace games_store
{
    public static class clsServiceCalls
    {
        internal async static Task<List<string>> GetGameCategoriesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/game/GetGameCategories/"));
        }

        internal async static Task<List<clsGame>> GetCategoryGamesAsync(string prCategoryName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsGame>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/game/GetCategoryGames?Catergory=" + prCategoryName));
        }

        internal async static Task<List<clsOrder>> GetGameOrdersAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsOrder>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/game/GetGameOrders/"));
        }

        internal async static Task<string> UpdateGameAsync(clsGame game)
        {
            return await InsertOrUpdateAsync(game, "http://localhost:60064/api/game/PutGame", "PUT");
        }

        internal async static Task<string> InsertGameAsync(clsGame game)
        {
            return await InsertOrUpdateAsync(game, "http://localhost:60064/api/game/PostGame", "POST");
        }

        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content =
        new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal async static Task<string> DeleteGameAsync(string prId)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
                ($"http://localhost:60064/api/game/DeleteGame?Id={prId}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal async static Task<string> DeleteOrderAsync(string prId)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
                ($"http://localhost:60064/api/game/DeleteOrder?Id={prId}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }
    }
}
