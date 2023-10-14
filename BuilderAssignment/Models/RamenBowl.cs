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
            // If string is null in extra.The whole extra attritube is showing so just to implement it I make another return statement.
            // return  "This bowl of ramen contains: \n" + $"Broth:{ramen.BrothType}\n" 
            //+ $"Noodles:{ramen.NoodleType}\n"
            //+ $"Toppings:{ramen.Toppings}\n" + $"Extras:{ramen.Extras}\n";
            string description = "This bowl of ramen contains:";
            if (!string.IsNullOrEmpty(ramen.BrothType))
            {
                description += $" Broth: {ramen.BrothType} \n";
            }
            if (!string.IsNullOrEmpty(ramen.NoodleType))
            {
                description += $" Noodles: {ramen.NoodleType}\n";
            }
            if (!string.IsNullOrEmpty(ramen.Toppings))
            {
                description += $" Topping: {ramen.Toppings}\n";
            }
            if (!string.IsNullOrEmpty(ramen.Extras))
            {
                description += $" Extra: {ramen.Extras}\n";
            }
            return description;

        }
        }
    }

