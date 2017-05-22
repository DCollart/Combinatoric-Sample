# Combinatoric sample

## What is it?
It's just a little project made to show the (big) differences between some kind of algorithms and the importance to wisely choose them.

Algorithm type currently in use :
Recursion
Memoization
Dynamic

## Problem 
Input : 
The different values you can use.
The amount you want to reach with the differents values.

Output : 
The count of the different ways to reach the amount with the values.


## Result 
### 1st example 
Values = [ 2, 3, 4, 1, 6, 8, 7, 9, 12, 15 ]
Amount = 15
Output : 120 ways to reach 15 with the values [ 2, 3, 4, 1, 6, 8, 7, 9, 12, 15 ]
Performance : 
	* Recursion : 0 ms, 757 ticks, 224 octets
	* Memoization : 0 ms, 1456 ticks, 3548 octets.
	* Dynamic : 0 ms, 954 ticks, 382 octets.

### 2nd example 
Values = [ 2, 3, 4, 1, 6, 8, 7, 9, 12, 15 ]
Amount = 100
Output : 2550451 ways to reach 100 with the values [ 2, 3, 4, 1, 6, 8, 7, 9, 12, 15 ]
Performance : 
	* Recursion : 1402 ms, 4371799 ticks, 224 octets
	* Memoization : 0 ms, 2360 ticks, 31386 octets.
	* Dynamic : 0 ms, 1327 ticks, 1062 octets.

### 3rd example 
Values = [ 2, 3, 4, 1, 6, 8, 7, 9, 12, 15 ]
Amount = 150
Output : 47022867 ways to reach 150 with the values [ 2, 3, 4, 1, 6, 8, 7, 9, 12, 15 ]
Performance : 
	* Recursion : 33948 ms, 105831900 ticks, 224 octets
	* Memoization : 0 ms, 2603 ticks, 31912 octets.
	* Dynamic : 0 ms, 1829 ticks, 1462 octets.



