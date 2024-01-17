using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console
{
    public class PetrolEngine : IEngine
    {
        public int EngineSize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Start()
        {
            Console.WriteLine("Petrol Engine Starting..");
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
