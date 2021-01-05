using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Udemy_NetCore.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UsernameId { get; set; }
        public byte[] PaswordHash { get; set; }
        public byte[] PaswordSalt { get; set; }
        public List<Character> Characters { get; set; }
        [Required]
        public string Role { get; set; } // not nullable
    }
}