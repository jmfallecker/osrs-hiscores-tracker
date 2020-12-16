using OSRS.Api.Account.Enumerations;
using OSRS.Api.Account.Helpers;
using OSRS.Api.Account.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OSRS.Api.Account
{
    public class Hiscores : IHiscores
    {
        private ResponseStringToAccountMapper _mapper = new ResponseStringToAccountMapper();

        private Uri EndpointBuilder(string name, AccountType type)
        {
            var accountType = type switch
            {
                AccountType.Regular => "hiscore_oldschool",
                AccountType.Ironman => "hiscore_oldschool_ironman",
                AccountType.Hardcore => "hiscore_oldschool_hardcore_ironman",
                AccountType.Ultimate => "hiscore_oldschool_ultimate",
                AccountType.Deadman => "hiscore_oldschool_deadman",
                AccountType.Seasonal => "hiscore_oldschool_seasonal",
                AccountType.Tournament => "hiscore_oldschool_tournament",
                _ => "hiscore_oldschool",
            };

            var endpoint = $"https://secure.runescape.com/m={accountType}/index_lite.ws?player={name}";

            return new Uri(endpoint);
        }

        public async Task<IAccount> GetHiscores(string name, AccountType accountType)
        {
            var url = EndpointBuilder(name, accountType);

            using var client = new HttpClient();           
            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode) return new Account();

            return _mapper.Map(await response.Content.ReadAsStringAsync());
        }
    }
}
