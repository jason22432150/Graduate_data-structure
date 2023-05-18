class Program
{
    private static void Calculate(string postfix)
    {
        Stack<string> stack = new Stack<string>();
        Stack<string> Calculate_String = new Stack<string>();
        string infix;
        // float result = 0;
        foreach (char c in postfix)
        {
            //float c = (float)cha;
            if (c != '+' && c != '-' && c != '*' && c != '/' && c != '^')
            {
                stack.Push(c.ToString());
            }
            else
            {
                float second = float.Parse(stack.Pop());
                float first = float.Parse(stack.Pop());
                //float secondStr;
                string firstStr = "";
                if (Calculate_String.Count != 0)
                {
                    //secondStr = float.Parse(Calculate_String.Pop());
                    firstStr = Calculate_String.Pop();
                }
                else
                {
                    firstStr = "empty";
                }
                switch (c)
                {
                    case '+':
                        float result = first + second;
                        stack.Push(result.ToString());
                        Calculate_String.Push("(" + firstStr + "+" + "(" + first + "+" + second + ")" + ")");
                        break;
                    case '-':
                        result = first - second;
                        stack.Push(result.ToString());
                        Calculate_String.Push("(" + firstStr + "+" + "(" + first + "-" + second + ")" + ")");
                        break;
                    case '*':
                        result = first * second;
                        stack.Push(result.ToString());
                        Calculate_String.Push("(" + firstStr + "+" + "(" + first + "*" + second + ")" + ")");
                        break;
                    case '/':
                        result = first / second;
                        stack.Push(result.ToString());
                        Calculate_String.Push("(" + firstStr + "+" + "(" + first + "/" + second + ")" + ")");
                        break;
                    case '^':
                        result = Convert.ToInt32(first) ^ Convert.ToInt32(second);
                        stack.Push(result.ToString());
                        Calculate_String.Push("(" + firstStr + "+" + "(" + first + "^" + second + ")" + ")");
                        break;
                }
            }
        }
        // infix = Calculate_String.Pop();
        Console.WriteLine(Calculate_String.Pop());
        Console.WriteLine(stack.Pop());
    }
    static void Main()
    {
        string postfix = "23^45*+";
        Calculate(postfix);
        Console.WriteLine();
    }
}