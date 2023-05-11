using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_EFCF.Models
{
    public class PlayerInformation
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime DoB { get; set; }
        public string Nationality { get; set; }
        [ForeignKey("PlayerId")]
        public Player Player { get; set; }
    }
}
