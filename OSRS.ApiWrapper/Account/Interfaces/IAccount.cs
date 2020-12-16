namespace OSRS.Api.Account.Interfaces
{
    public interface IAccount
    {
        public string DisplayName { get; set; }
        ISkill Total { get; set; }
        ISkill Attack { get; set; }
        ISkill Defense { get; set; }
        ISkill Strength { get; set; }
        ISkill Hitpoints { get; set; }
        ISkill Ranged { get; set; }
        ISkill Prayer { get; set; }
        ISkill Magic { get; set; }
        ISkill Cooking { get; set; }
        ISkill Woodcutting { get; set; }
        ISkill Fletching { get; set; }
        ISkill Fishing { get; set; }
        ISkill Firemaking { get; set; }
        ISkill Crafting { get; set; }
        ISkill Smithing { get; set; }
        ISkill Mining { get; set; }
        ISkill Herblore { get; set; }
        ISkill Agility { get; set; }
        ISkill Thieving { get; set; }
        ISkill Slayer { get; set; }
        ISkill Farming { get; set; }
        ISkill Runecraft { get; set; }
        ISkill Hunter { get; set; }
        ISkill Construction { get; set; }
    }
}
