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
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} has a skill level of {SkillLevel} and a courage factor of {CourageFactor}");
        }
    }
}