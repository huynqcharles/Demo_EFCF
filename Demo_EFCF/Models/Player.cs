using System.ComponentModel.DataAnnotations;

namespace Demo_EFCF.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public PlayerInformation PlayerInformation { get; set; }
        public ICollection<Position> Positions { get; set; }
    }
}
