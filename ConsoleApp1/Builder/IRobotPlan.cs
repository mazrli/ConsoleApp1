using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builder
{
    internal interface IRobotPlan
    {
        void setRobotHead(string Head);
        void setRobotArmes(string Armes);
        void setRobotLegs(string Legs);

        void setRobotBody(string Body);
    }
}
