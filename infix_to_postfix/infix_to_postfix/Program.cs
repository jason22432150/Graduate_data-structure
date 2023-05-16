// 1. 创建一个空的操作数栈和一个空的输出队列。

// 2. 从左到右扫描表达式中的每个元素。

// 3. 如果当前元素是一个操作数（即数字或变量），则将其放入输出队列中。

// 4. 如果当前元素是一个左括号，则将其压入操作数栈中。

// 5. 如果当前元素是一个右括号，则将操作数栈中的元素弹出并放入输出队列中，直到弹出的元素是左括号为止。注意，左括号不会放入输出队列中，也不会放入操作数栈中。

// 6. 如果当前元素是一个操作符，记为 `op`，则执行以下操作：
//    a. 如果操作数栈为空，则将 `op` 压入操作数栈中。
//    b. 如果操作数栈不为空，则比较 `op` 与操作数栈顶的操作符的优先级。如果 `op` 的优先级大于操作数栈顶的操作符，则将 `op` 压入操作数栈中。
//    c. 否则，将操作数栈顶的操作符弹出并放入输出队列中，直到操作数栈顶的操作符优先级小于等于 `op`，然后将 `op` 压入操作数栈中。

// 7. 如果表达式中的所有元素都被处理完了，则将操作数栈中的元素依次弹出并放入输出队列中，直到操作数栈为空。

// 8. 输出队列中的元素就是后缀表达式。
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
        char[] infixArray = infix.ToCharArray();

        foreach (int i in infixArray)
        {
            Console.WriteLine(i);
            char c = (char)i;
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
                while (stack.Count != 0 && OutStackPrecedence(c) <= InStackPrecedence(stack.Peek()))
                {
                    postfix += stack.Pop();
                }
                stack.Push(c);
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