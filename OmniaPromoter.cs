using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class OmniaPromoter : Promotor
    {
        public OmniaPromoter(string firstName, string lastName, long phone) : base(firstName, lastName, phone)
        {
        }

        protected override void PaidAds()
        {
            Console.WriteLine("I use google paid ads ");
        }

        protected override void ShareWithInnerCircle()
        {
            Console.WriteLine("I share with my friends");
        }
    }
}
