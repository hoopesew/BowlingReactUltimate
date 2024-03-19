using System.ComponentModel.DataAnnotations;

namespace APIstuff.Data
{
    public partial class Team
    {
        [Key]
        public int TeamId { get; set; }

        public string TeamName { get; set; }
    }
}
