using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace WSUniversalLibTest
{
    [TestClass]
    public class UnitTest
    {
        private int non_existing_type = -1;
        private int calculation_error = -1;

        private int product_type = 3;
        private int material_type = 1;

        private int count = 15;

        private int width = 20;
        private int lenght = 45;

        private int calculation_result = 114147;

        private int NULL = 0;


        [TestMethod]
        public void GetQuantityForProduct_CorrectData() //Расчет количества сырья с корректными данными
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, material_type, count, width, lenght);
            //Assert
            Assert.AreEqual(calculation_result, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(non_existing_type, material_type, count, width, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType()
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, non_existing_type, count, width, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_WrongCount()
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, material_type, non_existing_type, width, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentWidth()
        {
            //Arrande
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, material_type, count, non_existing_type, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentLenght()
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, material_type, count, width, non_existing_type);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NullProductType()
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(NULL, material_type, count, width, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NullMaterialType()
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, NULL, count, width, lenght);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NullCount()
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, material_type, NULL, width, lenght);
            //Assert
            Assert.AreEqual(NULL, calc);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeSquare()
        {
            //Arrange
            Calculation calculation = new Calculation();
            //Act
            int calc = calculation.GetQuantityForProduct(product_type, material_type, count, width, non_existing_type);
            //Assert
            Assert.AreEqual(calculation_error, calc);
        }
    }
}
