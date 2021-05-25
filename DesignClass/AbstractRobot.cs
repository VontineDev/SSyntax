using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignClass
{
    public enum SizeOfRobot { Large, Medium, Small }
    public enum ColorOfRobot { Black, Red, Blue }

    abstract class AbstractRobot
    {
        public SizeOfRobot size;
        public ColorOfRobot color;
        abstract public void Grap();    //Grap somthing
        abstract public void Guide();   //Guide
        abstract public void Assist();  //Assist

    }
}
