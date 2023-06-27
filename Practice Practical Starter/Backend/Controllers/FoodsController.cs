using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data;
using Backend.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FoodsController : ControllerBase
    {
        // setup db access 
        private readonly AppDbContext db;
        public FoodsController(AppDbContext appdbContext){
         db = appdbContext;
        }
        //create get all foods method 
        // use http get request
        [HttpGet, Route("all")]
   
        public ActionResult<List<GetFoodResponse>> GetAllFoodItems() 
        {
                var foods = db.Foods.Include(food => food.Restaurant).ToList();

                var response = foods.Select(food => new GetFoodResponse(food)).ToList();
                return response;
        }




        // use http post to create new food item 
        [HttpPost, Route ("Create")]
       // [Authorize("IsAdmin")]
        public ActionResult<bool> CreateFoodItem(CreateFoodRequest request) { 
          var newFood = request.ConvertToFoodModel();
          db.Foods.Add(newFood);
          var numRowsChanged = db.SaveChanges();
          return numRowsChanged ==1;

        }


        // use http delte to remove food item
        [HttpDelete,Route ("Delete/{id}")] 
        // [Authorize("IsAdmin")]
          public ActionResult<bool> DeleteFoodItem(int id) { 
           var foodToDelete = db.Foods.Find(id);
          
         
          
           if (foodToDelete == null ) return false;
            // remove food matching id from database 
           db.Foods.Remove(foodToDelete);
            // save chagnes after deletion 
            var numRowsChanged = db.SaveChanges();
            return numRowsChanged ==1;

        }
    }
}