using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Exhibition
    {
        [Key]
        public int ExhibitionId { get; set; }
        public int GalleryId { get; set; }
        public string Title { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Curator { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public Gallery Gallery { get; set; } 
        public ICollection<ExhibitionArtwork> ExhibitionArtworks { get; set; }

    }
}
