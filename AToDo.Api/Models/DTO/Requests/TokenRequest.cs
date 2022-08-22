﻿using System.ComponentModel.DataAnnotations;

namespace AToDo.Api.Models.DTO.Requests
{
    public class TokenRequest
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public string RefreshToken { get; set; }


    }
}
