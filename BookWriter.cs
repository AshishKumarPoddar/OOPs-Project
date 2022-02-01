using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class BookWriter : Writer
    {
        public BookWriter(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Vlog()
        {
            Console.WriteLine("I Vlog using My Mobile Phone");
        }

        public override void Write()
        {
            Console.WriteLine("I write books");
        }
    }
}
