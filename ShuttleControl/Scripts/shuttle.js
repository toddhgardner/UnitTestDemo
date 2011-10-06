shuttle = function () {

	var window = new windowWrapper();

	this.launch = function (id, element) {
		alert('launch');

		$("#dialog:ui-dialog").dialog("destroy");
		$(element).dialog({
			position: ['right', 'center'],
			height: 380,
			width: 600,
			modal: true,
			close: function () {
				window.setLocation('/Shuttle/Launch/' + id);
			}
		});
		//setTimeout(function () { $(element).dialog("close"); }, 15000);
	};

};



//shuttle.release = function (id) {
//	$("#dialog:ui-dialog").dialog("destroy");
//	$("#release-modal").dialog({
//		position: ['right', 'center'],
//		height: 380,
//		width: 600,
//		modal: true,
//		close: function () {
//			window.location = '/Shuttle/Release/' + id;
//		}
//	});
//	setTimeout(function () { $("#release-modal").dialog("close"); }, 15000);
//};

//shuttle.land = function (id) {
//	$("#dialog:ui-dialog").dialog("destroy");
//	$("#land-modal").dialog({
//		position: ['right', 'center'],
//		height: 380,
//		width: 600,
//		modal: true,
//		close: function () {
//			window.location = '/Shuttle/Land/' + id;
//		}
//	});
//	setTimeout(function () { $("#land-modal").dialog("close"); }, 15000);
//};

//shuttle.load = function () {
//	$("#dialog:ui-dialog").dialog("destroy");
//	$("#load-modal").dialog({
//		modal: true,
//		close: function () {
//			$('#loadpayload-form').submit();
//		}
//	});
//};

windowWrapper = function () {

	this.setLocation = function(location) {
		window.location = location;
	};
	
};