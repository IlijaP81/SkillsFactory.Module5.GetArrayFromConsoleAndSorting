
using System.Drawing;
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

        ShowArray(GetArrayFromConsole(ref size), needSorting); // call with ref par        
        
        //numbers = DoArraySorting(GetArrayFromConsole(size)); // call with mandatory par
        //numbers = DoArraySorting(GetArrayFromConsole()); // call with non-mandatory par

        //foreach (int i in numbers) Console.WriteLine(i);
    }

    private static void ShowArray(int[] numbers, bool needSorting = false)
    {
        int[] sortedasc = new int[numbers.Length];
        int[] sorteddesc = new int[numbers.Length];


        if (needSorting)
        {
            numbers = DoArraySorting(numbers, out sortedasc, out sorteddesc);

            Console.WriteLine("Первоначальный массив:");
            foreach (int i in numbers) Console.WriteLine(i);

            Console.WriteLine("Сортировка по возрастанию:");
            foreach (int i in sortedasc) Console.WriteLine(i);

            Console.WriteLine("Сортировка по убыванию:");
            foreach (int i in sorteddesc) Console.WriteLine(i);
        }
    }

    //private static int[] GetArrayFromConsole(int size = 5) // non-mandatory par
    private static int[] GetArrayFromConsole(ref int size)
    {
        size = 4;
        int[] interimArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Введите {i + 1}-й элемент массива:");
            interimArray[i] = int.Parse(Console.ReadLine());
        }
        return interimArray;
    }

    private static int[] DoArraySorting(int[] arr, out int[] sortedasc, out int[] sorteddesc)
    {
        int[] arrCopy1 = new int[arr.Length];
        Array.Copy(arr, arrCopy1, arr.Length);

        int[] arrCopy2 = new int[arr.Length];
        Array.Copy(arr, arrCopy2, arr.Length);

        sortedasc = DoArraySortingAscending(arrCopy1);
        sorteddesc = DoArraySortingDescending(arrCopy2);
        //int max, i = 0, j = arr.Length - 1;
        //bool arrayIsSorted = false;

        //do
        //{
        //    if (j == 0) arrayIsSorted = true;
        //    if (i >= 0 & i < arr.Length - 1)
        //    {
        //        if (arr[i] > arr[i + 1])
        //        {
        //            max = arr[i];
        //            arr[i] = arr[i + 1];
        //            arr[i + 1] = max;
        //            arrayIsSorted = false;
        //        }
        //        else j--; //  array traversing counter
        //    }
        //    else
        //    {
        //        i = -1;
        //        j = arr.Length - 1;
        //    }
        //    i++;
        //}
        //while (!arrayIsSorted);
        return arr;
    }

    private static int[] DoArraySortingAscending(int[] arr)
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

    private static int[] DoArraySortingDescending(int[] arr)
    {
        int min, i = 0, j = arr.Length - 1;
        bool arrayIsSorted = false;

        do
        {
            if (j == 0) arrayIsSorted = true;
            if (i >= 0 & i < arr.Length - 1)
            {
                if (arr[i] < arr[i + 1])
                {
                    min = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = min;
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