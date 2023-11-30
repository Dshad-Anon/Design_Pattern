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
            ramen.Topping.Add(Topping.ChashuPork);
            ramen.Topping.Add(Topping.GreenOnions);
        }
        public void addExtra()
        {
            ramen.Extra.Add(Extra.ExtraSpice);
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}

