using System.Threading;

namespace TestProject1.Subnamespace
{
    public class SomeRandomClass2
    {
        public int Foo()
        {
            return Bar();
        }

        int Bar()
        {
            Thread.Sleep(175);
            return 1;
        }
    }
}