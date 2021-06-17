using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;
using NUnit.Framework;

namespace Assignment2.Tests
{
    public class RectangleTest
    {
        [Test]
        public void LengthGetterWithDefaultConstructor_InputNone_Output1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            int expected = 1;

            //Act
            int actual = rectangle.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LengthGetterWithGivenInput_Input3and5_Output3()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 5);

            int expected = 3;

            //Act
            int actual = rectangle.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LengthGetterWithGivenInputAndSettingWithDifferentValue_Input3Then5And8_Output5()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 8);
            rectangle.SetLength(5);

            int expected = 5;

            //Act
            int actual = rectangle.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WidthGetterWithDefaultConstructor_InputNone_Output1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            int expected = 1;

            //Act
            int actual = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WidthGetterWithGivenInput_Input3and5_Output5()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 5);

            int expected = 5;

            //Act
            int actual = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WidthGetterWithGivenInputAndSettingWithDifferentValue_Input3And5Then8_Output8()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 5);
            rectangle.SetWidth(8);

            int expected = 8;

            //Act
            int actual = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PerimeterGetterWithDefaultConstructor_InputNone_Output4()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            int expected = 4;

            //Act
            int actual = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PerimeterGetterWithGivenInput_Input3and5_Output16()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 5);

            int expected = 16;

            //Act
            int actual = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PerimeterGetterWithGivenInputAndSettingWithDifferentValue_Input3And5Then8_Output22()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 5);
            rectangle.SetWidth(8);

            int expected = 22;

            //Act
            int actual = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreaGetterWithDefaultConstructor_InputNone_Output1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            int expected = 1;

            //Act
            int actual = rectangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreaGetterWithGivenInput_Input3and5_Output15()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 5);

            int expected = 15;

            //Act
            int actual = rectangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreaGetterWithGivenInputAndSettingWithDifferentValue_Input3And5Then8_Output24()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 5);
            rectangle.SetWidth(8);

            int expected = 24;

            //Act
            int actual = rectangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}