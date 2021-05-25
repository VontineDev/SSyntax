using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignClass
{
    class App
    {
        public App()
        {
            MaidRobot maidRobot = new MaidRobot();

            maidRobot.size = SizeOfRobot.Medium;

            maidRobot.color = ColorOfRobot.Red;

            Console.WriteLine($"메이드로봇의 사이즈는 {maidRobot.size}, 색상은 {maidRobot.color} 입니다");



            maidRobot.Guide();

            maidRobot.Assist();

            maidRobot.Grap();

            maidRobot.Brooming();

            maidRobot.Mob();

            maidRobot.Cook();

            MultipleLeggedRobot multipleLegged = new SpiderRobot();

            multipleLegged.Assist();

            multipleLegged.color = ColorOfRobot.Black;

            multipleLegged.size = SizeOfRobot.Large;

            Console.WriteLine($"스파이더로봇의 컬러는 {multipleLegged.color}, 사이즈는 {multipleLegged.size} 입니다");

            multipleLegged.Grap();

            multipleLegged.Guide();

            var spider = (SpiderRobot)multipleLegged;

            spider.Search();

            spider.Suppression();

            spider.Comeback();


        }
    }
}
