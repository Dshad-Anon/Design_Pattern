using BuilderAssignment.Builders;
using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment
{
    public class RamenChef
    {
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class
            builder.settingBroth();
            builder.settingNoodle();
            builder.addTopping();
            builder.addExtra();
            return builder.GetRamen() ; //TODO#2: Finaly return build bowl of ramen
        }
    }
}
