﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ERPTP.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Movie Movie { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DataReturned { get; set; }
    }
}