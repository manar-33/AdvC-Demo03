namespace AdvC_Demo03
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //int[] Numbers = { 10, 5, 44, 8, 3, 7, 22, 65, 9 };


            //SortingAlgorithms.BubbleSort(Numbers, CompareFunctions.CompareGtr);
            //foreach (var item in Numbers)
            //{
            //    Console.Write($" { item}");
            //}
            //Console.WriteLine("=========================");
            //SortingAlgorithms.BubbleSort(Numbers , CompareFunctions.CompareLess);
            //foreach (var item in Numbers)
            //{
            //    Console.Write(item+" ");
            //}

            StringsFuncDelegate X = StringsFunction.GetCountOfUpperCaseChar;
            X += StringsFunction.GetCountOfLowerCaseChar;
            int Result = X.Invoke("Hello World");
            Console.WriteLine(Result);
            Predicate<int> predicate = StringsFunction.GetCountOfLowerCaseChar;
        }
    }
    
}
