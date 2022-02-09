using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodOrder.Models
{
    public class User
    {
        [Required,Key]
        public Guid Id { get; set; }
        [Required]
        public string FISH { get; set; }
        [Required]
        public string Nomer { get; set; }
        public string Manzil { get; set; }
        public List<Mahsulot> Savatcha { get; set; }
    }
}
