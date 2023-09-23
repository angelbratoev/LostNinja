using LostNinja.Core;
using LostNinja.Core.Interfaces;

namespace LostNinja
{
    public class StartUp
    {
        public static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}