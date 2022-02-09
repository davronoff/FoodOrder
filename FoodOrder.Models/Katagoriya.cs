using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodOrder.Models
{
    public class Katagoriya
    {
        [Required,Key]
        public Guid Id { get; set; }
        [Required]
        public string Nomi { get; set; }
        public List<Mahsulot> Mahsulotlar { get; set; }
    }
}
