using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class XscClubPromoter : Promotor,IBodyBuilder,IVlogger
    {
        public XscClubPromoter(string firstName, string lastName, long phone) : base(firstName, lastName, phone)
        {
        }

        protected override void PaidAds()
        {
            Console.WriteLine("I use facebook ads ");
        }

        protected override void ShareWithInnerCircle()
        {
            Console.WriteLine("I share with my instagram follwers");
        }
        public void Vlog()
        {
            Console.WriteLine("I use Dslr");
        }

        public void Workout()
        {
            Console.WriteLine("I  work out in my home"); 
        }

    }
}
