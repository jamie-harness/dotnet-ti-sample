using NUnit.Framework;
using TestProject1.Subnamespace;

namespace TestProject1
{
    [Parallelizable(scope: ParallelScope.All)]
    public class SecondTestClass
    {
        [Test]
        public void Test1()
        {
            SomeRandomClass1 obj = new SomeRandomClass1();
            Assert.AreEqual(0, obj.Num);
        }
        
        [Test]
        public void Test2()
        {
            SomeRandomClass1 obj = new SomeRandomClass1();
            obj.SomeFunction2();
            Assert.AreEqual(0, obj.Num);
        }
        
        [Test]
        public void Test3()
        {
            SomeRandomClass1 obj = new SomeRandomClass1();
            obj.SomeFunction2();
            Assert.AreEqual(0, obj.Num);
        }
        
        [Test]
        public void Test4()
        {
            SomeRandomClass1 obj = new SomeRandomClass1();
            obj.SomeFunction2();
            Assert.AreEqual(0, obj.Num);
        }
        
        [Test]
        public void Test5()
        {
            SomeRandomClass1 obj = new SomeRandomClass1();
            obj.SomeFunction2();
            Assert.AreEqual(0, obj.Num);
        }
    }
}