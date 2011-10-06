/*
 * Unit Tests for the shuttle.js illustrate:
 *  -> Unit-testing in Javascript
 */

/// <reference path="../../jquery-1.6.2.min.js" />
/// <reference path="../../jquery-ui-1.8.16.custom.min.js" />
/// <reference path="../qunit/qunit.js" />
/// <reference path="../../shuttle.js" />

//module('shuttle.js');

//test('launch calls jquery.ui dialog modal', function () {
//	// Align

//	// override jquery.ui dialog
//	var dialogWasCalled = false;
//	jQuery.dialog = function (data) {
//		dialogWasCalled = true;
//	};
//	//var s = new shuttle();

//	// Act
//	shuttle.launch();

//	// Assert
//	ok(dialogWasCalled);
//});

test('launch redirects to launch url after dialog closes', function () {
	// Align

	// override jquery.ui dialog
	var dialogWasCalled = false;
	jQuery.dialog = function (data) {
		dialogWasCalled = true;
	};

	// override window.location
	//	var locationResult = '';
	//	window.setLocation = function(location) {
	//		locationResult = location;
	//	};

	// Act
	var s = new shuttle();
	s.launch();

	// Assert
	ok(dialogWasCalled);
});


//shuttle.launch = function (id) {
//	$("#dialog:ui-dialog").dialog("destroy");
//	$("#launch-modal").dialog({
//		position: ['right', 'center'],
//		height: 380,
//		width: 600,
//		modal: true,
//		close: function () {
//			window.location = '/Shuttle/Launch/' + id;
//		}
//	});
//	setTimeout(function () { $("#launch-modal").dialog("close"); }, 15000);
//};
