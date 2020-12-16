using OSRS.Api.Account.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OSRS.Api.Account.Helpers
{
    internal class ResponseStringToAccountMapper
    {

        const int TOTAL = 0;
        const int ATTACK = 1;
        const int DEFENSE = 2;
        const int STRENGTH = 3;
        const int HITPOINTS = 4;
        const int RANGED = 5;
        const int PRAYER = 6;
        const int MAGIC = 7;
        const int COOKING = 8;
        const int WOODCUTTING = 9;
        const int FLETCHING = 10;
        const int FISHING = 11;
        const int FIREMAKING = 12;
        const int CRAFTING = 13;
        const int SMITHING = 14;
        const int MINING = 15;
        const int HERBLORE = 16;
        const int AGILITY = 17;
        const int THIEVING = 18;
        const int SLAYER = 19;
        const int FARMING = 20;
        const int RUNECRAFT = 21;
        const int HUNTER = 22;
        const int CONSTRUCTION = 23;        

        internal IAccount Map(string responseString)
        {
            var hiscoresData = responseString.Split(' ');

            return new Account
            {
                Total = ParseSkill(hiscoresData[TOTAL], "Total"),
                Attack = ParseSkill(hiscoresData[ATTACK], "Attack"),
                Defense = ParseSkill(hiscoresData[DEFENSE], "Defense"),
                Strength = ParseSkill(hiscoresData[STRENGTH], "Strength"),
                Hitpoints = ParseSkill(hiscoresData[HITPOINTS], "Hitpoints"),
                Ranged = ParseSkill(hiscoresData[RANGED], "Ranged"),
                Prayer = ParseSkill(hiscoresData[PRAYER], "Prayer"),
                Magic = ParseSkill(hiscoresData[MAGIC], "Magic"),
                Cooking = ParseSkill(hiscoresData[COOKING], "Cooking"),
                Woodcutting = ParseSkill(hiscoresData[WOODCUTTING], "Woodcutting"),
                Fletching = ParseSkill(hiscoresData[FLETCHING], "Fletching"),
                Fishing = ParseSkill(hiscoresData[FISHING], "Fishing"),
                Firemaking = ParseSkill(hiscoresData[FIREMAKING], "Firemaking"),
                Crafting = ParseSkill(hiscoresData[CRAFTING], "Crafting"),
                Smithing = ParseSkill(hiscoresData[SMITHING], "Smithing"),
                Mining = ParseSkill(hiscoresData[MINING], "Mining"),
                Herblore = ParseSkill(hiscoresData[HERBLORE], "Herblore"),
                Agility = ParseSkill(hiscoresData[AGILITY], "Agility"),
                Thieving = ParseSkill(hiscoresData[THIEVING], "Thieving"),
                Slayer = ParseSkill(hiscoresData[SLAYER], "Slayer"),
                Farming = ParseSkill(hiscoresData[FARMING], "Farming"),
                Runecraft = ParseSkill(hiscoresData[RUNECRAFT], "Runecraft"),
                Hunter = ParseSkill(hiscoresData[HUNTER], "Hunter"),
                Construction = ParseSkill(hiscoresData[CONSTRUCTION], "Construction")
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private ISkill ParseSkill(string csv, string skillName)
        {
            const int RANK = 0;
            const int LEVEL = 1;
            const int EXPERIENCE = 2;

            var data = csv.Split(',');

            bool isRankOk = int.TryParse(data[RANK], out int rank);
            bool isLevelOk = int.TryParse(data[LEVEL], out int level);
            bool isExperienceOk = int.TryParse(data[EXPERIENCE], out int experience);

            return new Skill
            {
                Name = skillName,
                Rank = isRankOk ? rank : -1,
                Level = isLevelOk ? level : -1,
                Experience = isExperienceOk ? experience : -1
            };
        }
    }
}
