class Program
{
    static int get_rank(char c)
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
    public static string infix_to_postfix(string input)
    {
        Stack<char> stack = new Stack<char>();
        string output = "";
        foreach (char c in input)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^' || c == '(')
            {
                if (stack.Count == 0)
                {
                    stack.Push(c);
                }
                if (get_rank(stack.Peek()) < get_rank(c))
                {
                    stack.Push(c);
                }
                else
                {
                    while (stack.Count == 0) ;
                    {
                        output+=stack.Pop();
                    }
                }
            }
            else if (c == ')')
            {
                while (stack.Count!=0)
                {
                    char popData = stack.Pop();
                    output += popData;
                    if (popData == '(')
                    {
                        break;
                    }
                }
            }
            else
            {
                output += c;
            }
        }
        while (stack.Count != 0) ;
        {
            output += stack.Pop();
        }
        return output;
    }
    static void Main(string[] args)
    {
        Console.Write("input infix expression: ");
        string input = Console.ReadLine();
        string ans = infix_to_postfix(input);
        Console.WriteLine(ans);
    }
}