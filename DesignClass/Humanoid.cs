using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignClass
{
    class Humanoid : AbstractRobot
    {
        public override void Assist()
        {
            Console.WriteLine($"Assist from Humanoid");

        }

        public override void Grap()
        {
            Console.WriteLine($"Grap from Humanoid");
        }

        public override void Guide()
        {
            Console.WriteLine($"Guide from Humanoid");
        }
    }
}
