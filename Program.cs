// See https://aka.ms/new-console-template for more information


class programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte geben Sie eine Jahreszahl ein: ");
        int Jahr = Convert.ToInt32(Console.ReadLine());

        if (IstSchaltJahr(Jahr))
        {
            Console.WriteLine(Jahr + " Ist ein Schaltjahr!");
        }
        else
        {
            Console.WriteLine(Jahr + " Ist kein Schaltjahr!");
        }
        Console.ReadKey();
    }


    static bool IstSchaltJahr(int Jahr)
    {
        return (Jahr % 4 == 0 && Jahr % 100 != 0) || (Jahr % 400 == 0);
    }


}