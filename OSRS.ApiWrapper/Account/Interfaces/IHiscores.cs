using OSRS.Api.Account.Enumerations;
using System.Threading.Tasks;

namespace OSRS.Api.Account.Interfaces
{
    public interface IHiscores
    {
        Task<IAccount> GetHiscores(string name, AccountType accountType);
    }
}
