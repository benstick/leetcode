// Creator Ben Stickney
// Date 3/14/2018

/*
Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.

If the last word does not exist, return 0.

Note: A word is defined as a character sequence consists of non-space characters only.

Example:

Input: "Hello World"
Output: 5
*/

public int LengthOfLastWord(string s) {
    int slen = 0, stail = s.Length - 1;
	
	while(stail >= 0 && s[stail] == ' ')
		stail--;
	while(stail >= 0 && s[stail] != ' '){
		slen++;
		stail--;
	}
	return slen;
}