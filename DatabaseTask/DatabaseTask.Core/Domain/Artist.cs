using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public int BirthYear { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public string Biography { get; set; } = string.Empty;

        public ICollection<Artwork> Artworks { get; set; }
    }
}
