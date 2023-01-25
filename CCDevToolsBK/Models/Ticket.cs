using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CCDevToolsBK.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description{ get; set; }

        [Required]
        public StatusType Type  { get; set; }

        [Required]
        public DateTime OpenDate { get; set; }

        public DateTime? ModifiedDate { get; set; }


        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
