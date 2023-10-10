using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    internal class SpicyRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();
        public void settingBroth()
        {
            ramen.BrothType = "SpicyTonkotsu";
        }

        public void settingNoodle()
        {
            ramen.NoodleType = "Thin";
        }
        public void addTopping()
        {
            ramen.Toppings = "Gashu Pork & Green Onions";
        }
        public void addExtra()
        {
            ramen.Extras = "Extra Spice";
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
