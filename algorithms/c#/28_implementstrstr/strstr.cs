// Creator Ben Stickney
// Date 3/14/2018

/*
Implement strStr().

Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Example 1:

Input: haystack = "hello", needle = "ll"
Output: 2

Example 2:
Input: haystack = "aaaaa", needle = "bba"
Output: -1
*/

public int StrStr(string haystack, string needle) {
	if(string.IsNullOrEmpty(needle))
		return 0;
	
	int nlen = needle.Length;
	for(int i = 0; i <= haystack.Length - nlen; i++)
		if(haystack.Substring(i, nlen).Equals(needle))
			return i;
	return -1;
}