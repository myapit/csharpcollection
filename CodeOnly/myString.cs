using System;

class textFrame
{
    static void displayText(string text)
    {
        int length = text.Length;
        Console.WriteLine('+' + new string('-', length + 4) + '+');
        Console.WriteLine("|  " + text + "  |"); //2 space because add 4.
        Console.WriteLine('+' + new string('-', length + 4) + '+');     
    }

    static void Main()
    {
        displayText("Heloooo0000ooo0oo0oo");
    }    
}
