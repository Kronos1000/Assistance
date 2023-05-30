namespace Backend.Models
{
    public class Food
    {
        public int FoodID { get; set; }
        public string FoodName { get; set;  }

        public string FoodType { get; set;  }

        public string FoodDescription { get; set; }

        public int VendorID {get;set;}
        public List<Vendor>? Vendors;
    }
}
