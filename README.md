# QuickSort

The given code is an implementation of the Quick Sort algorithm in C#. 
 The code first prompts the user to enter the size of the array. It checks if the input is a valid integer and creates an array of that size. Then, it prompts the user to enter the elements of the array. For each element, it checks if the input is a valid integer and assigns it to the corresponding index in the array. If the input is not a valid integer, it displays an error message and prompts the user to enter a valid integer again.
 After the array is populated, the code prints the original array. Then, it calls the QuickSortAlgorithm method, passing the array, the starting index (0), and the ending index (array.Length - 1). The QuickSortAlgorithm method implements the Quick Sort algorithm recursively. It first checks if the low index is less than the high index. If so, it finds the partition index using the Partition method, which selects a pivot element and rearranges the elements in the array such that all elements less than the pivot are on the left and all elements greater than the pivot are on the right. Then, it recursively calls the QuickSortAlgorithm method on the subarrays before and after the partition index.
 The Partition method takes the array, the low index, and the high index as parameters. It selects the pivot element as the last element in the array. It initializes a variable i to the low index - 1. It then iterates over the array from the low index to the high index - 1. If an element is less than the pivot, it increments i and swaps the element with the element at index i. Finally, it swaps the pivot element with the element at index i + 1 and returns i + 1 as the partition index.
 The Swap method is a helper method that takes the array and two indices as parameters. It swaps the elements at the given indices in the array.
 Overall, the code prompts the user to enter an array, sorts the array using the Quick Sort algorithm, and then prints the sorted array.
