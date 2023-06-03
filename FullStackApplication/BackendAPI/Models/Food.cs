using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace BackendAPI.Models
{
    public class Food
    {
        [Key]
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public string FoodDescription { get; set; }


        public int VendorID { get; set; }

        


    }
}
