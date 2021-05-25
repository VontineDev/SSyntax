using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignClass
{
    partial class MaidRobot : Humanoid
    {
        public override void Grap()
        {
            base.Grap();
            Console.WriteLine("메이드 로봇이 물건을 집었습니다");
        }
    }
}
