// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Hello, World!");



// 1. Iterate and print values

static void PrintList(List<string> MyList)
{
    // Your code here
    foreach (string names in MyList) //foreach loop goes through each names at a time
    {
        Console.WriteLine(names); // called the function to call 

    }

}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };  //created a list of names called testmystringlist
PrintList(TestStringList);  // made a function called printlist


//-----------------------------------------------------------------------------

//2. Print Sum...Given a List of integers, calculate and print the sum of the values.

static void SumOfNumbers(List<int> IntList)
{
    // Your code here

    int sum = 0; // Starting the sum at 0

    foreach (int number in IntList)
    {
        sum += number;  // Add the current number to the sum
    }

    Console.WriteLine(sum);

}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// You should get back 33 in this example
SumOfNumbers(TestIntList);


//------------------------------------------------------------------------------

// 3. Find Max..... Given a List of integers, find and return the largest value in the List.

static int FindMax(List<int> IntList)
{
    // Your code here

    int max = IntList[0]; // made a variable to store the maximum value, starting with the first element.

    // Iterate 
    for (int i = 1; i < IntList.Count; i++)  // looking through the list starting from the second element.
    {
        if (IntList[i] > max) // Compare the current element with the current maximum.
        {
            max = IntList[i]; // If the current element is greater, update the maximum value.
        }
    }

    return max; // Return the maximum value found.
}


List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// You should get back 17 in this example

Console.WriteLine(FindMax(TestIntList2));


//-------------------------------------------------------------------------------------------------

//4. Square the Values.... Given a List of integers, return the List with all the values squared.



static List<int> SquareValues(List<int> IntList)
{
    // Your code here
    List<int> squaredList = new List<int>(); // Created a new list to store squared values.
    foreach (int num in IntList)
    {
        squaredList.Add(num * num); // get each square number and add it to the squaredList.
    }
    return squaredList; // Return the list with squared values.
}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);
// Console.WriteLine(SquareValues(TestIntList3));

//--------------------------------------------------------------------------------------------------------

//5. Replace Negative Numbers with 0.... Given an array of integers, return the array with all values below 0 replaced with 0.



static int[] NonNegatives(int[] IntArray)
{
    // Your code here
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)  // checking making sure the i is less than 0
        {
            IntArray[i] = 0;  // if so it will replace it with 0
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
// You should get back [0,2,3,0,5], think about how you will show that this worked

Console.WriteLine(NonNegatives(TestIntArray));



//--------------------------------------------------------------------------------------------------------------------------

//6. Print Dictionary.... Given a dictionary, print the contents of the said dictionary.



static void PrintDictionary(Dictionary<string,string> MyDictionary)  // Define a function that prints the contents of a dictionary
{
    // Your code here

        foreach (KeyValuePair<string, string> entry in MyDictionary)  // Go through each item in the dictionary
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);  // Print the key and value of the current item in a specific format
        }

}
Dictionary<string,string> TestDict = new Dictionary<string,string>();  // Add key-value pairs to the dictionary
TestDict.Add("HeroName", "Iron Man");  // Add key-value pairs to the dictionary
TestDict.Add("RealName", "Tony Stark"); // Add key-value pairs to the dictionary
TestDict.Add("Powers", "Money and intelligence"); // Add key-value pairs to the dictionary
PrintDictionary(TestDict);


