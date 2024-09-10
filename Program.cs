using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        #region I/O and Menu Methods
        #region File To Integer Array
        // takes file path and returns a integer array
        private static int[] FileToIntArray(string file)
        {
            return System.IO.File.ReadAllLines(file).Select(x => int.Parse(x)).ToArray();
        }
        #endregion
        
        #region Option Menu
        //asks for the user to enter keys 1 - 4 so and returns the corresponding integer value
        //and displays a menu in the console for the user to read
        private static int OptionMenu()
        {
            const string optionMenuMessage =
                "┌──────────────────────────────────────┐\n" +
                "│ Press numbered key to select option  │\n" +
                "│   1: Use 256 number files            │\n" +
                "│   2: Use 2048 number files           │\n" +
                "│   3: merge 256 number files (1 & 3)  │\n" +
                "│   4: merge 2048 number files (1 & 3) │\n" +
                "└──────────────────────────────────────┘";

            const string incorrectInputMessage = " Incorrect Input!";

            int[] ValidKeyVals = { 1, 2, 3, 4 };

            ConsoleKeyInfo keyInfo;
            int keyVal = default;
            int option = default;

            while (true)
            {
                Console.WriteLine(optionMenuMessage);

                keyInfo = Console.ReadKey();

                try { keyVal = int.Parse(keyInfo.KeyChar.ToString()); }
                catch { keyVal = 0; }

                if (ValidKeyVals.Contains(keyVal))
                {
                    option = keyVal;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(incorrectInputMessage);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            return option;
        }
        #endregion

        #region File Selection Menu
        //asks for the user to enter keys 1 - 3 so and returns the corresponding integer value
        //and displays a menu for different files in the console for the user to read
        private static int FileMenu()
        {
            const string optionMenuMessage =
                "\n┌────────────────────────────────────────────────────────────┐\n" +
                "│ Press the key of the file you would like to select (1 - 3) │\n" +
                "└────────────────────────────────────────────────────────────┘";
            const string incorrectInputMessage = " Incorrect Input!";

            int[] ValidKeyVals = { 1, 2, 3 };

            ConsoleKeyInfo keyInfo;
            int option = default;
            int keyVal = default;

            while (true)
            {
                Console.WriteLine(optionMenuMessage);

                keyInfo = Console.ReadKey();
                try { keyVal = int.Parse(keyInfo.KeyChar.ToString()); }
                catch { keyVal = 0; }

                if (ValidKeyVals.Contains(keyVal))
                {
                    option = keyVal;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(incorrectInputMessage);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            return option;
        }

        #endregion

        #region Sorting Algorithm Menu
        //asks for the user to enter keys 1 - 4 so and returns the corresponding integer value
        //and displays a menu in the console for the user to read
        private static int SortingAlgorithmMenu()
        {
            const string optionMenuMessage =
                "\n┌────────────────────────────────────────┐\n" +
                "│ Press numbered key to select algorithm │\n" +
                "│   1: Bubble Sort                       │\n" +
                "│   2: Insertion Sort                    │\n" +
                "│   3: Merge Sort                        │\n" +
                "│   4: Quick Sort                        │\n" +
                "└────────────────────────────────────────┘";

            const string incorrectInputMessage = " Incorrect Input!";

            int[] ValidKeyVals = { 1, 2, 3, 4 };

            ConsoleKeyInfo keyInfo;
            int keyVal = default;
            int option = default;

            while (true)
            {
                Console.WriteLine(optionMenuMessage);
                keyInfo = Console.ReadKey();

                try { keyVal = int.Parse(keyInfo.KeyChar.ToString()); }
                catch { keyVal = 0; }

                if (ValidKeyVals.Contains(keyVal))
                {
                    option = keyVal;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(incorrectInputMessage);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.Write("\n");
            return option;
        }
        #endregion

        #region Searching Algorithm Menu
        //asks for the user to enter keys 1 - 4 so and returns the corresponding integer value
        //and displays a menu in the console for the user to read
        private static int SearchingAlgorithmMenu()
        {
            const string optionMenuMessage =
                "\n┌────────────────────────────────────────┐\n" +
                "│ Press numbered key to select algorithm │\n" +
                "│ to perform on sorted array             │\n" +
                "│   1: Linear Search                     │\n" +
                "│   2: Binary Search                     │\n" +
                "└────────────────────────────────────────┘";

            const string incorrectInputMessage = " Incorrect Input!";

            int[] ValidKeyVals = { 1, 2 };

            ConsoleKeyInfo keyInfo;
            int keyVal = default;
            int option = default;

            while (true)
            {
                Console.WriteLine(optionMenuMessage);

                keyInfo = Console.ReadKey();

                try { keyVal = int.Parse(keyInfo.KeyChar.ToString()); }
                catch { keyVal = 0; }

                if (ValidKeyVals.Contains(keyVal))
                {
                    option = keyVal;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(incorrectInputMessage);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            return option;
        }
        #endregion

        #region Get Search Value
        private static int GetSearchValue()
        {
            bool continueLoop = true;
            int value = default;
            while (continueLoop == true)
            {
                Console.Write("\nwhat Number would you like to Search? ");
                try
                {
                    value = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nIncorrect Input!\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            return value;
        }
        #endregion

        #region Print Search Stats
        private static void OutputSearchStats(int f, int l, int n)
        {
            if (n != 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                if (f == l)
                {
                    Console.WriteLine($"position = {f}\n");
                }
                else
                {

                    Console.Write("positions = ");
                    for (int i = f; i <= l; i++)
                    {
                        Console.Write($"{i}" + (i == l ? "" : ", "));
                    }
                    Console.WriteLine($"\nnumber = {n}");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Number Not Located In The Array\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        #endregion
        #region Print Steps
        private static void OutputSteps(int i)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"number of steps taken = {i}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        #endregion
        #endregion

        #region Sorting methods
        #region Bubble Sort
        private static int[] BubbleSort(int[] A)
        {
            int n = A.Length;
            int steps = 0;
            if (n > 1)
            {
                //goes through array untill no more swaps occur
                bool endSort = false;
                while (endSort == false)
                {
                    endSort = true;
                    for (int i = 0; i < n - 1; i++)
                    {
                        //if the item at i is > the item at (i + 1) swap
                        if (A[i] > A[i + 1])
                        {
                            steps++;
                            endSort = false;
                            //swaps values and avoids temp variable using tupples
                            (A[i], A[i + 1]) = (A[i + 1], A[i]);
                        }
                    }
                }
            }
            OutputSteps(steps);
            return A;
        }
        #endregion

        #region Insertion Sort
        private static int[] InsertionSort(int[] A)
        {
            int n = A.Length;
            int steps = 0;
            if (n > 1)
            {
                int j = default;
                int x = default;
                //goes through list
                for (int i = 1; i < n; i++)
                {
                    j = i - 1;
                    x = A[i];
                    //swaps items before j if they are greater than the value at position j
                    while (j >= 0 && A[j] > x)
                    {
                        steps++;
                        A[j + 1] = A[j];
                        j--;
                    }
                    //value originally at i is placed at (j + 1)
                    A[j + 1] = x;
                }
            }
            OutputSteps(steps);
            return A;
        }
        #endregion

        #region Merge Sort
        private static int[] MergeOnly(int[] TempA)
        {
            //creates variables for start middle and end of the list
            int l = 0;
            int r = TempA.Length - 1;
            int m = (l + r) / 2;

            //creates two arrays left and right of the middle (m) of the sub array
            int[] L = new int[m - l + 1];
            int[] R = new int[r - m];
            Array.Copy(TempA, l, L, 0, m - l + 1);
            Array.Copy(TempA, m + 1, R, 0, r - m);

            //goes through the two sub arrays (L & R) and merges them
            int i = 0; int j = 0;
            for (int k = l; k < r + 1; k++)
            {
                if (i == L.Length)      { TempA[k] = R[j]; j++; }
                else if (j == R.Length) { TempA[k] = L[i]; i++; }
                else if (L[i] <= R[j])  { TempA[k] = L[i]; i++; }
                else                    { TempA[k] = R[j]; j++; }
            }
            TempA = L.Concat<int>(R).ToArray<int>();
            return TempA;
        }
        private static int[] MergeSort(int[] A)
        {
            int steps = 0;
            void Merge(int[] TempA, int l, int m, int r)
            {
                //creates two arrays left and right of the middle (m) of the sub array
                int[] L = new int[m - l + 1];
                int[] R = new int[r - m];
                Array.Copy(TempA, l, L, 0, m - l + 1);
                Array.Copy(TempA, m + 1, R, 0, r - m);

                //goes through the two sub arrays (L & R) and merges them
                int i = 0; int j = 0;
                for (int k = l; k < r + 1; k++)
                {
                    steps++;
                    if (i == L.Length)      { TempA[k] = R[j]; j++; }
                    else if (j == R.Length) { TempA[k] = L[i]; i++; }
                    else if (L[i] <= R[j])  { TempA[k] = L[i]; i++; }
                    else                    { TempA[k] = R[j]; j++; }
                }
            }

            void Sort(int[] TempA, int l, int r)
            {
                if (l < r)
                {
                    int m = (l + r) / 2;
                    //Sorts the subrray to the Left
                    Sort(TempA, l, m);
                    steps++;
                    //sorts the subrray to the right
                    Sort(TempA, m + 1, r);
                    steps++;
                    //merges the two arrays
                    Merge(TempA, l, m, r);
                    steps++;
                }
            }

            Sort(A, 0, (A.Length - 1));
            OutputSteps(steps);
            return A;
        }
        #endregion

        #region Quicksort
        private static int[] QuickSort(int[] A)
        {
            int steps = 0;
            int Partition(int[] TempA, int l, int r)
            {
                int pointer = l - 1;
                int pivot = TempA[r];

                for (int i = l; i < r; i++)
                {
                    steps++;
                    if (TempA[i] <= pivot)
                    {
                        pointer++;
                        (TempA[pointer], TempA[i]) = (TempA[i], TempA[pointer]);
                    }
                }
                (TempA[pointer + 1], TempA[r]) = (TempA[r], TempA[pointer + 1]);

                return (pointer + 1);
            }
            int[] Sort(int[] TempA, int l, int r)
            {
                if (l < r)
                {
                    int pointer = Partition(TempA, l, r);
                    steps++;
                    Sort(TempA, l, pointer - 1);
                    steps++;
                    Sort(TempA, pointer + 1, r);
                    steps++;
                }
                return TempA;
            }
            A = Sort(A, 0, (A.Length - 1));
            OutputSteps(steps);
            return A;
        }
        #endregion
        #endregion

        #region Searching methods
        #region Linear Search
        private static (int, int, int) LinearSearch(int[] A, int val)
        {
            
            int num = 0;
            int l = -1;
            int r = -1;
            bool found = false;
            int steps = 0;

            List<int> Positions = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == val)
                {
                    Positions.Add(i);
                    found = true;
                }
                steps++;
            }

            if (found == true)
            {
                l = Positions.Min();
                r = Positions.Max();
                num = r - l + 1;
                steps++;
            }
            OutputSteps(steps);
            return (l, r, num);
        }
        #endregion

        #region Binary Search
        private static (int, int, int) BinarySearch(int[] A, int val)
        {
            int low = 0;
            int high = A.Length - 1;
            int mid = default;
            int steps = 0;

            bool found = false;

            while (low <= high)
            {
                steps++;
                mid = (low + high) / 2;
                if (A[mid] > val)       { high = mid - 1; }
                else if (A[mid] < val)  { low = mid + 1; }
                else                    { found = true; break; }
            }

            int l = -1;
            int r = -1;
            int num = 0;

            if (found == true)
            {
                int i = mid;
                while (i >= 0 && A[i] == val)
                {
                    steps ++;
                    i--;
                }
                l = i + 1;

                i = mid;
                while (i <= high && A[i] == val)
                {
                    steps++;
                    i++;
                }
                r = i - 1;

                num = r - l + 1;
            }
            OutputSteps(steps);
            return (l, r, num);
        }
        #endregion

        #region Closest Value
        private static int ClosestValue(int[] A, int val)
        {
            if (val < A.Min())
            {
                return A[0];
            }
            else if (val > A.Max())
            {
                return A[A.Length - 1];
            }
            else
            {
                int[] Diff = new int[A.Length];
                Array.Copy(A, Diff, A.Length);
                for(int i = 0; i < A.Length; i++)
                {
                    Diff[i] = Math.Abs(A[i] - val);
                }
                int min = Diff.Max();
                int pos = 0;
                for(int i = 0; i < A.Length; i++)
                {
                    if (Diff[i] < min)
                    {
                        min = Diff[i];
                        pos = i;
                    }
                }
                return A[pos];
            }
        }
        #endregion
        #endregion

        #region Main
        static void Main()
        {
            //creates empty arrays (1 - 3) and a chosen array and increment value used in display
            int[] Array1, Array2, Array3 = Array.Empty<int>();
            int[] ChosenArray = Array.Empty<int>();
            int inc = default;

            //switches between different options (1 - 4) from brief, outputted from option menu method
            switch (OptionMenu())
            {
                case 1:
                    //integer arrays taken from 256 number files
                    Array1 = FileToIntArray($"Share_1_256.txt");
                    Array2 = FileToIntArray($"Share_2_256.txt");
                    Array3 = FileToIntArray($"Share_3_256.txt");
                    //switches between different options (1 - 3) corresponding to arrays, outputted from file selection menu method
                    switch (FileMenu())
                    {
                        case 1:
                            ChosenArray = Array1;
                            break;
                        case 2:
                            ChosenArray = Array2;
                            break;
                        case 3:
                            ChosenArray = Array3;
                            break;
                    }
                    inc = 10;
                    break;

                case 2:
                    //integer arrays taken from 2048 number files
                    Array1 = FileToIntArray($"Share_1_2048.txt");
                    Array2 = FileToIntArray($"Share_2_2048.txt");
                    Array3 = FileToIntArray($"Share_3_2048.txt");
                    //switches between different options (1 - 3) corresponding to arrays, outputted from file selection menu method
                    switch (FileMenu())
                    {
                        case 1:
                            ChosenArray = Array1;
                            break;
                        case 2:
                            ChosenArray = Array2;
                            break;
                        case 3:
                            ChosenArray = Array3;
                            break;
                    }
                    inc = 50;
                    break;

                case 3:
                    //integer arrays taken from 256 number files (1 & 3)
                    Array1 = FileToIntArray($"Share_1_256.txt");
                    Array3 = FileToIntArray($"Share_3_256.txt");
                    //concatinates & merges arrays (1 & 3)
                    ChosenArray = MergeOnly(Array1.Concat(Array3).ToArray());
                    inc = 10;
                    break;

                case 4:
                    //integer arrays taken from 256 number files (1 & 3)
                    Array1 = FileToIntArray($"Share_1_2048.txt");
                    Array3 = FileToIntArray($"Share_3_2048.txt");
                    //concatinates arrays (1 & 3)
                    ChosenArray = MergeOnly(Array1.Concat(Array3).ToArray());
                    inc = 50;
                    break;
            }

            int l = ChosenArray.Length;

            int[] SortedArray = new int[l];
            Array.Copy(ChosenArray, SortedArray, l);

            //switches between different sorting algorithms 
            switch (SortingAlgorithmMenu())
            {
                case 1:
                    //Bubble Sort
                    SortedArray = BubbleSort(ChosenArray);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    for (int i = 0; i < l; i += inc)
                    {
                        Console.Write($"{i}: {SortedArray[i]}, ");
                    }
                    Console.WriteLine("\n");
                    for (int i = 0; i < l; i += inc)
                    {
                        Console.Write($"{i}: {SortedArray[(l - 1) - i]}, ");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 2:
                    //Insertion Sort
                    SortedArray = InsertionSort(ChosenArray);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    for (int i = 0; i < l; i += inc)
                    {
                        Console.Write($"{i}: {SortedArray[i]}, ");
                    }
                    Console.WriteLine("\n");
                    for (int i = 0; i < l; i += inc)
                    {
                        Console.Write($"{i}: {SortedArray[(l - 1) - i]}, ");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 3:
                    //Merge Sort
                    SortedArray = MergeSort(ChosenArray);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    for (int i = 0; i < l; i += inc)
                    {
                        Console.Write($"{i}: {SortedArray[i]}, ");
                    }
                    Console.WriteLine("\n");
                    for (int i = 0; i < l; i += inc)
                    {
                        Console.Write($"{i}: {SortedArray[(l - 1) - i]}, ");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 4:
                    //Quick Sort
                    SortedArray = QuickSort(ChosenArray);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    for (int i = 0; i < l; i += inc)
                    {
                        Console.Write($"{i}: {SortedArray[i]}, ");
                    }
                    Console.WriteLine("\n");
                    for (int i = 0; i < l; i += inc)
                    {
                        Console.Write($"{i}: {SortedArray[(l - 1) - i]}, ");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
            Console.Write("\n");
            int first = default;
            int last = default;
            int number = default;
            int searchVal = default;
            int closestValue = default;
            switch (SearchingAlgorithmMenu())
            {
                case 1:
                    searchVal = GetSearchValue();
                    (first, last, number) = LinearSearch(SortedArray, searchVal);
                    if (number >= 1)
                    {
                        OutputSearchStats(first, last, number);
                    }
                    else
                    {
                        closestValue = ClosestValue(SortedArray, searchVal);
                        Console.WriteLine($"Closest value is {closestValue}");
                        (first, last, number) = LinearSearch(SortedArray, closestValue);
                        OutputSearchStats(first, last, number);
                    }
                    break;

                case 2:
                    searchVal = GetSearchValue();
                    (first, last, number) = BinarySearch(SortedArray, searchVal);
                    if (number >= 1)
                    {
                        OutputSearchStats(first, last, number);
                    }
                    else
                    {
                        closestValue = ClosestValue(SortedArray, searchVal);
                        Console.WriteLine($"Closest value is {closestValue}");
                        (first, last, number) = BinarySearch(SortedArray, closestValue);
                        OutputSearchStats(first, last, number);
                    }
                    break;
            }
        }
        #endregion
    }
}
