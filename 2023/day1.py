if __name__ == '__main__':
    with open('inputs/day1.txt', 'r') as inputFile:
        input = inputFile.read().split('\n')
    
    #part 1
    sum=0
    for element in input:
        ans = list(filter(str.isdigit,element))
        sum = sum + int(ans[0])*10 + int(ans[-1])
    print("Part 1")
    print(sum)

    #part2
    filter_terms = {"zero":"ze0o", "one":"o1e", "two":"t2o", "three":"th3ee", "four":"f4ur", "five":"fi5ve", "six":"s6x", "seven":"se7en", "eight":"ei8ght", "nine":"n9ne"}
    sum=0
        
    for element in input:
        for word, num in filter_terms.items():
             element = element.replace(word,num)
        ans = list(filter(str.isdigit,element))
        sum = sum + int(ans[0])*10 + int(ans[-1])

    print("Part 2")
    print(sum)

