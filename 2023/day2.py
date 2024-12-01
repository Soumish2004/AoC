import re
if __name__ == '__main__':
    with open("inputs/day2.txt","r") as inputFile:
        input = inputFile.read().split("\n")
    
    a=1
    sum1=0
    sum2=0
    for line in input:
        matches = re.findall(r'(\d+) (\w+)', line)
        ch=1
        color_count = ["red", "blue", "green"]
        color_ball = {color: 0 for color in color_count}
        for match in matches:
            count, color = match
            
            #part1
            if color == 'red':
                if int(count) > 12:
                    ch=-1
            elif color == 'blue':
                if int(count) > 14:
                    ch=-1
            elif color == 'green':
                if int(count) > 13:
                    ch=-1
            
            #part2
            if color_ball[color] < int(count):
                color_ball[color] = int(count)

        if ch == 1:
            sum1+=a
        a+=1
        sum2+= color_ball["red"] * color_ball["blue"] * color_ball["green"]

    print("Part1")
    print(sum1)
    print("Part2")
    print(sum2)

