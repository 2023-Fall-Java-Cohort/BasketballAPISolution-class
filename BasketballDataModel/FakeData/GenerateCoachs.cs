using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballDataModel.FakeData
{
    public class GenerateCoachs
    {
        private int titleCount =1;
        private int teamCount = 1;
        private readonly int numberOfTeams;
        private readonly int numberofTitles;

        public GenerateCoachs(int numberOfTeams)
        {
            this.numberOfTeams = numberOfTeams;
            this.numberofTitles = Enum.GetValues(typeof(CoachTitle)).Length;
        }
        private Faker<CoachModel> CoachRules()
        {
            int id = 1;
            return new Faker<CoachModel>()
                .RuleFor(p => p.Id, f => id++)
                .RuleFor(p => p.Name, f => f.Person.FullName)
                .RuleFor(p=> p.Title, f=> GetTitle())
                .RuleFor(p => p.TeamId, f => GetTeam());
        }
        private CoachTitle GetTitle()
        {
            if(titleCount > numberofTitles)
            {
                titleCount = 1;
                teamCount++;
               
            }
            return (CoachTitle)titleCount++;
        }
        private int GetTeam()
        {
            if (teamCount > numberOfTeams)
            {
                teamCount = 1;
            }
            return teamCount;
        }
        public List<CoachModel> GetCoachs()
        {
            Faker<CoachModel> coachFaker = CoachRules();
            return coachFaker.Generate(numberOfTeams*numberofTitles);
        }
    }
}
