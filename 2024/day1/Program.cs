using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class day1{
    static void Main(){
        string input = File.ReadAllText("input.txt");

        input = Regex.Replace(input,@"\s+", " ");
        input = Regex.Replace(input,@"\n", " ");
        string[] list = input.Split(" ");
        int[] list1 = new int[list.Length/2];
        int[] list2 = new int[list.Length/2];
        int l1c=0, l2c=0;
        for(int i = 0; i<list.Length; i++){
            if(i%2 == 0){
                list1[l1c] = int.Parse(list[i]);
                l1c++;
            }else{
                list2[l2c] = int.Parse(list[i]);
                l2c++;
            }
        }
        int part1 = 0;
        Array.Sort(list1);
        Array.Sort(list2);
        var zipp = list1.Zip(list2, (a,b) => new {a,b});
        foreach(var i in zipp){
            part1 += Math.Abs(i.a - i.b);
        } 
        Console.WriteLine(part1);
        

        int part2 = 0;
        Dictionary<int,int> help = new Dictionary<int,int>();

        foreach(var i in list1){
            if(help.ContainsKey(i)){
                part2 += i*help[i];
            }
            else{
                help.Add(i,list2.Count(x => x == i));
                part2 += i*help[i];
            }
        } 
        Console.WriteLine(part2);
    }
}