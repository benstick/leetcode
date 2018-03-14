// Creator Ben Stickney
// Date 3/14/2018

/*
Given a sorted array, remove the duplicates in-place such that each element appear only once and return the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

Example:

Given nums = [1,1,2],

Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
It doesn't matter what you leave beyond the new length.
*/

public int RemoveDuplicates(int[] nums) {
    if(nums == null || nums.Length == 0)
		return 0;
	
	int i = 1;
	for(int j = 1; j < nums.Length; j++)
		if(nums[j] != nums[i-1])
			nums[i++] = nums[j];
	return i;
}