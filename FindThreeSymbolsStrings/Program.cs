int N = 3;

string[] initialArray1 = { "hello", "2", "world", ":-)" };
string[] initialArray2 = { "124", "1567", "-2", "computer science" };
string[] initialArray3 = { "Russia", "Denmark", "Kazan" };

string[] resultArray1 = CreateNewArrayWithNSymbolsStrings(initialArray1, N);
string[] resultArray2 = CreateNewArrayWithNSymbolsStrings(initialArray2, N);
string[] resultArray3 = CreateNewArrayWithNSymbolsStrings(initialArray3, N);

PrintArray(resultArray1);
PrintArray(resultArray2);
PrintArray(resultArray3);

int CountNSymbolsStrings(string[] array, int numberOfSymbols)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= numberOfSymbols) count++;
	}
	return count;
}
string[] CreateNewArrayWithNSymbolsStrings(string[] array, int numberOfSymbols)
{
	int size = CountNSymbolsStrings(array, numberOfSymbols);
	string[] resultArray = new string[size];
	int j = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= numberOfSymbols)
		{
			resultArray[j] = array[i];
			j++;
		}
	}
	return resultArray;
}

void PrintArray(string[] array)
{
	foreach (string elem in array)
	{
		Console.Write(elem + " ");
	}
	Console.WriteLine();
}