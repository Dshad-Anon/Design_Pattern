using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Models
{
        /// <summary>
        /// This class represents the final bowl of ramen
        /// It should have attributes like broth, type of noodle, toppings and extras
        /// </summary>
        public class RamenBowl
        {
            //TODO#1: Add attributes for each enum in IngredientEnums.cs file
            public string? BrothType{get; set;}
            
            public string? NoodleType { get; set; }

            public string? Toppings { get; set; }

            public string? Extras { get; set; }
            //TODO#2: Return description of finished bowl of ramen
            public static string FinishedBowlOfRamen(RamenBowl ramen)
            {
                 return  "This bowl of ramen contains: \n" + $"Broth:{ramen.BrothType}" + $"Noodles:{ramen.NoodleType}" + $"Toppings:{ramen.Toppings}" + $"Extras:{ramen.Extras}";
               
            }
        }
    }

