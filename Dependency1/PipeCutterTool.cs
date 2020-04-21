using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency1
{
    class PipeCutterTool : ITool
    {
        public void UseTool()
        {
            Console.WriteLine("The PipeCutter tool cuts the pipe!");
        }
    }
}
