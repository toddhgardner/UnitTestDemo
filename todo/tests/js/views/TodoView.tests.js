/*
 * Unit Tests for the Todo View illustrate:
 *  -> Testing the DOM
 *  -> Javascript Mocking
 */

(function () {

	module('Todo View Tests');

	test('Test View with model renders values to DOM', function () {
		//Align
		var $element = $('ul', this.$domScope);
		var model = createTodo();
		var view = new TodoView({ model: model });

		//Act
		$element.append(view.render().el);

		//Assert
		ok($('li.todo', $element).length == 1, 'todo exists in dom');
		strictEqual($('input.todo-input', $element).val(), model.get('text'), 'todo has correct value');
		strictEqual($('input.check', $element).is(':checked'), model.get('done'), 'todo has correct done-ness');
	});

	test('Test destroy event removes from DOM', function () {
		//Align
		var $element = $('ul', this.$domScope);
		var model = createTodo();
		var view = new TodoView({ model: model });
		$element.append(view.render().el);

		//Act
		$('span.todo-destroy', $element).click()

		//Assert
		ok($('li.todo', $element).length == 0, 'todo doesnt exists in dom');
	});

	test('Test destroy event destroys model', function () {
		//Align
		var $element = $('ul', this.$domScope);
		var model = createTodo();
		var view = new TodoView({ model: model });
		$element.append(view.render().el);

		// Mock out the method
		var wasCalled = false;
		view.model.destroy = function () {
			wasCalled = true;
		}

		//Act
		$('span.todo-destroy', $element).click()

		//Assert
		ok(wasCalled, 'Destroy was called');
	});

	//
	// TEST HELPERS
	//

	this.$domScope = $('div#TodoView');

	var createTodo = function() {
		return new Todo({
				'done': false,
				'text': 'Something to do'
			});
	};

})();