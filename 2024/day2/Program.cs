using System.Linq;
class day2{
    static bool works(List<int> list){
        bool inc = Enumerable.Range(0,list.Count-1).All(i => list[i] <= list[i+1]);
        bool dec = Enumerable.Range(0,list.Count-1).All(i => list[i] >= list[i+1]);
        if (!(inc || dec))
            return false;
        for(int i = 0; i<list.Count-1; i++){
            int d = Math.Abs(list[i] - list[i+1]);
            if(d>3 || d<1)
                return false;
        }
        return true;
    }
    static int part1(List<List<int>> list2){
        int c=0;
        foreach(var i in list2){
            if(works(i))
                c++;
        }
        return c;
    }
    static int part2(List<List<int>> list2){
        int c=0;
        foreach(var i in list2){
            if(works(i))
                c++;
            else{
                for(int t = 0; t<i.Count; t++){
                    List<int> temp = new List<int>(i);
                    temp.RemoveAt(t);
                    if(works(temp)){
                        c++;
                        break;
                    }
                }
            }
        }
        return c;
    }
    static void Main(){
        string input = File.ReadAllText("input.txt");
        string[] list1 = input.Split("\n");
        List<List<int>> list2 = list1.Select(x => x.Split(" ").Select(int.Parse).ToList()).ToList();
        Console.WriteLine(part1(list2));
        Console.WriteLine(part2(list2));
    }
}