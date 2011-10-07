/*
 * Unit Tests for the ShuttleRepository illustrate:
 *  -> Wrapping of static classes
 */

using Moq;
using NUnit.Framework;
using ShuttleControl.Models;
using ShuttleControl.Repositories;
using ShuttleControl.Repositories.Impl;

namespace ShuttleControl.UnitTests.Repositories
{






















	// Working Code

	////[TestFixture]
	////public class ShuttleRepositoryTests
	////{
	////    [Test]
	////    public void GetAll_GetsModelsFromDatabase()
	////    {
	////        // Align
	////        var mockMemoryDb = new Mock<MemoryDbWrapper>();
	////        mockMemoryDb.Setup(memoryDb => memoryDb.SelectAll())
	////            .Returns(new Shuttle[0])
	////            .Verifiable();

	////        var repository = new ShuttleRepository(mockMemoryDb.Object);

	////        // Act
	////        var result = repository.GetAll();

	////        // Assert
	////        Assert.AreEqual(new Shuttle[0], result);
	////        mockMemoryDb.VerifyAll();
	////    }
	////}
}