// Creator Ben Stickney
// Date 3/8/2018

/*
Determine whether an integer is a palindrome. Do this without extra space.
*/

bool IsPalindrome(int x) {
	if (x < 0 || (x % 10 == 0 && x != 0))
		return false;
	
	int reversedNumber = 0;
	while (x > reversedNumber) {
		reversedNumber = reversedNumber * 10 + x % 10;
		x /= 10;
	}
	
	return x == reversedNumber || x == reversedNumber / 10;
}