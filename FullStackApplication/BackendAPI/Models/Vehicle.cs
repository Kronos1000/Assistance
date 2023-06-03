using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BackendAPI.Models
{
    public class Vehicle
    {
        
        public int vehicleID { get; set; }
        public string vehicleName { get; set; }
        public string vehicleType { get; set; }
        public string vehicleDescription { get; set; }
        public int VendorID { get; set; }
    }
}
