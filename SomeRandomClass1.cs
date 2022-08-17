using System.Threading;

namespace TestProject1.Subnamespace
{
    public class SomeRandomClass1
    {
        public int Num { get; set; }
        public void SomeFunction1()
        {
            SomeFunction2();
        }

        public void SomeFunction2()
        {
            Thread.Sleep(375);
            SomeFunction3();
        }
        public void SomeFunction3(string txt = ":)")
        {
            System.Console.WriteLine(txt);
        }
    }
}