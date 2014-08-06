function FizzBuzz() {
	var self = this;

	self.getTheFizz = function(testValue) {
		if(testValue % 3 === 0 && testValue % 5 === 0)
			return "FizzBuzz";
		if(testValue % 3 === 0)
			return "Fizz";
		if(testValue % 5 === 0)
			return "Buzz";
	}
}