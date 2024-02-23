using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace BasketballDataModel
{
    [Table("Positions")]
    [Index("Name", IsUnique = true)]
    public class PositionModel : BaseModel
    {
        public virtual List<PlayerModel>?  Players { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
