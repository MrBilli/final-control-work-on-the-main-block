// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
//  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void ShowArray(string[] array)
{
    Console.WriteLine("Вы ввели массив:");
    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
    Console.WriteLine("");
}

// 1. Создаём метод CreateArrayOfStrings.
// Метод ничего не принимает на вход и возвращает массив, заполненный количеством элементов типа string, 
// указанным внутри метода.
// Пользователь вводит количество элементов, а потом поочерёдно вводит каждый элемент. 

string[] CreateArrayOfStrings()
{
    Console.WriteLine("Введите желаемое количество элементов массива числом больше 0:");
    int length = Convert.ToInt32(Console.ReadLine());
        if(length > 0)
        {   
            string[] array = new string[length];
                for(int i = 0; i < length; i++)
                {
                    Console.WriteLine($"Введите элемент массива №{i + 1}:");
                    array[i] = Console.ReadLine();
                }
            ShowArray(array);
            return array;
        }
        else 
        {
            Console.WriteLine("НУЖНО ВВЕСТИ ЧИСЛО БОЛЬШЕ 0! ПОПРОБУЙТЕ ЕЩЁ РАЗ.");
            return CreateArrayOfStrings();
        }
}

// 2. Создаём метод NumberOfElementsThreeCharactersLong.
// Метод принимает на вход массив и возвращает количество элементов в массиве, длина которых менее или равна 3-ем символам.

int NumberOfElementsThreeCharactersLong(string[] array)
{
    int count = 0;
        for(int i = 0; i < array.Length; i++)
            if(array[i].Length <= 3)
                count ++;
    Console.WriteLine($"В массиве есть {count} элемента(ов), длина которых менее или равна 3-ем символам.");
    return count;
}

// 3. Создаём метод ArrayOfElementsThreeCharactersLong.
// Метод принимает на вход массив и количество элементов нового массива, возвращает новый массив.
// Внутри поочерёдно проверяется каждый элемент принятого массива, и те, которые имеют длину до 3-х символов включительно,
//  становятся элементами нового массива.

string[] ArrayOfElementsThreeCharactersLong(string[] array, int size)
{
    Console.WriteLine($"Элементы массива, которые имеют длину до 3-х символов включительно(новый массив):");
    string[] arrayNew = new string[size];
        for(int i = 0,j = 0; i < array.Length; i++)
            if(array[i].Length < 4)
            {
                arrayNew[j] = array[i];
                Console.Write($"{arrayNew[j]} ");
                j =+ 1;
            }
    return arrayNew;
}

string[] arrayOfStrings = CreateArrayOfStrings();

int countOfElementsLenghtLessFour = NumberOfElementsThreeCharactersLong(arrayOfStrings);

string[] arrayWithElementsLenghtLessFour = ArrayOfElementsThreeCharactersLong(arrayOfStrings, countOfElementsLenghtLessFour);

