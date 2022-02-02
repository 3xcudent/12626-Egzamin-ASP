using _12626_Egzamin_ASP.Models;
using System.Linq;

namespace _12626_Egzamin_ASP.Contexts
{
    public class OcenyInitializer 
    {
        public static void Initialize(OcenyContext context)
        {
            context.Database.EnsureCreated();

            if (context.Oceny.Any())
            {
                return;
            }
            var oceny = new oceny[]
            {
                new oceny{NrIndeksu= 12626,Ocena = 4, Przedmiot = "Polski"}
            };
            foreach (oceny o in oceny)
            {
                context.Oceny.Add(o);
            }
            context.SaveChanges();
        }

    }
}
