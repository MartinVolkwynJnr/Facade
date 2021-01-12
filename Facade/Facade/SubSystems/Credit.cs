using Facade.Object;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Facade.SubSystems
{
    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}
