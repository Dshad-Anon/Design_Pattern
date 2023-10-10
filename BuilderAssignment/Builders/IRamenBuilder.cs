using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
        /// <summary>
        /// This is an interface represeting the steps to build the ramen bowl
        /// </summary>
        public interface IRamenBuilder
        {
            // TODO#1: Add methods for following steps
            void settingBroth(); // - Setting broth

            void settingNoodle(); // - Setting noodles

            void addTopping();  // - Adding toppings

            void addExtra(); // - Adding Extras

            /// <summary>
            /// Returns the value of build RamenBowl
            /// </summary>
            /// <returns></returns>
            RamenBowl GetRamen();
        }
    }

