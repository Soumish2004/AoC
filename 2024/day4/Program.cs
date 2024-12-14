class day4{
    static int part1(List<List<char>> tot){
        int c = 0;
        for(int i=0;i<tot.Count;i++){
            for(int j=0;j<tot[i].Count;j++){
                if(tot[i][j] == 'X'){
                    if (i - 3 >= 0)
                        if (tot[i - 1][j] == 'M' && tot[i - 2][j] == 'A' && tot[i - 3][j] == 'S')
                            c++;
                    if (i + 3 < tot.Count)
                        if (tot[i + 1][j] == 'M' && tot[i + 2][j] == 'A' && tot[i + 3][j] == 'S')
                            c++;
                    if (j - 3 >= 0)
                        if (tot[i][j - 1] == 'M' && tot[i][j - 2] == 'A' && tot[i][j - 3] == 'S')
                            c++;
                    if (j + 3 < tot[i].Count)
                        if (tot[i][j + 1] == 'M' && tot[i][j + 2] == 'A' && tot[i][j + 3] == 'S')
                            c++;
                    if (i - 3 >= 0 && j - 3 >= 0)
                        if (tot[i - 1][j - 1] == 'M' && tot[i - 2][j - 2] == 'A' && tot[i - 3][j - 3] == 'S')
                            c++;
                    if (i + 3 < tot.Count && j + 3 < tot[i].Count)
                        if (tot[i + 1][j + 1] == 'M' && tot[i + 2][j + 2] == 'A' && tot[i + 3][j + 3] == 'S')
                            c++;
                    if (i - 3 >= 0 && j + 3 < tot[i].Count)
                        if (tot[i - 1][j + 1] == 'M' && tot[i - 2][j + 2] == 'A' && tot[i - 3][j + 3] == 'S')
                            c++;
                    if (i + 3 < tot.Count && j - 3 >= 0)
                        if (tot[i + 1][j - 1] == 'M' && tot[i + 2][j - 2] == 'A' && tot[i + 3][j - 3] == 'S')
                            c++;
                }
            }
        }
        return c;
    }
    static int part2(List<List<char>> tot){
        int c = 0;
        for(int i=0;i<tot.Count;i++){
            for(int j=0;j<tot[i].Count;j++){
                if(tot[i][j] == 'M'){
                    if( j+2 < tot[i].Count && tot[i][j+2] == 'M'){
                        if(i+2 < tot.Count && tot[i+1][j+1] == 'A' && tot[i+2][j] == 'S' && tot[i+2][j+2] == 'S')
                            c++;
                        if(i-2 >= 0 && tot[i-1][j+1] == 'A' && tot[i-2][j] == 'S' && tot[i-2][j+2] == 'S')
                            c++;
                    }
                    if( i+2 < tot.Count && tot[i+2][j] == 'M'){
                        if(j+2 < tot[i].Count && tot[i+1][j+1] == 'A' && tot[i][j+2] == 'S' && tot[i+2][j+2] == 'S')
                            c++;
                        if(j-2 >= 0 && tot[i+1][j-1] == 'A' && tot[i][j-2] == 'S' && tot[i+2][j-2] == 'S')
                            c++;
                    }
                }
            }
        }
        return c;
                    
    }
    static void Main(){
        string input = File.ReadAllText("input.txt");
        string[] lines = input.Split("\n");
        List<List<char>> tot = lines.Select(x=>x.ToCharArray().ToList()).ToList();
        
        Console.WriteLine(part1(tot));
        Console.WriteLine(part2(tot));
    }
}