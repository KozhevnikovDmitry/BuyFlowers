BuyFlowers
===========

Test task for vacancy of .net developer for Rosbank.

Task decription.

You and your K-1 friends want to buy N flowers. Flower number i has host ci. Unfortunately the seller does not like a customer to buy a lot of flowers, so he tries to change the price of flowers for customer who had bought flowers before. More precisely if a customer has already bought x flowers, he should pay (x+1)*ci dollars to buy flower number i. 
You and your K-1 firends want to buy all N flowers in such a way that you spend the as few money as possible. 

Input: 

The first line of input contains two integers N and K. 
next line contains N positive integers c1,c2,...,cN respectively. 

Output: 

Print the minimum amount of money you (and your friends) have to pay in order to buy all n flowers. 

Sample onput : 

3 3 
2 5 6 

Sample output : 

13 

Explanation : 
In the example each of you and your friends should buy one flower. in this case you have to pay 13 dollars. 

Constraint : 

1 <= N, K  <= 100 
Each ci is not more than 1000,000 

Sample program 

/* Sample program illustrating input/output mtehods */ 
using System; 
using System.Collections.Generic; 
using System.IO; 
class Solution 
{ 
	static void Main(String[] args) 
	{ 
		   int N, K; 
		   string NK = Console.ReadLine(); 
		   string[] NandK = NK.Split(new Char[] {' ', '\t', '\n'}); 
		   N = Convert.ToInt32(NandK[0]); 
		   K = Convert.ToInt32(NandK[1]); 
			
		   int [] C = new int [N]; 
			
		   string numbers = Console.ReadLine(); 
		   string[] split = numbers.Split(new Char[] {' ', '\t', '\n'}); 
			
		   int i = 0; 

		   foreach (string s in split){ 
						   if( s.Trim() != ""){ 
										   C[i++] = Convert.ToInt32(s); 
						   } 
		   }               
			
		   int result = 0; 
		   // put your code here 
		   Console.WriteLine(result); 
	} 
}
