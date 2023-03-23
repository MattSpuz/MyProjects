using System.ComponentModel.DataAnnotations;
using System;
using Newtonsoft.Json;
using System.Web;
using System.Collections.Generic;

namespace TempManager.Models
{
    public class Histories
    {
        public int Id { get; set; }

        public string FoodName { get; set; }

        public double? Calories { get; set; }

        public double? Sugar { get; set; }

        public double? Fat { get; set; }

        public double? Sodium { get; set; }

        public double? Protein { get; set; }
    }
}
