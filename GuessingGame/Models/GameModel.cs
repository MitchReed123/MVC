using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame.Models
{
    public class GameModel
    {
        [Display(Name = "Enter Your Name")]
        [Required(ErrorMessage = "You must enter your name")]

        public string PlayerName { get; set; }

        [Display(Name = "What is your guess")]
        [Required(ErrorMessage = "Guess is required")]
        public int Guess { get; set; }

        public override string ToString()
        {
            return $"{PlayerName} ({Guess})";
        }
    }
}