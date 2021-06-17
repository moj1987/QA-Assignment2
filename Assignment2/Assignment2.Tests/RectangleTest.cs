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
        // Length getter tests
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

        //Width getter tests
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

        //Perimeter getter tests
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

        // Area getter tests
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

        // Length setter tesets
        [Test]
        public void LengthSetterWithGivenInputAndSettingWithDifferentValue_Input3Then4And8_Output4()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 8);
            rectangle.SetLength(4);

            int expected = 4;

            //Act
            int actual = rectangle.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LengthSetterWithDefaultConstructorThenGivenInput_InputNoneThen7_Output7()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            rectangle.SetLength(7);

            int expected = 7;

            //Act
            int actual = rectangle.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LengthSetterWithDefaultConstructorThenGivenInputThen1_InputNoneThen7then1_Output1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            rectangle.SetLength(7);
            rectangle.SetLength(1);

            int expected = 1;

            //Act
            int actual = rectangle.GetLength();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // Width setter tests
        [Test]
        public void WidthSetterWithGivenInputAndSettingWithDifferentValue_Input3And5Then6_Output6()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(3, 5);
            rectangle.SetWidth(6);

            int expected = 6;

            //Act
            int actual = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WidthSetterWithDefaultConstructorThenGivenInput_InputNoneThen9_Output9()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(9);

            int expected = 9;

            //Act
            int actual = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WidthSetterWithDefaultConstructorThenGivenInputThen1_InputNoneThen2then1_Output1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(2);
            rectangle.SetWidth(1);

            int expected = 1;

            //Act
            int actual = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}