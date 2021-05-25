using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignClass
{
    class SpiderRobot : MultipleLeggedRobot, IGuard
    {
        public override void Assist()
        {
            Console.WriteLine("거미 로봇이 돕습니다");

        }
        public override void Guide()
        {
            Console.WriteLine("거미 로봇이 두 다리를 흔들며 안내합니다");

        }
        public override void Grap()
        {
            Console.WriteLine("거미 로봇이 세번째 다리로 무언가 집습니다");

        }

        public void Search()
        {
            Console.WriteLine("거미 로봇이 적대적 대상을 찾습니다");

        }

        public void Suppression()
        {
            Console.WriteLine("거미 로봇이 적을 제압합니다");

        }

        public void Comeback()
        {
            Console.WriteLine("거미 로봇이 귀환합니다");

        }
    }
}
