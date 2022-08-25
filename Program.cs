using System;
using System.Collections.Generic;

namespace ch18PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Console.Write("\nEnter your Heist Locale's difficulty: ");

            int BankDifficultyLevel = int.Parse(Console.ReadLine());

            List<TeamMember> NewTeamList = new List<TeamMember>();

            void BuildTeam()
            {

                Console.Write("\nEnter a team member's name: ");

                string teamMemberName = Console.ReadLine();

                if (teamMemberName != "")
                {
                    Console.Write($"\nEnter {teamMemberName}'s skill level: ");

                    int teamMemberSkillLevel = int.Parse(Console.ReadLine());

                    Console.Write($"\nEnter {teamMemberName}'s courage factor (0.0 - 2.0): ");

                    double teamMemberCourageFactor = double.Parse(Console.ReadLine());

                    TeamMember newTeamMember = new TeamMember(teamMemberName, teamMemberSkillLevel, teamMemberCourageFactor);

                    // newTeamMember.DisplayInfo();

                    NewTeamList.Add(newTeamMember);

                    BuildTeam();

                }

            }

            BuildTeam();

            Console.Write("\nEnter the name of your team: ");

            string NewTeamName = Console.ReadLine();

            Team NewTeam = new Team(NewTeamName, NewTeamList);

            int TeamListLength = NewTeamList.Count;

            Console.WriteLine($"\nThere are {TeamListLength} members in your team.");

            // NewTeam.TeamMemberInfo();

            Console.Write("\nEnter the number of trials you would like to run: ");

            int TrialRuns = int.Parse(Console.ReadLine());

            int TeamSkillLevel = 0;

            foreach (TeamMember member in NewTeam.TeamList)
            {
                TeamSkillLevel += member.SkillLevel;
            }

            int FailedRuns = 0;
            int SuccesfulRuns = 0;

            for (int i = 0; i < TrialRuns; i++)
            {

                int Luck = new Random().Next(-10, 11);

                BankDifficultyLevel += Luck;

                // Console.WriteLine($"\nThe team's combined skill level is {TeamSkillLevel}. \nThe bank has a difficulty level of {BankDifficultyLevel}.");

                if (TeamSkillLevel >= BankDifficultyLevel)
                {
                    SuccesfulRuns++;
                }
                else
                {
                    FailedRuns++;
                }

            }

            Console.WriteLine($"\nAccording to the simulation, you've succeeded {SuccesfulRuns} times and failed {FailedRuns} times.");

        }
    }
}
