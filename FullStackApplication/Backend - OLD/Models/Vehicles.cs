using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Vehicles
    {
        [Key]
        public int vehicleID { get; set; }
        public string vehicleName { get; set; }
        public string vehicleType { get; set; }
        public string vehicleDescription { get; set; }
        public int VendorID { get; set; }
        public List<Vendor>? Vendors { get; set; }
    }
}
