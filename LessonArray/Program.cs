namespace LessonArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrLength = GetLengthArray();
            int[] numbers = new int[arrLength];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (i + i) * i / 3;
            }

            int[] newArr = new int[numbers.Length + 5];
            numbers.CopyTo(newArr, 0);

            foreach (var n in newArr)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();

            newArr[0] = 777;
            Console.WriteLine($"newArr[0] = {newArr[0]} ,numbers[0] = {numbers[0]}");



            decimal[,] materials = new decimal[3, 2]
            {
                { 5, 4 },
                {3, 7},
                {2, 6}
            };

            decimal[] costMaterials = { 70, 50 };

            decimal[] totalTiles = { 80, 140, 60 };

            decimal[] priceOneTile = new decimal[3]; 

            for (int i = 0; i < materials.GetLength(0); i++)
            {
                for (int j = 0; j < materials.GetLength(1); j++)
                {
                    priceOneTile[i] += materials[i, j] * costMaterials[j] ;
                }
            }
            foreach (var n in priceOneTile)
            {
                Console.WriteLine(n);
            }
            decimal totalCost = default;

            for ( int i =0; i < priceOneTile.Length; i++)
            {
                totalCost += priceOneTile[i] * totalTiles[i];
            }

            Console.WriteLine( $"Total price: {totalCost}");
        }


        static int GetLengthArray()
        {
            int value = default;
            while (true)
            {
                Console.Write("Enter length array: ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    value = result;
                    break;
                }
                else
                {
                    
                    Console.WriteLine("Not correct value, try again");
                }
            }
            return value;
        }
    }
}
