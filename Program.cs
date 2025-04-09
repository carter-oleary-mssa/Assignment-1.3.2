Console.WriteLine("----- DIFFERENT WAYS TO INITIALIZE ARRAYS ------");
Console.WriteLine("1. Creating an empty array and adding values later");
string[] array = new string[3];
Console.WriteLine("Initial Array Values:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
array[0] = "One";
array[1] = "Two";
array[2] = "Three";
Console.WriteLine("Changed array values: ");
for(int i = 0;i < array.Length;i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine("\n\n2. Creating an array and assigning values immediately");
string[] array2 = new string[3] {"Uno", "Dos", "Tres"};
for(int i = 0;  i < array2.Length; i++)
{
    Console.WriteLine(array2[i]);
}

Console.WriteLine("\n\n3. Creating an array without specifying size");
string[] noSizeArray = new string[] {"Bananas", "Bagels", "Eggs", "Salt"};
for(int i = 0; i<noSizeArray.Length; i++)
{
    Console.WriteLine(noSizeArray[i]);
}

Console.WriteLine("\n\n4. Creating an array without using \'new\' keyword or specifying size");
string[] noNewArray = { "Wow", "This", "Is", "Pretty", "Neat" };
for (int i = 0; i < noNewArray.Length; i++)
{
    Console.WriteLine(noNewArray[i]);
}

Console.WriteLine("\n\n5. Using the sort function");
int[] numArray = { 5, 7, 2, 8, 4 };
Console.Write("Unsorted Array: ");
for(int i = 0; i< numArray.Length; i++)
{
    Console.Write($"{numArray[i]} ");
}
Array.Sort(numArray);
Console.Write("\nSorted Array: ");
for(int i = 0;  i<numArray.Length; i++)
{
    Console.Write($"{numArray[i]} ");
}