using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplicationMil.Entities;

namespace WebApplicationMil.Tests
{
    [TestClass]
    public class TestUserController
    {
        //todo: create SUT env
        public async void PrepareSUT()
        {
            //in-db-mem setup and user creations
        }


        [TestMethod]
        public async Task GetUser()
        {
            var user = new User({Id = "123", 
                Title = "Mr", 
                FirstName = "Jan", 
                LastName = "Kowalski" });
            var controller = new UsersController();
            //  insert user into in-mem db/ moq user repo
            var result = await controller.GetAll();
            var user = (result.Result as User);
            Assert.AreEqual((int)HttpStatus)
            Assert.AreEqual(user, );
        }



    }
}