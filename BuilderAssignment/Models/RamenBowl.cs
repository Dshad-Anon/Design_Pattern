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
            public  BrothType Broth {get; set;}
            
            public  NoodleType Noodle { get; set; }

            public List<Topping> Topping { get; set; } = new List<Topping>();

            public List<Extra> Extra { get; set; } = new List<Extra>();
            //TODO#2: Return description of finished bowl of ramen
            public static string FinishedBowlOfRamen(RamenBowl ramen)
            {
            // If string is null in extra.The whole extra attritube is showing so just to implement it I make another return statement.
            // return  "This bowl of ramen contains: \n" + $"Broth:{ramen.BrothType}\n" 
            //+ $"Noodles:{ramen.NoodleType}\n"
            //+ $"Toppings:{ramen.Toppings}\n" + $"Extras:{ramen.Extras}\n";
            string description = "This bowl of ramen contains:";
            if (!string.IsNullOrEmpty(ramen.Broth.ToString()))
            {
                description += $" Broth: {ramen.Broth} \n";
            }
            if (!string.IsNullOrEmpty(ramen.Noodle.ToString()))
            {
                description += $" Noodles: {ramen.Noodle}\n";
            }
            //if (!string.IsNullOrEmpty(ramen.Topping.ToString()))
            //{
            //    description += $" Topping: {ramen.Topping}\n";
            //}
            //if (!string.IsNullOrEmpty(ramen.Extra.ToString()))
            //{
            //    description += $" Extra: {ramen.Extra}\n";
            //}
            if (ramen.Topping != null && ramen.Topping.Count > 0)
            {
                description += " Toppings: ";
                foreach (var topping in ramen.Topping)
                {
                    description += $"{topping}, ";
                }
                description = description.TrimEnd(',', ' ') + "\n";
            }

            if (ramen.Extra != null && ramen.Extra.Count > 0)
            {
                description += " Extras: ";
                foreach (var extra in ramen.Extra)
                {
                    description += $"{extra}, ";
                }
                description = description.TrimEnd(',', ' ') + "\n";
            }
            return description;

        }
        }
    }

