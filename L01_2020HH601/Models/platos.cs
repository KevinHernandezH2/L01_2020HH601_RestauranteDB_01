using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace L01_2020HH601.Models
{
    public class platos
    {
        [Key]
        public int platoId { get; set; }
        public string? nombrePlato { get; set; }
        public int precio { get; set; }
    }
}
