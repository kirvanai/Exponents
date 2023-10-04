public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Learn your squares and cubes!");
        bool goOn = true;
        
        while(goOn == true)
        {
        Console.WriteLine();
        Console.WriteLine("Enter an integer:");
        int exInt = int.Parse(Console.ReadLine());


        if (exInt <= 0)
        {
            Console.WriteLine("Invalid Reponse. Integer must be greater than 0. Please try again:");
        }
        
        else if (exInt < 1291)
        {

        string tableHeader = String.Format("{0,0} {1,20} {2,19}", "Number", "Squared", "Cubed");
        string tableHeader2 = String.Format("{0,0} {1,19} {2,20}", "=======", "=======", "======");
        Console.WriteLine(tableHeader); 
        Console.WriteLine(tableHeader2);

        for (int i = 1; i <= exInt; i++) 
        {
            string formatString = String.Format("{0,7} {1,19} {2,20}", i, Math.Pow(i,2), Math.Pow(i,3));
            Console.WriteLine(formatString);
        }
            goOn = AskToContinue();
        }
        else
        {
            Console.WriteLine("Number entered outside of max range of 1290.");
        }
        }

    }

    
    
    public static bool AskToContinue()
    {
        Console.WriteLine("Would you like to run again? y/n");
        string input = Console.ReadLine();

        if (input == "y")
        {
            return true;
        }
        else if (input == "n")
        {
            return false;
        }
        else
        {
            Console.Write("Hey I didn't understand your response");
            return AskToContinue();
        }
    }
}