SayHello();
// ^^ Variabeln som skapandes nedre:


string a = AskYesNo("Are you stupid?");
if (a == "y")
{
    Console.WriteLine("GOOD");
}
// Meotden nedre, som säger Y/n och beroende på svar säger good om du säger y

Console.ReadLine();





// Metod som säger" Hello"
// "Void" betyder att den inte ska returernas, inte ge tillbaka som readline gör
// Måsvingar avgränsar kod, skiljer koden innuti vingar från resten av programmet, tex i "if" sats så kör bara kod om x händer
// 
static void SayHello()
{
    Console.WriteLine("HELLO");
}

// -----------------------------------------
// Håll [ ALT ] och [ UP & NER PIL ] för att flytta kod
// Det som händer i metoden kan inte läsa det utanför metoden och resten av koden i programmet kan inte läsa det som i metoden
// * Las Vegas * = Void
// string = Lovar att returenera en string (behöver skriva return string, då avbryts körning)

static string AskYesNo(string questiontext) // När man skriver string questiontext så läggs de man skriver i övre paranetes tex "Are you stupid"
{
Console.WriteLine("[y/n}");

string answer = Console.ReadLine().ToLower();

return answer;
//Kod under return kommer inte köras.
}