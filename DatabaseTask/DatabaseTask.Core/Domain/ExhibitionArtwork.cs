using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class ExhibitionArtwork
    {
        [Key]
        public int ExhibitionArtworkId { get; set; }
        public int ExhibitionId { get; set; }
        public int ArtworkId { get; set; }
        public Exhibition exhibition { get; set; }
        public Artwork Artwork { get; set; }
    }
}
