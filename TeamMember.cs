using System;

namespace ch18PlanYourHeist
{
    public class TeamMember
    {
        public TeamMember(string name, int skillLevel, double courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }
        string Name { get; set; }
        int SkillLevel { get; set; }
        double CourageFactor { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} has a skill level of {SkillLevel} and a courage factor of {CourageFactor}");
        }
    }
}