using System;

namespace Dependency1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker myWorker = new Worker();
            myWorker.UseShovel();

            FlexibleWorker officeWorker = new FlexibleWorker(new SpreadSheetComputerTool());
            officeWorker.DoSomeWork();

            FlexibleWorker plumber = new FlexibleWorker(new PipeCutterTool());
            plumber.DoSomeWork();

            FlexibleWorker leatherFace = new FlexibleWorker(new ChainSawTool());
            leatherFace.DoSomeWork();
           
        }
    }
}
