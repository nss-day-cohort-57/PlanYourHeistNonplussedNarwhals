using System;
using System.Collections.Generic;


namespace ch18PlanYourHeist
{
    public class Team


    {
        public Team(string name)
        {
            Name = name;
            TeamList = new List<TeamMember>();
        }
        public Team(string name, List<TeamMember> teamList)
        {
            Name = name;
            TeamList = teamList;
        }

        public void TeamMemberInfo()
        {
            foreach (TeamMember member in TeamList)
            {
                member.DisplayInfo();
            }
        }

        string Name { get; set; }
        public List<TeamMember> TeamList { get; set; }
    }
}