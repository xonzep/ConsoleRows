using System.Data;

//Get information and store each in a var for our function
Console.WriteLine("Target Row?: ");
int uRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Targe Column?: ");
int uCol = Convert.ToInt32(Console.ReadLine());

void DefensePosition(int row, int col)
{
    //Setup title and color
    Console.Title = "Defense of Consolas";
    Console.ForegroundColor = ConsoleColor.Green;

    //Calculate the postions 
    int leftRow = col - 1;
    int rightRow = col + 1;
    int bottomCol = row - 1;
    int topCol = row + 1;

    //Display positions
    Console.WriteLine("Deploy to: ");
    Console.WriteLine($"({row}, {leftRow})");
    Console.WriteLine($"({col}, {bottomCol})");
    Console.WriteLine($"({row}, {rightRow})");
    Console.WriteLine($"({topCol}, {col})");

    //Notify of finished work.
    Console.Beep(440, 1000);

}

//Run our function
DefensePosition(uRow,uCol);