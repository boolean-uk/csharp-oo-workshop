using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console
{
    public class Mini
    {
        private IEngine _engine;

        public Mini(IEngine engine)
        {
            _engine = engine;
        }
        public void Start()
        {
            _engine.Start();
        }
       
    }
}
