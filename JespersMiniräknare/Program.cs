// Välkomnande meddelande
// En lista för att spara historik för räkningar
// Användaren matar in tal och matematiska operation
//OBS! Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet!
// Ifall användaren skulle dela 0 med 0 visa Ogiltig inmatning!
// Lägga resultat till listan
//Visa resultat
//Fråga användaren om den vill visa tidigare resultat.
//Visa tidigare resultat
//Fråga användaren om den vill avsluta eller fortsätta.

using System;
// Creates a list that is outside of the loop with the past calculations.
List<string> pastresult = new List<string>();
string val = "";
while (val != "3")
{

Console.WriteLine("Välkommen till Jespers Miniräknare\n");
Console.WriteLine("Välj ett av följande alternativ\n");
Console.WriteLine("1.Räkna");
Console.WriteLine("2.Visa tidigare resultat");
Console.WriteLine("3.Avsluta program");
val = Console.ReadLine();

 // cases for every menu option
 // and default is for if you pick a invalid option, then you get a error message and it tells you press enter to go back
switch (val)
{
        case "1":
            Console.Clear();
            {
                Calculate();
            }
            
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("Tidigare resultat");
            foreach (string item in pastresult) 
            { 
                Console.WriteLine(item); 
            }
            Console.ReadKey();
            Console.Clear();
            break;

         case "3":
            Console.Clear();
            Console.WriteLine("Programmet avslutas...");
            break;

         default:
            Console.Clear();
            Console.WriteLine("Du valde inte ett giltigt alternativ!\nTryck enter för att gå tillbaka");
            Console.ReadKey();
            Console.Clear();
             break;
}
}

void Calculate()
{
    
    string value;
    do
    {
        double res=0;
        Console.Write("Skriv in första talet:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        string symbol;
        // loops until you pick a valid input
        while (true)
        {
            Console.Write("Välj räknesätt(/,+,-,*):");
            symbol = Console.ReadLine();
            if (symbol == "/" || symbol == "+" || symbol == "-" || symbol == "*")
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ogiltig inmatning!");
            }
        }
        
        Console.Write("Skriv in andra talet:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        // if user tries to do 0/0 you get a message with wrong input and then return to start of program.
        if (symbol== "/" && num1==0 && num2==0)
        {
            Console.WriteLine("Ogiltig inmatning!");
            Console.ReadKey();
            Console.Clear ();
            return;
        }
        // a case for every counting method
        switch (symbol)
        {
            case "+":
                res = num1 + num2;              
                break;

            case "-":
                res = num1 - num2;            
                break;

            case "*":
                res = num1 * num2;              
                break;

            case "/":
                res = num1 / num2;              
                break;

            default:
                Console.WriteLine("Ogiltig inmatning!");
                break;
        }
        // a string that counts all the different math calculations instead of having one in every different switch(symbol) case.
        string result = num1 + symbol + num2 + "=" + res;
        Console.WriteLine(result);
        // takes the math resluts and adds them in pastresult list
        pastresult.Add(result);
        Console.ReadLine();
        // asks if user want to continue, if you pick yes you get to do a new math calculation,
        // if you pick no you start over in the menu
        Console.Write("Vill du fortsätta?(y/n):");
        value = Console.ReadLine();
        Console.Clear();
    }
    while (value == "y" || value == "Y");
}