﻿using System.ComponentModel.DataAnnotations;

namespace MedicineX.DbModel
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
    }
}
