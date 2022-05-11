using System;
using System.ComponentModel.DataAnnotations;

namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "We need a name")]
        [StringLength(30, ErrorMessage = "Name must be within 50 characters")]
        public string FoodName { get; set; }

        [Required(ErrorMessage = "We need a number")]
        [Range(0, 10000, ErrorMessage = "Calories must be between 0 and 10,000")]
        public double? Calories { get; set; }

        [Required(ErrorMessage = "We need a number")]
        [Range(0, 10000, ErrorMessage = "Sugar must be between 0 and 10,000")]
        public double? Sugar { get; set; }

        [Required(ErrorMessage = "We need a number")]
        [Range(0, 10000, ErrorMessage = "Fat must be between 0 and 10,000")]
        public double? Fat { get; set; }

        [Required(ErrorMessage = "We need a number")]
        [Range(0, 10000, ErrorMessage = "Sodium must be between 0 and 10,000")]
        public double? Sodium { get; set; }

        [Required(ErrorMessage = "We need a number")]
        [Range(0, 10000, ErrorMessage = "Protein must be between 0 and 10,000")]
        public double? Protein { get; set; }
    }
}