using System;

namespace ch18PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.Write("Enter a team member's name: ");

            string teamMember1Name = Console.ReadLine();

            Console.Write($"Enter {teamMember1Name}'s skill level: ");

            int teamMember1SkillLevel = int.Parse(Console.ReadLine());

            Console.Write($"Enter {teamMember1Name}'s courage factor (0.0 - 2.0): ");

            double teamMember1CourageFactor = double.Parse(Console.ReadLine());

            TeamMember SafeCracker = new TeamMember(teamMember1Name, teamMember1SkillLevel, teamMember1CourageFactor);

            SafeCracker.DisplayInfo();
        }
    }
}
