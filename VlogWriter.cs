using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class VlogWriter : Writer
    {
        public VlogWriter(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void Vlog()
        {
            Console.WriteLine("I Vlog using My Go pro");
        }

        public override void Write()
        {
            Console.WriteLine("I Write for my vlog");
        }
    }
}
