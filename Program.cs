
using System.Collections;
using WorkingWithArrays;

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




