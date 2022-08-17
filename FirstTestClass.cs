using NUnit.Framework;
using TestProject1.Subnamespace;

namespace TestProject1
{
    [Parallelizable(scope: ParallelScope.All)]
    public class FirstTestClass
    {
        [Test]
        public void Test1()
        {
            SomeRandomClass1 obj = new SomeRandomClass1();
            obj.SomeFunction1();
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
        
        [Test]
        public void Test6()
        {
            SomeRandomClass2 obj = new SomeRandomClass2();
            Assert.AreEqual(1, obj.Foo());
        }
    }
}