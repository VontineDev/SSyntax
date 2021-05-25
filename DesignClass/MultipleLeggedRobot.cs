using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignClass
{
    class MultipleLeggedRobot : AbstractRobot
    {
        public override void Assist()
        {
            Console.WriteLine($"Assist from MultipleLeggedRobot");
        }

        public override void Grap()
        {
            Console.WriteLine($"Grap from MultipleLeggedRobot");
        }

        public override void Guide()
        {
            Console.WriteLine($"Guide from MultipleLeggedRobot");
        }
    }
}
