using System;
using System.Collections.Generic;

namespace TesteAspNetCore2.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Createdatetime { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}
