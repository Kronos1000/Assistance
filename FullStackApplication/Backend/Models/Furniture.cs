using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Backend.Models
{
    public class Furniture
    {
        [Key]
        public int furnitureID { get; set; }
        public string? furnitureName { get; set; }
        public string? furnitureType { get; set; }
        public string? furnitureDescription { get; set; }
        public int VendorID { get; set; }
        public List<Vendor>? Vendors;



    }
}
