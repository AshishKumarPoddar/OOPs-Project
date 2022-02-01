using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Promotor > promotors = new List<Promotor>() { new XscClubPromoter("Raj", "Ranjan", 8430998776), new XscClubPromoter("Raju", "Rogi", 8430098776), new OmniaPromoter("Kalu", "Ram", 8430668776) };
            foreach(var promoter in promotors)
            {
                promoter.promote();
            }
            List<Writer> writers = new List<Writer>() { new BookWriter("Raj", "Ranjan"), new BookWriter("Raju", "Rogi"), new VlogWriter("Kalu", "Ram") };

            foreach (var writer in writers)
            {
                writer.Write();
            }

            List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder>() { new XscClubPromoter("Raj", "Ranjan", 8430998776), new XscClubPromoter("Raju", "Rogi", 8430098776)};


            foreach (var bodyBuilder in bodyBuilders)
            {
                bodyBuilder.Workout();
            }


            List<IVlogger> vloggers = new List<IVlogger>() { new XscClubPromoter("Raj", "Ranjan", 8430998776), new BookWriter("Raju", "Rogi")};

            foreach (var vlogger in vloggers)
            {
                vlogger.Vlog();
            }
            Console.ReadLine();
        }
    }
}
