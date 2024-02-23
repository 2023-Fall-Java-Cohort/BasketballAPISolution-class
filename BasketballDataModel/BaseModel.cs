using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballDataModel
{
    /// <summary>
    /// Base Class for all Data models
    /// </summary>
    public abstract class BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id;
        private DateTime updateOn = DateTime.UtcNow;
        private DateTime createDate = DateTime.UtcNow;
        private string name = null!;

        public int Id { get => id; set => id = value; }

        [Required]
        [StringLength(100)]
        public string Name { get => name; set => name = value; }

        public bool IsDeleted { get; set; } = false;

        [Required]
        public DateTime UpdateOn { get => updateOn; set => updateOn = value; }

        [Required]
        public DateTime CreateDate { get => createDate; set => createDate = value; }
    }
}
