using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.Common;

namespace OOP.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "ObjectOriented";
            var expected = "Object Oriented";

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            //Arrange
            var source = "Object Oriented";
            var expected = "Object Oriented";

            var handler = new StringHandler();

            //Act
            var actual = handler.InsertSpaces(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
