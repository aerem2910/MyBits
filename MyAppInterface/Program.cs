namespace MyAppInterface
{
    class Program
    {
        static void Main()
        {
            // Пример для long
            long longValue = 1234567890123456789;
            Bits bitsFromLong = longValue.ToBits(); // Используем метод расширения

            // Пример для int
            int intValue = 42;
            Bits bitsFromInt = intValue.ToBits(); // Используем метод расширения

            // Пример для byte
            byte byteValue = 255;
            Bits bitsFromByte = byteValue.ToBits(); // Используем метод расширения

            // Выводим результаты
            Console.WriteLine($"Bits from long: {bitsFromLong.Value}");
            Console.WriteLine($"Bits from int: {bitsFromInt.Value}");
            Console.WriteLine($"Bits from byte: {bitsFromByte.Value}");
        }
    }

}