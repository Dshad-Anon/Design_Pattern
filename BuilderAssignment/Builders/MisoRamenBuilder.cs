using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    internal class MisoRamenBuilder : IRamenBuilder
    {
        // NOTE: Since in this assignment we are using IRamenBuilder which is interface, remeber to create the RamenBowl object
        ///       inside each ramen type builder class => private RamenBowl ramen = new RamenBowl();
        private RamenBowl ramen = new RamenBowl();

        public void settingBroth()
        {
           ramen.BrothType = "Miso";
        }

        public void settingNoodle()
        {
            ramen.NoodleType = "Udon";
        }
        public void addTopping()
        {
            ramen.Topping.Add(Topping.GreenOnions);
        }
        public void addExtra()
        {
            ramen.Extra.Add(Extra.Corn);
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }

        
    }

}
