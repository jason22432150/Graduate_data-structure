class Program
{
    private void Calculate(string postfix)
    {
        Stack<string> stack = new Stack<string>();
        Stack<string> Calculate_String = new Stack<string>();
        string infix;
        // int result = 0;
        foreach (char c in postfix)
        {
            if (c != '+' || c != '-' || c != '*' || c != '/' || c != '^')
            {
                stack.Push(c.ToString());
            }
            else
            {
                int second = int.Parse(stack.Pop());
                int secondStr = int.Parse(Calculate_String.Pop());
                int first = int.Parse(stack.Pop());
                int firstStr = int.Parse(Calculate_String.Pop());
                switch (c)
                {
                    case '+':
                        int result = first + second;
                        stack.Push(result.ToString());
                        Calculate_String.Push("(" + secondStr + "+" + firstStr + ")");
                        break;
                    case '-':
                        result = (char)(first / second);
                        stack.Push(result.ToString());
                        Calculate_String.Push("(" + secondStr + "-" + firstStr + ")");
                        break;
                    case '*':
                        result = (char)(first * second);
                        stack.Push(result.ToString());
                        Calculate_String.Push("(" + secondStr + "*" + firstStr + ")");
                        break;
                    case '/':
                        result = (char)(first / second);
                        stack.Push(result.ToString());
                        Calculate_String.Push("(" + secondStr + "/" + firstStr + ")");
                        break;
                    case '^':
                        result = (char)(first ^ second);
                        stack.Push(result.ToString());
                        Calculate_String.Push("(" + secondStr + "^" + firstStr + ")");
                        break;
                }
            }
        }
        infix = Calculate_String.Pop();
        Console.WriteLine();
    }
    static void Main()
    {
        string postfix = "23-54*+";
        Calculate(postfix);
        Console.WriteLine();
    }
}