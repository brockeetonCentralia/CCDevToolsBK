using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace CCDevToolsBK.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string? Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public string CurrentVersion { get; set; }
        public string? Url { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
