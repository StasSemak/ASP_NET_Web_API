using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Phone
    {
        public int Id { get; set; }

        [Required, StringLength(100, MinimumLength = 4)]
        public string Model { get; set; }

        [Required, StringLength(100, MinimumLength = 4)]
        public string Screen { get; set; }

        [Required, Range(1, 64)]
        public int RAM { get; set; }

        [Required, Range(1, 1024)]
        public int Storage { get; set; }

        [Required, StringLength(150, MinimumLength = 4)]
        public string Camera { get; set; }

        [Required, Range(1, 100000)]
        public decimal Price { get; set; }

        [Required, Range(1, 12000)]
        public int Battery { get; set; }

        [Required, StringLength(1000, MinimumLength = 4)]
        public string ImagePath { get; set; }

        public int OperationSystemId { get; set; }
        public OperationSystem? OperationSystem { get; set; }
    }
}
