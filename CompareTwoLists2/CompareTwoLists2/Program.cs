using System.Collections.Generic;
IList<int> myList1 = new List<int> { 1,2,3};
IList<int> myList2 = new List<int> { 1,2,3};
if (myList1.SequenceEqual(myList2))
{
    Console.WriteLine($"First list {myList1} is equale to second {myList2}");
}
else
{
    Console.WriteLine($"First list {myList1} is NOT equale to second {myList2}");
}