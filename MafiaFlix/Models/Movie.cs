using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MafiaFlix.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MovieId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public string Direction { get; set; }
        public string Cover { get; set; }
    }
}
