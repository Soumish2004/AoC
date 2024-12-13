using System.Text.RegularExpressions;
class day3{
    static int calc(string a){
        int i = a.IndexOf(',');

        var n1 = int.Parse(a.Substring(4,i-4));
        var n2 = int.Parse(a.Substring(i+1,a.Length-i-2));
        return n1*n2;
    }
    static int part1(MatchCollection ans){
        var s=0;
        foreach(var i in ans){
            s+=calc(i.ToString());
        }
        return s;
    }
    static int part2(MatchCollection ans){
        var s=0;
        var d=1;
        foreach(var j in ans){
            var i = j.ToString();
            if (i == "do()"){
                d=1;
                continue;
            }
            else if(i == "don't()"){
                d=0;
                continue;
            }
            if(d==1)
                s+=calc(i);
        }
        return s;
    }
    static void Main(){
        string input = File.ReadAllText("input.txt");
        var ans1 = Regex.Matches(input, @"mul\((\d+),(\d+)\)");
        Console.WriteLine(part1(ans1));
        var ans2 = Regex.Matches(input, @"mul\(\d{1,3},\d{1,3}\)|\bdo\(\)|\bdon't\(\)");
        Console.WriteLine(part2(ans2));
    }
}