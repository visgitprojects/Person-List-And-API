using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonAPI;
using PersonAPI.Controllers;
using PersonAPI.Models;

namespace PersonAPI.Tests.Controllers
{
    [TestClass]
    public class PersonControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            PersonController controller = new PersonController();

            // Act
           IQueryable result = controller.GetPeople();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            PersonController controller = new PersonController();

            // Act
            var result = controller.GetPerson(5);
            
            // Assert
            Assert.IsNotNull(result);
           
        }

        [TestMethod]
        public void PostFail()
        {
            // Arrange
            PersonController controller = new PersonController();
            Person person = new Person() { LastName = "Davolio", FirstName = "Nancy", Age = 39, Address = "507 - 20th Ave. E.Apt. 2A", City = "Seattle", PostalCode = "98122", Interests = "coffee", PhotoPath = "https://images.pexels.com/photos/60883/girl-eyes-makeup-sexy-60883.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" };
            // Act

           var result = controller.PostPerson(person);

            // Assert
            Assert.IsInstanceOfType(result, typeof(BadRequestResult));

        }
        [TestMethod]
        public void PostSuccess()
        {
            // Arrange
            PersonController controller = new PersonController();
            Person person = new Person() { LastName = "Davolio", FirstName = "Nancy", Age = 39, Address = "507 - 20th Ave. E.Apt. 2A", City = "Seattle", PostalCode = "98122", Interests = "coffee", PhotoPath = "https://images.pexels.com/photos/60883/girl-eyes-makeup-sexy-60883.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" };
            // Act

           var result = controller.PostPerson(person);

            // Assert
            Assert.IsInstanceOfType(result, typeof(CreatedAtRouteNegotiatedContentResult<>));

        }

        [TestMethod]
        public void PutNotFound()
        {
            // Arrange
            PersonController controller = new PersonController();
            Person person = new Person() { LastName = "Davolio", FirstName = "Nancy", Age = 39, Address = "507 - 20th Ave. E.Apt. 2A", City = "Seattle", PostalCode = "98122", Interests = "coffee", PhotoPath = "https://images.pexels.com/photos/60883/girl-eyes-makeup-sexy-60883.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" };
            // Act
            var result = controller.PutPerson(5, person);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
        [TestMethod]
        public void PutBadRequest()
        {
            // Arrange
            PersonController controller = new PersonController();
            Person person = new Person() { LastName = "Davolio", FirstName = "Nancy", Age = 39, Address = "507 - 20th Ave. E.Apt. 2A", City = "Seattle", PostalCode = "98122", Interests = "coffee", PhotoPath = "https://images.pexels.com/photos/60883/girl-eyes-makeup-sexy-60883.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" };
            // Act
            var result = controller.PutPerson(5, person);

            // Assert
            Assert.IsInstanceOfType(result, typeof(BadRequestResult));
        }
        [TestMethod]
        public void PutSaveChanges()
        {
            // Arrange
            PersonController controller = new PersonController();
            Person person = new Person() { LastName = "Davolio", FirstName = "Nancy", Age = 39, Address = "507 - 20th Ave. E.Apt. 2A", City = "Seattle", PostalCode = "98122", Interests = "coffee", PhotoPath = "https://images.pexels.com/photos/60883/girl-eyes-makeup-sexy-60883.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260" };
            // Act
            var result = controller.PutPerson(5, person);

            // Assert
            Assert.IsInstanceOfType(result, typeof(HttpStatusCodeResult));
        }

        [TestMethod]
        public void DeleteNotFound()
        {
            // Arrange
            PersonController controller = new PersonController();

            // Act
            var result = controller.DeletePerson(100);

            // Assert
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
        [TestMethod]
        public void DeleteOk()
        {
            // Arrange
            PersonController controller = new PersonController();

            // Act
            var result = controller.DeletePerson(100);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkResult));
        }
    }
}
