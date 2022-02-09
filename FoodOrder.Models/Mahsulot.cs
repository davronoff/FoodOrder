using System;
using System.ComponentModel.DataAnnotations;

namespace FoodOrder.Models
{
    public class Mahsulot
    {
        [Required,Key]
        public Guid Id { get; set; }
        [Required,MaxLength(50)]
        public string Nomi { get; set; }
        [Required]
        public string Batafsil { get; set; }
        [Required]
        public double Narxi { get; set; }
        [Required]
        public string Rasmi { get; set; }
        public Guid KatagoriyaId { get; set; }
        public Guid UserId { get; set; }

    }
}
