﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Entity
{
    public class MovieModel
    {
        [Key] // primary key 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int MovieId { get; set; }
        public string MovieName { get; set; }
       
        
    }
}
