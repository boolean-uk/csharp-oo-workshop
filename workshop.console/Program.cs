namespace workshop.console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //WaterEngine engine = new WaterEngine();
            //ElectricEngine engine = new ElectricEngine();
            //PetrolEngine engine = new PetrolEngine();
            DieselEngine engine = new DieselEngine();
            Mini myMini = new Mini(engine);
            myMini.Start();
        }
    }
}
