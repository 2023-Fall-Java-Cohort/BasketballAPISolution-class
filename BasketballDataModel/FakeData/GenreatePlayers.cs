using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballDataModel.FakeData
{
    public class GenreatePlayers
    {
        private Faker<PlayerModel> PlayerRules( int numberOfTeams, int numberOfPositions)
        {
            int id = 1;
            return new Faker<PlayerModel>()
                .RuleFor(p=>p.Id, f=> id++)
                .RuleFor(p=>p.Name,f=>f.Person.FullName)
                .RuleFor(p=>p.Birthdate,f=>f.Person.DateOfBirth)
                .RuleFor(p=>p.Salary,f=> f.Random.Decimal(10000,400000))
                .RuleFor(p=>p.NationalRank,f=>f.Random.Int(1,100))
                .RuleFor(p => p.PositionId, f => f.Random.Int(1, numberOfPositions))
                .RuleFor(p=>p.TeamId, f => f.Random.Int(1, numberOfTeams));
        }

        public List<PlayerModel> GetPlayers(int numberOfPlayers, int numberOfTeams, int numberOfPositions)
        {
            Faker<PlayerModel> playerFaker = PlayerRules(numberOfTeams, numberOfPositions);
            return playerFaker.Generate(numberOfPlayers);
        }
    }
}
