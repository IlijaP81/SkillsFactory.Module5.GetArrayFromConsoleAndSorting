
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива:");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];
        
        //bool needSorting = false;
        bool needSorting = true;

        ShowArray(GetArrayFromConsole(), needSorting);        
        
        //numbers = DoArraySorting(GetArrayFromConsole(size)); // call with mandatory par
        numbers = DoArraySorting(GetArrayFromConsole()); // call with non-mandatory par

        foreach (int i in numbers) Console.WriteLine(i);
    }

    private static void ShowArray(int[] numbers, bool needSorting = false)
    {
        if (needSorting) numbers = DoArraySorting(numbers);
        foreach (int i in numbers) Console.WriteLine(i);
    }

    private static int[] GetArrayFromConsole(int size = 5) // non-mandatory par
    {
        int[] interimArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Введите {i + 1}-й элемент массива:");
            interimArray[i] = int.Parse(Console.ReadLine());
        }
        return interimArray;
    }

    private static int[] DoArraySorting(int[] arr)
    {
        int max, i = 0, j = arr.Length - 1;
        bool arrayIsSorted = false;

        do
        {
            if (j == 0) arrayIsSorted = true;
            if (i >= 0 & i < arr.Length - 1)
            {
                if (arr[i] > arr[i + 1])
                {
                    max = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = max;
                    arrayIsSorted = false;
                }
                else j--; //  array traversing counter
            }
            else
            {
                i = -1;
                j = arr.Length - 1;
            }
            i++;
        }
        while (!arrayIsSorted);
        return arr;
    }
}