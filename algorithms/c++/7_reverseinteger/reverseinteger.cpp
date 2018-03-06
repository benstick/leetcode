// Creator Ben Stickney
// Date 3/5/2018

/*
Given a 32-bit signed integer, reverse digits of an integer.

Example:
Input: 123
Output: 321
*/

int reverse(int x) {
	int reverseResult = 0;
    	bool isNegative = false;
	
	if (x < 0) {
		x = 0 - x;
		isNegative = true;
	}
	
	x = abs(x);
	
	while (x != 0) {
		int result = reverseResult * 10 + x % 10;
		
		if ((result - x % 10) / 10 != reverseResult)
			return 0;
		else
			reverseResult = result;
		
		x /= 10;
	}
	
	if (isNegative)
		reverseResult *= -1;
	
	return reverseResult;
}
