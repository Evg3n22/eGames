﻿using System.ComponentModel.DataAnnotations;

namespace eGames.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public Game Game { get; set; }
        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
    }
}