/*
 * Unit Tests for the Todo Model illustrate:
 *  -> Basic QUnit Testing
 *  -> Test Isolation
 */

(function() {

	module('Todo Model Tests');
	
	test('Test new model has default values', function() {
		//Align
		Todos = {};
		Todos.nextOrder = function() { return 1; };
		
		//Act
		var model = new Todo();
		
		//Assert
		strictEqual(model.get('done'), false, 'Model has default done');
		strictEqual(model.get('order'), 1, 'Model has default order');
	});

	test('Test toggle with undone todo sets done', function() {
		//Align
		Todos = new TodoList();
		var model = new Todo({});
		model.collection = Todos;
		model.set({'done':false});
		
		//Act
		model.toggle();
		
		//Assert
		strictEqual(model.get('done'), true, 'Todo was toggled');
	});

	test('Test toggle with done todo sets undone', function() {
		//Align
		Todos = new TodoList();
		var model = new Todo({});
		model.collection = Todos;
		model.set({'done':true});
		
		//Act
		model.toggle();
		
		//Assert
		strictEqual(model.get('done'), false, 'Todo was toggled');
	});	
})();