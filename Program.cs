
using System.Collections;
using WorkingWithArrays;
using YourNamespace;

MyDynamicArray myArray = new MyDynamicArray(3);
myArray.Insert(1);
myArray.Insert(2);
myArray.Insert(3);
myArray.Insert(4);

var myIndex = myArray.IndexOf(2);
Console.WriteLine(myIndex);

var res = myArray.Print();
Console.WriteLine(res);



int[] numbers = { 10, 20, 30 };


Console.WriteLine(numbers.Length);
foreach (var item in numbers)
{
    Console.WriteLine(item);
}



//---------------------------------------------------

StringReverser reverser = new StringReverser();
var reverseString = reverser.Reverse("Hello World!");
Console.WriteLine(reverseString);

string str = "(1+2";
MyExpression myExp = new MyExpression();
bool isBalanced = myExp.IsBalanced(str);
Console.WriteLine($"Is the expression {str} balanced? {isBalanced}");

//---------------------------------------------------

Queue<int> myQueue = new Queue<int>();
PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

//---------------------------------------------------

List<string> names = new List<string>();
names.ToHashSet();



Dictionary<int, string> myDict = new Dictionary<int, string>();
myDict.Add(1, "One");
myDict.Add(2, "Two");   
myDict[3] = "Three";
var result = myDict.FirstOrDefault(x => x.Key == 2);
System.Console.WriteLine(result.Value);
foreach (var item in myDict)
{
    Console.WriteLine(item);
}


//---------------------------------------------------



MyBinaryTree binaryTree = new MyBinaryTree();
binaryTree.Insert(7);
binaryTree.Insert(4);
binaryTree.Insert(9);
binaryTree.Insert(1);
binaryTree.Insert(6);
binaryTree.Insert(8);
binaryTree.Insert(10);
System.Console.WriteLine(binaryTree.Find(11));

binaryTree.TraversePreOrder();




