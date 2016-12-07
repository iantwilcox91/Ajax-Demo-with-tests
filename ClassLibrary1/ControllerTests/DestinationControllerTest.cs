using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AjaxDemo.Controllers;
using AjaxDemo.Models;
using Xunit;

namespace AjaxDemo.Tests
{
    public class DestinationControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //arrange
            HomeController controller = new HomeController();
            //act
            //var indexResult = controller.Index();
            var newDestinationResult = controller.NewDestination("Seattle", "String2");
            //assert
            //Assert.IsType<ViewResult>(indexResult);
            Assert.IsType<JsonResult>(newDestinationResult);
        }
        [Fact]
        public void GetModelListTest()
        {
            //Arrange
            HomeController controller = new HomeController();
            IActionResult actionResult = controller.NewDestination("Seattle", "String2");
            ViewResult newDestinationView = controller.NewDestination("new","old") as ViewResult;

            //Act
            var result = newDestinationView.ViewData.Model;

            //Assert
            Assert.IsType<List<Destination>>(result);


        }
    }
}
