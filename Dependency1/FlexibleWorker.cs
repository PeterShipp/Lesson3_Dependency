using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency1
{
    class FlexibleWorker
    {
        private ITool _someTool;

        public FlexibleWorker(ITool toolToUse)
        {
            _someTool = toolToUse;
        }

        public void DoSomeWork()
        {
            _someTool.UseTool();
        }
    }
}
