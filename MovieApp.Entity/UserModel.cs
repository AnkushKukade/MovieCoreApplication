using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Model validation
using System.ComponentModel.DataAnnotations.Schema; //Sql const
using System.Text;

namespace MovieApp.Entity
{
    public class UserModel

    { 
        [Key]  // primary key 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; } //property
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Mobile { get; set; }
    }
}
