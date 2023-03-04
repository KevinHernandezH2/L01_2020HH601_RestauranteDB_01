using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace L01_2020HH601.Models
{
    public class motoristas
    {
        [Key]
        public int motoristaId { get; set; }
        public string? nombreMotorista { get; set; }
    }
}
