using System;
using ConsoleApp1.Builder;
using ConsoleApp1.factory;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Det här för Builder för patter desgin
            IRobotBuilder robotBuilderOld = new RobotBuilderOld();
            RobotBuilder robotBuilder = new RobotBuilder(robotBuilderOld);
            robotBuilder.makeRobot();
            Robot robot = robotBuilder.getRobot();

            Console.WriteLine("Robort Body " + robot.getRobotBody());
            Console.WriteLine("Robort Head " + robot.getRobotHead());
            Console.WriteLine("Robort Armes " + robot.getRobotArmes());
            Console.WriteLine("Robort Legs " + robot.getRobotLegs());

            Console.ReadKey();

            //singleton singleton = singleton.getInstance();





        }
    }
}
