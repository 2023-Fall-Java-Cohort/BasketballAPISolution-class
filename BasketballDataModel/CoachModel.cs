using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BasketballDataModel
{
    /// <summary>
    /// Coach Data Model
    /// </summary>
    /// <seealso cref="BasketballDataModel.BaseModel" />
    [Table("Coaches")]
    [Index("Name", IsUnique = false)]
    public class CoachModel : BaseModel
    {

        private CoachTitle title;
        private int teamId;


        public CoachTitle Title { get => title; set => title = value; }
        public int TeamId { get => teamId; set => teamId = value; }

        [ForeignKey("TeamId")]
        public virtual TeamModel? Team { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
