﻿using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player
    {
        public long Id { get; set; }

        [Required(ErrorMessage ="Please enter your Name")]
        public string FirstName { get; set; }

        [Range(1,9, ErrorMessage = "Choose a number")]
        public int Luck { get; set; }

        [Required(ErrorMessage ="Please enter a balance")]
        [Range (0, 1000, ErrorMessage = "Please enter a number between 0 and 100")]
        public decimal Balance { get; set; }
    }
}