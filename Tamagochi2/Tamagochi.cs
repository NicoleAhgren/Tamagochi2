public class Tamagochi
{
    int hunger = 0;
    int boredom = 0;
    List<string> words = new() {"cheeeese"};
    bool isAlive = true;

    Random generator  = new Random();

    public string name;

    public void PrintStats()
    {
        Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");
    }

    public void Feed()
    {
        hunger -= 10;
        Console.WriteLine($"Hunger = {hunger}" );
    }
    public void GetAlive()
        {
            if (isAlive == true){
                Console.WriteLine("Den lever!!");
            }

            else 
            {
                Console.WriteLine("Död");
            }
        }

    private void ReduceBoredom()
    {
        boredom -= 10;
    }
    
}





        //Console.WriteLine($"hunger = {hunger} boredom = {boredom}");