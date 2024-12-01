import re

with open('inputs/day3.txt') as inputFile:
    input = inputFile.read().split()

scheme = ['.' * (len(input[0]) + 2)] * 2
scheme[1:1] = map(".{}.".format, input)
total_sum = 0

for index, row in enumerate(scheme[1:-1], 1):
    for number in re.finditer(r'\d+', row):
        start, stop = number.span()
        for section in scheme[index - 1:index + 2]:
            if re.sub(r'[\d\.]', '', section[start - 1:stop + 1]):
                total_sum += int(number.group())
                break

print(total_sum)