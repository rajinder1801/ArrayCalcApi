using ArrayCalcAPI.Controllers;
using ArrayCalcService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;

namespace ArrayCalcAPI.Tests
{
    [TestClass]
    public class ArrayCalcControllerTests
    {
        private ArrayCalcController controller;

        [TestInitialize]
        public void Setup()
        {
            var arrayOperations = new ArrayOperations();
            controller = new ArrayCalcController(arrayOperations);
        }

        [TestMethod]
        public void OnReverse_NullArray_IsInvalid()
        {
            //Arrange
            int[] testarraylist = null;
            var expectedResultContent = "Invalid request";

            //Act
            var result = controller.Reverse(testarraylist) as HttpResponseMessage;
            var actualResultContent = result.Content.ReadAsStringAsync()?.Result;

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(expectedResultContent, actualResultContent);
        }

        [TestMethod]
        public void OnReverse_OneItemArray_Isvalid()
        {
            //Arrange
            int[] testarraylist = new int[] { 1 };
            var expectedResultContent = "[1]";

            //Act
            var result = controller.Reverse(testarraylist) as HttpResponseMessage;
            var actualResultContent = result.Content.ReadAsStringAsync()?.Result;

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(expectedResultContent, actualResultContent);
        }

        [TestMethod]
        public void OnReverse_ArrayList_IsReversed()
        {
            //Arrange
            int[] testarraylist = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var expectedResultContent = "[10, 9, 8, 7, 6, 5, 4, 3, 2, 1]";

            //Act
            var result = controller.Reverse(testarraylist) as HttpResponseMessage;
            var actualResultContent = result.Content.ReadAsStringAsync()?.Result;

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(expectedResultContent, actualResultContent);
        }

        [TestMethod]
        public void OnReverse_unSortedArrayList_IsReversed()
        {
            //Arrange
            int[] testarraylist = new int[] { 15, 11, 19, 8, 6, 02 };
            var expectedResultContent = "[2, 6, 8, 19, 11, 15]";

            //Act
            var result = controller.Reverse(testarraylist) as HttpResponseMessage;
            var actualResultContent = result.Content.ReadAsStringAsync()?.Result;

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(expectedResultContent, actualResultContent);
        }

        [TestMethod]
        public void OnDeletePart_NullArray_IsInvalid()
        {
            //Arrange
            int[] testarraylist = null;
            var expectedResultContent = "Invalid request";

            //Act
            var result = controller.Reverse(testarraylist) as HttpResponseMessage;
            var actualResultContent = result.Content.ReadAsStringAsync()?.Result;

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(expectedResultContent, actualResultContent);
        }

        [TestMethod]
        public void OnDeletePart_OneItemArray_IsValid()
        {
            //Arrange
            int[] testarraylist = new int[] { 5 };
            var expectedResultContent = "[]";

            //Act
            var result = controller.DeletePart(1, testarraylist) as HttpResponseMessage;
            var actualResultContent = result.Content.ReadAsStringAsync()?.Result;

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(expectedResultContent, actualResultContent);
        }

        [TestMethod]
        public void OnDeletePartZero_Array_IsValid()
        {
            //Arrange
            int[] testarraylist = new int[] { 1, 2, 3 };
            var expectedResultContent = "[1, 2, 3]";

            //Act
            var result = controller.DeletePart(0, testarraylist) as HttpResponseMessage;
            var actualResultContent = result.Content.ReadAsStringAsync()?.Result;

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(expectedResultContent, actualResultContent);
        }

        [TestMethod]
        public void OnDeletePart_OutOfRange_IsValid()
        {
            //Arrange
            int[] testarraylist = new int[] { 10, 20, 30, 40, 50 };
            var expectedResultContent = "[10, 20, 30, 40, 50]";

            //Act
            var result = controller.DeletePart(6, testarraylist) as HttpResponseMessage;
            var actualResultContent = result.Content.ReadAsStringAsync()?.Result;

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(expectedResultContent, actualResultContent);
        }

        [TestMethod]
        public void OnDeletePart_Array_Works()
        {
            //Arrange
            int[] testarraylist = new int[] { 1, 2, 3, 4, 5 };
            var expectedResultContent = "[1, 2, 4, 5]";

            //Act
            var result = controller.DeletePart(3, testarraylist) as HttpResponseMessage;
            var actualResultContent = result.Content.ReadAsStringAsync()?.Result;

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(expectedResultContent, actualResultContent);
        }
    }   
}
