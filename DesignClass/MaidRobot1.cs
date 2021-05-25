using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignClass
{
    partial class MaidRobot : IHousework
    {
        private EquipmentInfo equipmentInfo = new EquipmentInfo();

        public void Brooming()
        {
            Console.WriteLine("메이드가 비질을 하고 있습니다");

        }

        public void Cook()
        {
            Console.WriteLine("메이드가 요리를 하고 있습니다");
        }

        public void Mob()
        {
            Console.WriteLine("메이드가 걸레질을 하고 있습니다");
        }
    }
}
