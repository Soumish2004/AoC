using System.Linq;
class day2{
    
    static void Main(){
        string input = File.ReadAllText("input.txt");
        Console.WriteLine(input.Split(@"\n\n")[0]);
        string[] list1 = input.Split("\n\n")[0].Split("\n");
        string[] list2 = input.Split("\n\n")[1].Split("\n");
        
    }
}