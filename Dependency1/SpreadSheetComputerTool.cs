using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency1
{
    class SpreadSheetComputerTool : ITool
    {
        public void UseTool()
        {
            Console.WriteLine("The Spreadsheet is very useful to the company!");
        }
    }
}
