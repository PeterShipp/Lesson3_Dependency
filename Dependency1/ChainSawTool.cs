using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency1
{
    class ChainSawTool : ITool
    {
        public void UseTool()
        {
            Console.WriteLine("The chainsaw tool is put to work!");
        }
    }
}
