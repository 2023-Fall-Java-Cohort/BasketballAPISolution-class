using Bogus.DataSets;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace BasketballDataModel
{
    [Table("Players")]
    [Index("Name", IsUnique = false)]
    public class PlayerModel : BaseModel
    {
       
        private int nationalRank;
        private DateTime birthdate;
        private bool isActive = true;
     
        private decimal salary;
        private int teamId;

       
        public int NationalRank { get => nationalRank; set => nationalRank = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public bool IsActive { get => isActive; set => isActive = value; }

        [Column(TypeName = "money")]
        [Range(0,5000000)]
        public decimal Salary { get => salary; set => salary = value; }
        [NotMapped]
        public string GetSalary
        {
            get
            {
              return string.Format("{0:C0}", salary);
            }
        }
        public int TeamId { get => teamId; set => teamId = value; }
        public int PositionId { get; set; }

        [ForeignKey("PositionId")]
        public virtual PositionModel? Position { get; set; }

        [ForeignKey("TeamId")]
        public virtual TeamModel? Team { get;set; }

        [NotMapped]
        public int Age
        {
            get
            {
                return DateTime.Now.Year - Birthdate.Year;
            }
        }

        /// <summary>
        /// Used to build a Json string of this object.
        /// </summary>
        /// <returns>Json String.</returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
