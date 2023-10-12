// Question q1 = new("5+6", new
//  List<string>() 
//  {"15", "27", "11"}, 2);

// Question q1 = new Question();
// q1.text = "5+6";
// q1.answers = new List<string>() {"15", "27", "11"};
// q1.correct = 2;

// Question 
// {}

Tamagochi tama = new();
string input;

Console.WriteLine("Välj ett namn till din tamagochi");
tama.name = Console.ReadLine();

while (tama.GetAlive() == true)
{
    tama.PrintStats();

    Console.WriteLine($"Vad göra med {tama.name}");
    Console.WriteLine("1. Lära den ett nytt ord");
    Console.WriteLine("2. Hälsa på den");
    Console.WriteLine("3. Mata den");
    Console.WriteLine("4. Ingenting");
    input = Console.ReadLine();
    if(input == "1")
    {
        Console.WriteLine($"Vad vill lära din {tama.name} för ord?");
        tama.TeachWord(Console.ReadLine());
        Console.WriteLine($"{tama.name} kan ett nytt ord nu!");
        tama.Tick();
        Console.ReadLine();
    }
    else if (input == "2")
    {
        tama.Hello();
        tama.Tick();
        Console.ReadLine();
    }
    else if (input == "3")
    {
        Console.WriteLine($"Du gav {tama.name} en bit pizza");
        tama.Feed();
        tama.Tick();
        Console.ReadLine();
    }
    else if (input == "4")
    {
        tama.Tick();
    }
    else
    {
        Console.WriteLine("Nej du kan int skriva så mongo..");
        Console.ReadLine();
    }
    Console.Clear();
}

Console.WriteLine($"{tama.name} är nu död.. du suger å borde ocå dö.");
Console.ReadLine();