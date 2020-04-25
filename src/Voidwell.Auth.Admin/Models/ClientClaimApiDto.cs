﻿using System.ComponentModel.DataAnnotations;

namespace Voidwell.Auth.Admin.Models
{
    public class ClientClaimApiDto
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Value { get; set; }
    }
}