/*
 * Unit Tests for the ShuttleController illustrate:
 *  -> Dependency Injection
 *  -> Multiple Scenarios
 *  -> Mocking
 */

using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using ShuttleControl.Controllers;
using ShuttleControl.Models;
using ShuttleControl.Repositories;

namespace ShuttleControl.UnitTests.Controllers
{

























	// Working Code

	////[TestFixture]
	////public class ShuttleControllerTests
	////{
	////    [Test]
	////    [TestCase(0)]
	////    [TestCase(1)]
	////    [TestCase(3)]
	////    public void Index_WithShuttles_ReturnsViewWithExpectedArray(int shuttleCount)
	////    {
	////        // Align
	////        var shuttles = new List<Shuttle>();
	////        for(var i = 0; i < shuttleCount; i++)
	////        {
	////            shuttles.Add(new Shuttle
	////            {
	////                Name = "Test Shuttle",
	////                SerialNumber = "123",
	////            });
	////        }

	////        var mockRepository = new Mock<IShuttleRepository>();
	////        mockRepository.Setup(repository => repository.GetAll())
	////            .Returns(shuttles.ToArray())
	////            .Verifiable();

	////        var controller = new ShuttleController(mockRepository.Object);

	////        // Act
	////        var result = controller.Index().Model as Shuttle[];

	////        // Assert			
	////        Assert.AreEqual(shuttleCount, result.Length);
	////        mockRepository.VerifyAll();
	////    }

	////    [Test]
	////    public void Index_WithTempData_CopiesMessageToViewBag()
	////    {
	////        // Align
	////        var mockRepository = new Mock<IShuttleRepository>();
	////        mockRepository.Setup(repository => repository.GetAll())
	////            .Returns(new Shuttle[0])
	////            .Verifiable();

	////        var controller = new ShuttleController(mockRepository.Object);

	////        var expectedMessage = "Some Test Message";
	////        controller.TempData["Message"] = expectedMessage;

	////        // Act
	////        var result = controller.Index();

	////        // Assert
	////        Assert.AreEqual(expectedMessage, result.ViewBag.Message);
	////        mockRepository.VerifyAll();
	////    }
	////}
}