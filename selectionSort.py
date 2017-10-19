def selectionSort(arr):
    size = len(arr)
    for i in range(0, size-1):
        largestIndex = 0
        for j in range(1, size-i):
            if(arr[j] > arr[largestIndex]):
                largestIndex = j
        lastIndex = size - i - 1
        if(largestIndex != lastIndex):
            arr[largestIndex], arr[lastIndex] = arr[lastIndex], arr[largestIndex]
    return arr

my_array = [26, 54, 93, 17, 77, 31, 44, 55, 100, 20, 100]
my_array = selectionSort(my_array)

for x in my_array:
    print(x)
