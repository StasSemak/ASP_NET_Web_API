using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.DTOs
{
    public class PhoneDto
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Screen { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public string Camera { get; set; }
        public decimal Price { get; set; }
        public int Battery { get; set; }
        public string ImagePath { get; set; }

        public int OSId { get; set; }
        public string? OSName { get; set; }
    }
}
