using StringCalculatorKata;

namespace TestNUnit
{
    public class StringCalkulatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}

        [TestCase("2,2",4)]
        public void TestAdd1(string s , int v)
        {
           

            Assert.That(() => StringCalkulator.Add(s), Is.EqualTo(v));
        }
        [TestCase("2", 2)]
        public void TestAdd2(string s, int v)
        {

            Assert.That(() => StringCalkulator.Add(s), Is.EqualTo(v));
        }

        [TestCase("", 0)]
        public void TestAdd3(string s, int v)
        {

            Assert.That(() => StringCalkulator.Add(s), Is.EqualTo(v));
        }

        [TestCase("2,2,4,4,5,8", 25)]
        public void TestAdd4(string s, int v)
        {
            Assert.That(() => StringCalkulator.Add(s), Is.EqualTo(v));
        }
        [TestCase("1\n2,3", 6)]
        public void TestAdd5(string s, int v)
        {
            Assert.That(() => StringCalkulator.Add(s), Is.EqualTo(v));
        }
        [TestCase("//[test]\n1test2", 3)]
        public void TestAdd6(string s, int v)
        {
            Assert.That(() => StringCalkulator.Add(s), Is.EqualTo(v));
        }

        [TestCase("2,-2,4,-4,5,8", 25)]
        public void TestAdd7(string s, int v)
        {

            Assert.That(() => StringCalkulator.Add(s), Throws.TypeOf<ArgumentException>()
                .With
                .Message
                .EqualTo("negatives not allowed :-2,-4"));
        }
        [TestCase("1000", 0)]
        public void TestAdd8(string s, int v)
        {
            Assert.That(() => StringCalkulator.Add(s), Is.EqualTo(v));
        }

        [TestCase("2,1000,345,3452,612", 959)]
        public void TestAdd9(string s, int v)
        {
            Assert.That(() => StringCalkulator.Add(s), Is.EqualTo(v));
        }

        [TestCase("//[***]\n1***2***3", 6)]
        public void TestAdd10(string s, int v)
        {
            Assert.That(() => StringCalkulator.Add(s), Is.EqualTo(v));
        }

        [TestCase("//[***]\n1***2***3", 6)]
        public void TestAdd11(string s, int v)
        {
            Assert.That(() => StringCalkulator.Add(s), Is.EqualTo(v));
        }
    }
}