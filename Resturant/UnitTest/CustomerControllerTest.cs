using Microsoft.AspNetCore.Mvc;
using Resturant.classes;
using Resturant.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class CustomerControllerTest
    {
        [Fact]
        public void GetAll_ReturnsListOfCustomers()
        {
            //Arrange

            //Act
            var controller = new CustomerController();
            var res = controller.Get();
            //Assert
            Assert.IsType<ActionResult<IEnumerable<Customer>>>(res);
        }

        [Fact]
        public void GetById_ReturnsOk()
        {
            //Arrange
            var id = 1;
            //Act
            var controller = new CustomerController();
            var res = controller.Get(id);
            //Assert
            Assert.IsType<OkObjectResult>(res);
        }
        [Fact]
        public void GetById_ReturnsNotFound()
        {
            //Arrange
            var id = 9;
            //Act
            var controller = new CustomerController();
            var res = controller.Get(id);
            //Assert
            Assert.IsType<NotFoundResult>(res);
        }

        [Fact]
        public void Post_ReturnsFalse()
        {
            //Arrange
            Customer customer = new Customer("123", "lll", "vvvv", "@", "ddd", true, true, true, new DateTime());
            //Act
            var controller = new CustomerController();
            bool res = controller.Post(customer).Value;
            //Assert
            Assert.False(res);
        }

        [Fact]
        public void Post_ReturnsTrue()
        {
            //Arrange
            Customer customer = new Customer("327863254", "lll", "vvvv", "@", "ddd", true, true, true, new DateTime());
            //Act
            var controller = new CustomerController();
            bool res = controller.Post(customer).Value;
            //Assert
            Assert.True(res);
        }

        [Fact]
        public void Put_ReturnsNotFound()
        {
            //Arrange
            Customer customer = new Customer("327863254", "lll", "vvvv", "@", "ddd", true, true, true, new DateTime());
            var id = 1;
            //Act
            var controller = new CustomerController();
            var res = controller.Put(id,customer);
            //Assert
            Assert.IsType<NotFoundResult>(res);
        }

        [Fact]
        public void Put_ReturnsOk()
        {
            //Arrange
            Customer customer = new Customer("327863254", "lll", "vvvv", "@", "ddd", true, true, true, new DateTime());
            var id = 1;
            //Act
            var controller = new CustomerController();
            var res = controller.Put(id, customer);
            //Assert
            Assert.IsType<OkResult>(res);
        }

        [Fact]
        public void Delete_ReturnsNotFound()
        {
            //Arrange
            var id = 1;
            //Act
            var controller = new CustomerController();
            var res = controller.Delete(id);
            //Assert
            Assert.IsType<NotFoundResult>(res);
        }
        [Fact]
        public void Delete_ReturnsOk()
        {
            //Arrange
            var id = 1;
            //Act
            var controller = new CustomerController();
            var res = controller.Delete(id);
            //Assert
            Assert.IsType<OkResult>(res);
        }


    }
}
