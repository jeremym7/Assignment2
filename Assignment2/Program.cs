using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            try
            {

				Console.WriteLine("Enter a set of numbers: ");
				int[] nums = new int[6];
				int n = Convert.ToInt32(Console.ReadLine());


				for (int i = 0; i < nums.Length; i++)
				{
					nums[i] = int.Parse(Console.ReadLine());
				}
				static int[] Shuffle(int[] nums, int n)
				{

					if (nums == null || nums.Length == 0)
						return nums;

					int[] res = new int[2 * n];
					int idx1 = 0, idx2 = n;

					for (int i = 0; i < 2 * n; i++)
					{
						if (i % 2 == 0)
							res[i] = nums[idx1++];
						else
							res[i] = nums[idx2++];
					}

					return res;
				}
				Shuffle(nums, n);
			}
            catch (Exception)
            {
				throw;
            }

			//#2 Need to fix the output
            try
            {

				Console.WriteLine("Enter a set of numbers: ");
				int[] nums = new int [5];
				for(int i = 0; i < nums.Length; i++)
                {
					nums[i] = int.Parse(Console.ReadLine());
                }

				static void MoveZeros(int[] nums)
				{
					if (nums == null || nums.Length <= 1)
						return;

					int curr = 0;
					int next = 1;

					while (next <= nums.Length - 1)
					{
						if (nums[curr] == 0)
						{
							if (nums[next] == 0)
							{
								next++;
								continue;
							}
							else
							{
								nums[curr] = nums[next];
								nums[next] = 0;
							}
						}
						curr++;
						next++;
					}
				}
				MoveZeros(nums);
				Console.WriteLine(nums);
			}
            catch (Exception)
            {
				throw;
            }

			//#3
			try
			{
				Console.WriteLine("Enter an array of integers: ");
				static int NumIdenticalPairs(int[] nums)
				{
					var dict = new Dictionary<int, int>();
					for (int i = 0; i < nums.Length; i++)
					{
						if (dict.ContainsKey(nums[i]))
						{
							dict[nums[i]] += 1;
						}
						else
						{
							dict[nums[i]] = 1;
						}
					}

					int k = 0;
					foreach (var keyValuePair in dict)
					{
						if (keyValuePair.Value == 1) continue;
						k += keyValuePair.Value * (keyValuePair.Value - 1) / 2;
					}

					return k;
				}
			}
			catch (Exception)
			{
				throw;
			}


			//#4
			try
			{
				Console.WriteLine("Give an array of integers: ");
				static int[] TwoSum(int[] nums, int target)
				{

					if (nums == null || nums.Length < 2)
						return new int[2];

					Dictionary<int, int> dic = new Dictionary<int, int>();

					for (int i = 0; i < nums.Length; i++)
					{
						if (dic.ContainsKey(target - nums[i]))
							return new int[] { i, dic[target - nums[i]] };
						else if (!dic.ContainsKey(nums[i]))
							dic.Add(nums[i], i);
					}

					return new int[2];
				}
			}
			catch (Exception)
			{
				throw;
			}

			//#5
			try
			{
				Console.WriteLine("Give a string: ");
				static string RestoreString(string s, int[] indices)
				{
					//Sol1: 1. Store index with the string char and 2. return string based of indices char.
					char[] cArr = new char[s.Length];

					for (int i = 0; i < s.Length; i++)
					{
						cArr[indices[i]] = s[i];
					}

					return new string(cArr);
				}
			}
			catch (Exception)
			{
				throw;
			}

			//#6
			try
			{
				Console.WriteLine("Determine whether two give strings s1 and s2, are isomorphic: ");
				static bool IsIsomorphic(string s, string t)
				{
					int index = 0;
					Hashtable hashS = new Hashtable();
					Hashtable hashT = new Hashtable();

					while (index <= s.Length - 1)
					{
						if (hashS.ContainsKey(s[index]) != hashT.ContainsKey(t[index]) ||
							(hashS.ContainsKey(s[index]) && hashT.ContainsKey(t[index]) && (int)hashS[s[index]] != (int)hashT[t[index]]))
							return false;

						if (!hashS.ContainsKey(s[index]))
						{
							hashS.Add(s[index], index);
							hashT.Add(t[index], index);
						}

						index++;
					}

					return true;
				}
			}
			catch (Exception)
			{
				throw;
			}

			//#7
			try
			{
				Console.WriteLine("Determine whether two give strings s1 and s2, are isomorphic: ");
			}
			catch (Exception)
			{
				throw;
			}

			//#8
			try
			{
				Console.WriteLine("Write a number: ");
				static bool IsHappy(int n)
				{
					HashSet<int> seen = new HashSet<int>();
					while (n != 1)
					{
						if (seen.Contains(n))
							return false;
						seen.Add(n);
						int newNum = 0;
						while (n > 0)
						{
							newNum += (int)Math.Pow(n % 10, 2);
							n /= 10;
						}
						n = newNum;
					}
					return true;
				}
			}
			catch (Exception)
			{
				throw;
			}

			//#9
			try
			{
				static int MaxProfit(int[] prices)
				{
					var n = prices.Length;
					if (n == 0) return 0;
					var globalMaxProfit = 0;
					var globalMin = prices[0];
					for (int i = 1; i < n; i++)
					{
						var curPrice = prices[i];
						var localMaxProfit = Math.Max(0, curPrice - globalMin);
						globalMaxProfit = Math.Max(localMaxProfit, globalMaxProfit);
						globalMin = Math.Min(globalMin, curPrice);
					}

					return globalMaxProfit;
				}
			}
			catch (Exception)
			{
				throw;
			}

			//#10
			try
			{
				static int ClimbStairs(int n)
				{
					if (n <= 2)
						return n;

					int[] res = new int[n + 1];

					res[1] = 1;
					res[2] = 2;

					for (int i = 3; i <= n; i++)
						res[i] = res[i - 1] + res[i - 2];

					return res[n];
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
    }
}
