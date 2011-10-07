/*
 * Unit Tests for the Shuttle illustrate:
 *  -> Basic Unit Test structure
 *  -> Negative Testing
 */

using System;
using NUnit.Framework;
using ShuttleControl.Exceptions;
using ShuttleControl.Models;

namespace ShuttleControl.UnitTests.Models
{


	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	// Working Code

	////[TestFixture]
	////public class ShuttleTests
	////{
	////    // POSITIVE TESTS

	////    [Test]
	////    public void Launch_WhenReady_UpdatesLaunchProperties()
	////    {
	////        // Align
	////        var shuttle = new Shuttle();
	////        shuttle.HasLaunched = false;
	////        shuttle.Payload = "Test Payload";

	////        // Act
	////        shuttle.Launch();

	////        // Assert
	////        Assert.True(shuttle.HasLaunched);
	////        Assert.IsNotNull(shuttle.LaunchedOn);
	////        Assert.IsNull(shuttle.LandedOn);
	////    }
		
	////    // NEGATIVE TESTS

	////    [Test]
	////    public void Launch_WithEmptyPayload_ThrowsShuttleException()
	////    {
	////        // Align
	////        var shuttle = new Shuttle();
	////        shuttle.HasLaunched = false;
	////        shuttle.Payload = string.Empty;

	////        // Act-Assert
	////        Assert.Throws(Is.TypeOf<ShuttleException>()
	////            .And.Message.EqualTo("Shuttle attempted to launch, but was not ready"),
	////            shuttle.Launch);
	////    }

	////    [Test]
	////    public void Launch_ThatHasAlreadyLaunched_ThrowsShuttleException()
	////    {
	////        // Align
	////        var shuttle = new Shuttle();
	////        shuttle.HasLaunched = true;
	////        shuttle.LaunchedOn = DateTime.Today;

	////        // Act-Assert
	////        Assert.Throws(Is.TypeOf<ShuttleException>()
	////            .And.Message.EqualTo("Shuttle attempted to launch, but was not ready"),
	////            shuttle.Launch);
	////    }
	////}
}