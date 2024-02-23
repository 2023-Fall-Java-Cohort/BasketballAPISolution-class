

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace BasketballDataModel
{
    [Table("Teams")]
    [Index("Name",IsUnique = true)]
    public class TeamModel : BaseModel
    {
        private int nationalRank;
        private int seasonWins;
        private int seasonLoss;

        public int NationalRank { get => nationalRank; set => nationalRank = value; }
        public int SeasonWins { get => seasonWins; set => seasonWins = value; }
        public int SeasonLoss { get => seasonLoss; set => seasonLoss = value; }

        [NotMapped]
        public int NumberOfPlayers { get
            {
                if(Players is null) return 0;
                return Players.Count;
            } 
        }
        [NotMapped]
        public string TotalCostOfPlayers
        {
            get
            {
                if (Players is null) return "$0";
                int current = 0;
                foreach(PlayerModel player in Players)
                {
                    current += (int)player.Salary;
                }
                return string.Format("{0:C0}", current);
            }
        }
        public virtual List<CoachModel>? Coaches { get; set; }
        public virtual List<PlayerModel>? Players { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
