using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Food
    {
        
        public int FoodId {get;set;}
        public string Name {get;set;} = default!;
        public string Description {get;set;} = default!;

        // create restaurant id relationship
        public int RestaurantId {get;set;}
        // create FK  realtionship 
        public Restaurant? Restaurant {get;set;} 
    }
}