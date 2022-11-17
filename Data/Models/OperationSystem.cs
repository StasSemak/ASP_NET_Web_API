using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class OperationSystem
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Phone> Phones { get; set; }
    }
}
