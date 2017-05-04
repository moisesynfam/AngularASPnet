using System.ComponentModel.DataAnnotations;

namespace Angular_2___Asp_Net.Models
{
    public class Feature
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}