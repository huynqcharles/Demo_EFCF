﻿using System.ComponentModel.DataAnnotations;

namespace Demo_EFCF.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
