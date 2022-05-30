using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TempManager.Models
{
    public class Users 
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Username is empty")]
        [StringLength(30, ErrorMessage = "Username must be within 50 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is empty")]
        [StringLength(30, ErrorMessage = "Password must be within 50 characters")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Name is empty")]
        [StringLength(30, ErrorMessage = "Name must be within 50 characters")]
        public string Name { get; set; }
        public string role { get; set; }

    }
}
