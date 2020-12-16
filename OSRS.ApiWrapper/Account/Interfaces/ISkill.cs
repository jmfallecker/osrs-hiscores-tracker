namespace OSRS.Api.Account.Interfaces
{
    public interface ISkill
    {
        string Name { get; set; }
        int Rank { get; set; }
        int Level { get; set; }
        int Experience { get; set; }
    }
}
