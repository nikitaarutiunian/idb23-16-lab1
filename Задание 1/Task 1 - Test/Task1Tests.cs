using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace Task1.Tests
{
    [TestClass()]
    public class Task1Tests
    {
        [TestMethod()]
        public void ToString1()
        {
            Task1 a = new Task1(3, 5);
            string b = a.ToString();
            Assert.AreEqual(b, "3/5");
        }

        [TestMethod()]
        public void ToString2()
        {
            Task1 a = new Task1(16, 20);
            string b = a.ToString();
            Assert.AreEqual(b, "4/5");
        }

        [TestMethod()]
        public void ToString3()
        {
            Task1 a = new Task1(7, 0);
            string b = a.ToString();
            Assert.AreEqual(b, "Делитель не может равняться нулю.");
        }

        [TestMethod()]
        public void ToString4()
        {
            Task1 a = new Task1(10, 10);
            string b = a.ToString();
            Assert.AreEqual(b, "1");
        }

        [TestMethod()]
        public void ToString5()
        {
            Task1 a = new Task1(0, 9);
            string b = a.ToString();
            Assert.AreEqual(b, "0");
        }

        [TestMethod()]
        public void ToString6()
        {
            Task1 a = new Task1(-16, 20);
            string b = a.ToString();
            Assert.AreEqual(b, "-4/5");
        }

        [TestMethod()]
        public void ToString7()
        {
            Task1 a = new Task1(16, -20);
            string b = a.ToString();
            Assert.AreEqual(b, "-4/5");
        }

        [TestMethod()]
        public void Addition1()
        {
            Task1 a = new Task1(1, 3);
            Task1 b = new Task1(1, 6);
            a = a + b;
            Assert.AreEqual(a.ToString(), "1/2");
        }

        [TestMethod()]
        public void Addition2()
        {
            Task1 a = new Task1(-1, 4);
            Task1 b = new Task1(3, 5);
            a = a + b;
            Assert.AreEqual(a.ToString(), "7/20");
        }

        [TestMethod()]
        public void Addition3()
        {
            Task1 a = new Task1(4, 3);
            Task1 b = new Task1(1, 2);
            a = a + b;
            Assert.AreEqual(a.ToString(), "11/6");
        }

        [TestMethod()]
        public void Addition4()
        {
            Task1 a = new Task1(5, 2);
            Task1 b = new Task1(-3, 4);
            a = a + b;
            Assert.AreEqual(a.ToString(), "7/4");
        }

        [TestMethod()]
        public void Subtraction1()
        {
            Task1 a = new Task1(1, 3);
            Task1 b = new Task1(1, 6);
            a = a - b;
            Assert.AreEqual(a.ToString(), "1/6");
        }

        [TestMethod()]
        public void Subtraction2()
        {
            Task1 a = new Task1(4, 3);
            Task1 b = new Task1(1, 2);
            a = a - b;
            Assert.AreEqual(a.ToString(), "5/6");
        }

        [TestMethod()]
        public void Subtraction3()
        {
            Task1 a = new Task1(-1, 4);
            Task1 b = new Task1(3, 5);
            a = a - b;
            Assert.AreEqual(a.ToString(), "-17/20");
        }

        [TestMethod()]
        public void Subtraction4()
        {
            Task1 a = new Task1(5, 2);
            Task1 b = new Task1(-3, 4);
            a = a - b;
            Assert.AreEqual(a.ToString(), "13/4");
        }

        [TestMethod()]
        public void Multiplication1()
        {
            Task1 a = new Task1(1, 3);
            Task1 b = new Task1(1, 6);
            a = a * b;
            Assert.AreEqual(a.ToString(), "1/18");
        }

        [TestMethod()]
        public void Multiplication2()
        {
            Task1 a = new Task1(5, 2);
            Task1 b = new Task1(-3, 4);
            a = a * b;
            Assert.AreEqual(a.ToString(), "-15/8");
        }

        [TestMethod()]
        public void Multiplication3()
        {
            Task1 a = new Task1(4, 3);
            Task1 b = new Task1(1, 2);
            a = a * b;
            Assert.AreEqual(a.ToString(), "2/3");
        }

        [TestMethod()]
        public void Multiplication4()
        {
            Task1 a = new Task1(-1, 4);
            Task1 b = new Task1(3, 5);
            a = a * b;
            Assert.AreEqual(a.ToString(), "-3/20");
        }

        [TestMethod()]
        public void Division1()
        {
            Task1 a = new Task1(1, 3);
            Task1 b = new Task1(1, 6);
            a = a / b;
            Assert.AreEqual(a.ToString(), "2");
        }

        [TestMethod()]
        public void Division2()
        {
            Task1 a = new Task1(5, 2);
            Task1 b = new Task1(-3, 4);
            a = a / b;
            Assert.AreEqual(a.ToString(), "-10/3");
        }

        [TestMethod()]
        public void Division3()
        {
            Task1 a = new Task1(4, 3);
            Task1 b = new Task1(1, 2);
            a = a / b;
            Assert.AreEqual(a.ToString(), "8/3");
        }

        [TestMethod()]
        public void Division4()
        {
            Task1 a = new Task1(-1, 4);
            Task1 b = new Task1(3, 5);
            a = a / b;
            Assert.AreEqual(a.ToString(), "-5/12");
        }

        [TestMethod()]
        public void GreaterThan1()
        {
            Task1 a = new Task1(4, 3);
            Task1 b = new Task1(1, 2);
            Assert.IsTrue(a > b);
        }

        [TestMethod()]
        public void GreaterThan2()
        {
            Task1 a = new Task1(5, 2);
            Task1 b = new Task1(3, 4);
            Assert.IsTrue(a > b);
        }

        [TestMethod()]
        public void LessThan1()
        {
            Task1 a = new Task1(1, 3);
            Task1 b = new Task1(1, 2);
            Assert.IsTrue(a < b);
        }

        [TestMethod()]
        public void LessThan2()
        {
            Task1 a = new Task1(-1, 4);
            Task1 b = new Task1(3, 5);
            Assert.IsTrue(a < b);
        }

        [TestMethod()]
        public void GreaterOrEqual1()
        {
            Task1 a = new Task1(9, 12);
            Task1 b = new Task1(3, 4);
            Assert.IsTrue(a >= b);
        }

        [TestMethod()]
        public void GreaterOrEqual2()
        {
            Task1 a = new Task1(4, 3);
            Task1 b = new Task1(1, 2);
            Assert.IsTrue(a >= b);
        }

        [TestMethod()]
        public void LessOrEqual1()
        {
            Task1 a = new Task1(1, 4);
            Task1 b = new Task1(3, 5);
            Assert.IsTrue(a <= b);
        }

        [TestMethod()]
        public void LessOrEqual2()
        {
            Task1 a = new Task1(-7, 4);
            Task1 b = new Task1(3, 2);
            Assert.IsTrue(a <= b);
        }

        [TestMethod()]
        public void Equality1()
        {
            Task1 a = new Task1(9, 12);
            Task1 b = new Task1(3, 4);
            Assert.IsTrue(a == b);
        }

        [TestMethod()]
        public void Equality2()
        {
            Task1 a = new Task1(5, 2);
            Task1 b = new Task1(10, 4);
            Assert.IsTrue(a == b);
        }

        [TestMethod()]
        public void Inequality1()
        {
            Task1 a = new Task1(5, 2);
            Task1 b = new Task1(11, 5);
            Assert.IsTrue(a != b);
        }

        [TestMethod()]
        public void Inequality2()
        {
            Task1 a = new Task1(-1, 4);
            Task1 b = new Task1(3, 5);
            Assert.IsTrue(a != b);
        }
    }
}