QUnit.test("Given a number divisible by 3 should return fizz", function(assert) {
	var fizzBuzz = new FizzBuzz();
	var result = fizzBuzz.getTheFizz(3);

	assert.ok(result == "Fizz", "Can Fizz!");
});

QUnit.test("Given a number divisible by 5 should return buzz", function(assert) {
	var fizzBuzz = new FizzBuzz();
	var result = fizzBuzz.getTheFizz(5);

	assert.ok(result == "Buzz", "Can Buzz!");
});

QUnit.test("Given a number divisible by 3 and 5 should return FizzBuzz", function(assert) {
	var fizzBuzz = new FizzBuzz();
	var result = fizzBuzz.getTheFizz(15);

	assert.ok(result == "FizzBuzz", "Can FizzBuzz!");
});