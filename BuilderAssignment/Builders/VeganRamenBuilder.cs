using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    internal class VeganRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();
        public void settingBroth()
        {
            ramen.BrothType = "Vegan";
        }

        public void settingNoodle()
        {
            ramen.NoodleType = "Soba";
        }
        public void addTopping()
        {
            ramen.Topping.Add(Topping.BambooShoots);
            ramen.Topping.Add(Topping.Seaweed);
        }
        public void addExtra()
        {
            ramen.Extra = null;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }

    }
}
