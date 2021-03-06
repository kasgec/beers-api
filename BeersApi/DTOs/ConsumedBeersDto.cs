﻿using System;

namespace BeersApi.DTOs
{
    public class ConsumedBeersDto
    {
        public Guid Id { get; set; }
        public Guid BeerId { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public bool NonAlcohol { get; set; }
        public decimal Volume { get; set; }
    }
}
