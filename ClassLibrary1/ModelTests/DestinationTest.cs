using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using AjaxDemo.Models;
using AjaxDemo.Controllers;

namespace AjaxDemo.Tests
{
    public class DestinationTest
    {
        [Fact]
        public void GetCityCountryTest()
        {
            //Arrange
            var destination = new Destination();
            destination.City = "Seattle";
            destination.Country = "America";
            //Act
            var resultCity = destination.City;
            var resultCountry = destination.Country;
            //Assert
            Assert.Equal("Seattle", resultCity);
            Assert.Equal("America", resultCountry);
        }
    }
}
