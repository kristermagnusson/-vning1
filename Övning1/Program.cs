List<string> namn = new List<string>();
List<string> lön = new List<string>();
int antal = 0;
string enlön;
string ettnamn;
String svar1 = " ";
string svar2 = " ";  

while (svar1 != "n")
{
    antal = antal + 1; ;
    Console.WriteLine("skriv in namn");
    ettnamn = Console.ReadLine();
    namn.Add(ettnamn);
    Console.WriteLine("skriv in lön");
    enlön = Console.ReadLine();
    lön.Add(enlön);
    Console.WriteLine("Fler inmatningar ? j/n enter");
    svar1 = Console.ReadLine();
    
}

Console.WriteLine("namn     "+"Lön   ");
for (int i = 0; i < antal; i++)
    Console.WriteLine(namn[i] + "     " + lön[i]);
    