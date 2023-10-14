using BuilderAssignment.Builders;
using BuilderAssignment.Models;
using System.ComponentModel.DataAnnotations;

namespace BuilderAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO#1: Wake up your RamenChef by initializing it
            RamenChef chef = new RamenChef();
            // TODO#2: Create new RamenBuilder's for each ramen recepies (MisoRamenBuilder, SpicyRamenBuilder, VeganRamenBuilder)
            // TODO#3: Use your RamenChef to prepare (build) each type of ramen (Miso, Spicy, Vegan)
            RamenBowl misoRamen = chef.PrepareRamen(new MisoRamenBuilder());
            RamenBowl veganRamen = chef.PrepareRamen(new VeganRamenBuilder());
            RamenBowl spicyRamen = chef.PrepareRamen(new MisoRamenBuilder());


            // TODO#4: After the RamenCheft has prepared the bowl of ramen, use FinishedBowlOfRamen to get the content of
            //         the RamenBowl and print it out using WriteLine method
            RamenBowl.FinishedBowlOfRamen(misoRamen);
            Console.WriteLine(RamenBowl.FinishedBowlOfRamen(misoRamen));

            RamenBowl.FinishedBowlOfRamen(veganRamen);
            Console.WriteLine(RamenBowl.FinishedBowlOfRamen(veganRamen));

            RamenBowl.FinishedBowlOfRamen(spicyRamen);
            Console.WriteLine(RamenBowl.FinishedBowlOfRamen(spicyRamen));
        }
    }
}