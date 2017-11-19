using System.ComponentModel.DataAnnotations;

namespace CameraBazzar.Data.Models
{
    public class Camera
    {
        public int Id { get; set; }

        public CameraMakeType Make { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        public decimal Price { get; set; }

        [Range(0, 100)]
        public int Quantity { get; set; }

        [Range(1, 30)]
        public int MinShutterSpeed { get; set; }

        [Range(2000, 8000)]
        public int MaxShutterSpeed { get; set; }
        
        public MinISOType MinISO { get; set; }

        [Range(200, 409600)]
        public int MaxISO { get; set; }

        public bool IsFullFrame { get; set; }

        [MaxLength(15)]
        public string VideoResolution { get; set; }

        public LightMeteringType LighMeteringType { get; set; }

        [MaxLength(6000)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
