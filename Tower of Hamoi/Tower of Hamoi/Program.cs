class Program
{
    static void Towers_of_hanio(int n, char fromPeg, char toPeg, char auxPeg)
    {
        if (n == 1)
        {
            Console.WriteLine("Move Disk 1 from {0} to {1}", fromPeg, toPeg);
            return;
        }
        Towers_of_hanio(n - 1, fromPeg, auxPeg, toPeg);
        Console.WriteLine("Move Disk {0} from {1} to {2}", n, fromPeg, toPeg);
        Towers_of_hanio(n - 1, auxPeg, toPeg, fromPeg);
    }

    static void Main()
    {
        while (true)
        {
            int n = 4; // number of disks
            char fromPeg = 'A',
                toPeg = 'C',
                auxPeg = 'B';

            Console.WriteLine("Moves required to solve the puzzle:");
            Towers_of_hanio(n, fromPeg, toPeg, auxPeg);
        }
    }
}
