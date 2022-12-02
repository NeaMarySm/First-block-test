# Контрольная работа к блоку 1

## Задача

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше либо равна трем символам. 

***

## Описание решения

1. Считаем количество элементов в исходном массиве, удовлетворяющих условию, поставленному в задаче (**длина меньше либо равна трем символам**). 

	Для этого я создала метод, который принимает исходный массив и максимальное количество символов, которое может быть в элементе массива.

		int CountNSymbolsStrings(string[] array, int numberOfSymbols)
		{
			int count = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Length <= numberOfSymbols) count++;
			}
			return count;
		}

2. Создаем новый массив с длиной, полученной в предыдущем пункте. Снова проходим циклом по исходному массиву и записываем в новый элементы, удовлетворяющие поставленному условию. Получаем новый массив соответствующий поставленной задаче. 	
	Это я также вынесла в отдельный метод, возвращающий новый массив:

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


