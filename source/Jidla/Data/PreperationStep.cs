using System.ComponentModel.DataAnnotations;

namespace Jidla.Data
{
    public class PreperationStep
    {
        [Key]
        public int Id { get; set; }
        public int Sequence { get; set; }
        public string Description { get; set; } 
    }
}