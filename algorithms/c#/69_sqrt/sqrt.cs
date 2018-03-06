// Creator Ben Stickney
// Date 3/5/2018

/*
Implement int sqrt(int x).

Compute and return the square root of x.

x is guaranteed to be a non-negative integer.
*/

public int sqrt(int x) {
	if (x < 2)
		return x;

	int left = 1;
	int right = x / 2;

	while (left <= right)
	{
		int mid = left + (right - left) / 2;

		if (mid > x / mid)
			right = mid - 1;
		else
			left = mid + 1;
	}

	return left - 1;
}