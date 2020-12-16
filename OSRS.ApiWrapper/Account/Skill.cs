using OSRS.Api.Account.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OSRS.Api.Account
{
    public class Skill : ISkill
    {
        public string Name { get; set; }
        public int Rank { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
    }
}
