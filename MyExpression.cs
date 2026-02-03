namespace WorkingWithArrays
{
    public class MyExpression
    {
        public MyExpression()
        {
        }


        public bool IsBalanced(string input)
        {
            Stack<char> myStack = new Stack<char>();
            foreach (var chr in input.ToCharArray())
            {
                if (chr == '(')
                {
                    myStack.Push(chr);
                }
                else if (chr == ')')
                {
                    if (myStack.Count == 0)
                    {
                        return false;
                    }
                    myStack.Pop();
                }
            }
           return myStack.Count == 0;
        }

    }

}
