class program
{

    static int OutStackPrecedence(char c)
    {
        switch (c)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            case '^':
                return 3;
            case '(':
                return 4;
        }
        return -1;
    }
    static int InStackPrecedence(char c)
    {
        switch (c)
        {
            case '(':
                return 0;
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                // case '^':
                return 2;
            case '^':
                return 3;
        }
        return -1;
    }
    public static string InfixToPostfix(string infix)
    {
        Stack<char> stack = new Stack<char>();
        string postfix = "";
        foreach (char c in infix)
        {
            if (c != '+' && c != '-' && c != '/' && c != '*' && c != '^' && c != '(' && c != ')')
            {
                postfix += c;
            }
            else if (c == ')')
            {
                while (stack.Peek() != '(')
                {
                    postfix += stack.Pop();
                }
                stack.Pop();
            }
            else if (stack.Count == 0 || OutStackPrecedence(c) > InStackPrecedence(stack.Peek()))
            {
                stack.Push(c);
            }
            else if (stack.Count != 0 && OutStackPrecedence(c) <= InStackPrecedence(stack.Peek()))
            {
                if (stack.Peek() == '^')
                {
                    postfix += stack.Pop();
                    postfix += stack.Pop();
                    stack.Push(c);
                }
                else
                {
                    postfix += stack.Pop();
                    stack.Push(c);
                }

            }

            else
            {
                Console.WriteLine("Error");
            }
        }
        while (stack.Count != 0)
        {
            postfix += stack.Pop();
        }
        return postfix;
    }
    static void Main(string[] args)
    {
        // string infix = "a+b*c";
        string infix = "a+b*(c-d)/e^f*g+h";
        string postfix = InfixToPostfix(infix);
        Console.Write("Topic         :");
        Console.WriteLine(infix);
        Console.Write("My Answer     :");
        Console.WriteLine(postfix);
        Console.Write("Correct Answer:");
        Console.WriteLine("abcd-*ef^/g*+h+");
    }
}