using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Artwork
    {
        [Key]
        public int ArtworkId { get; set; }
        public string Ttile { get; set; } = string.Empty;
        public int YearCreated { get; set; }
        public string Medium { get; set; } = string.Empty;
        public string Dimensions { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; 

        public Artist Artist { get; set; }
        public ICollection<ExhibitionArtwork> ExhibitionArtWorks { get; set; }
    }
}
