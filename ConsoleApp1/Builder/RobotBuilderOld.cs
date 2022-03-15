using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builder
{
    internal class RobotBuilderOld : IRobotBuilder
    {
        public RobotBuilderOld()
        {
            robot = new Robot();
        }
        private Robot robot;

        public void buildtRobotBody()
        {
            robot.setRobotBody("The Body");
        }

        public void buildRobotHead()
        {
            robot.setRobotHead("The Head ");
        }

        public void buildRobotArmes()
        {
            robot.setRobotArmes("The Arms");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("The Legs");
        }
        public Robot getRobot()
        {
            return robot;
        }

    }
}
