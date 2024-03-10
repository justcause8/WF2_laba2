using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp2_laba2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormsApp2_laba2.Form1;

namespace WinFormsApp2_laba2.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestClass()]
        public class LogicTests
        {
            [TestMethod()]
            public void FirstTest()
            {
                string firstWord = "процессор";
                string secondWord = "информация";

                string expectedMessage = "нет да да да нет нет ";

                string actualMessage = Logic.Compare(firstWord, secondWord);

                Assert.AreEqual(expectedMessage, actualMessage);
            }

            [TestMethod()]
            public void SecondTest()
            {
                string firstWord = "-1";
                string secondWord = "информация";

                string expectedMessage = "Ошибка ввода\n";

                string actualMessage = Logic.Compare(firstWord, secondWord);

                Assert.AreEqual(expectedMessage, actualMessage);
            }

            [TestMethod()]
            public void ThirdTest()
            {
                string firstWord = "-1hello";
                string secondWord = "@bye";

                string expectedMessage = "Ошибка ввода\n";

                string actualMessage = Logic.Compare(firstWord, secondWord);

                Assert.AreEqual(expectedMessage, actualMessage);
            }

            [TestMethod()]
            public void FouthTest()
            {
                string firstWord = "пока";
                string secondWord = "пока";

                string expectedMessage = "да да да да ";

                string actualMessage = Logic.Compare(firstWord, secondWord);

                Assert.AreEqual(expectedMessage, actualMessage);
            }
        }
    }
}