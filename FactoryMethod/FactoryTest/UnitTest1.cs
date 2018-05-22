using System;
using Xunit;
using FactoryMethod;
using static FactoryMethod.Program;

namespace FactoryTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            Resume resume = new Resume();
            resume.BuildResume();
        }
    }
}
