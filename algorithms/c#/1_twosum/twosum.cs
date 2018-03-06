// Creator Ben Stickney
// Date 3/5/2018

/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example: 
Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/

public int[] TwoSum(int[] nums, int target) {
	int[] array = new int[2];
	for(int i = 0; i < nums.Length; i++)
		for(int j = i + 1; j < nums.Length; j++)
			if(nums[i] + nums[j] == target){
				array[0] = i;
				array[1] = j;
			}
			
	return array;
}