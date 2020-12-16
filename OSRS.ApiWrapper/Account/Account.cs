using OSRS.Api.Account.Interfaces;

namespace OSRS.Api.Account
{
    public class Account : IAccount
    {
        public string DisplayName { get; set; }
        public ISkill Total { get; set; }
        public ISkill Attack { get; set; }
        public ISkill Defense { get; set; }
        public ISkill Strength { get; set; }
        public ISkill Hitpoints { get; set; }
        public ISkill Ranged { get; set; }
        public ISkill Prayer { get; set; }
        public ISkill Magic { get; set; }
        public ISkill Cooking { get; set; }
        public ISkill Woodcutting { get; set; }
        public ISkill Fletching { get; set; }
        public ISkill Fishing { get; set; }
        public ISkill Firemaking { get; set; }
        public ISkill Crafting { get; set; }
        public ISkill Smithing { get; set; }
        public ISkill Mining { get; set; }
        public ISkill Herblore { get; set; }
        public ISkill Agility { get; set; }
        public ISkill Thieving { get; set; }
        public ISkill Slayer { get; set; }
        public ISkill Farming { get; set; }
        public ISkill Runecraft { get; set; }
        public ISkill Hunter { get; set; }
        public ISkill Construction { get; set; }
    }
}
