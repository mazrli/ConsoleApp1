using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builder
{
    internal interface IRobotBuilder 
    {
        void buildRobotHead();
        void buildRobotArmes();
        void buildRobotLegs();

        void buildtRobotBody();

        Robot getRobot();
      
    }
}
