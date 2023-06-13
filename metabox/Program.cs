using System.Text;
using System;
namespace Basic
{
    class Program
    {
        static void Main()
        {
            Console.Write("Nhập kích thước mảng: ");
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Nhập giá trị cho phần tử thứ {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine("Các giá trị trong mảng:");
            foreach (int number in numbers)
            {
                Console.WriteLine(numbers);
            }
        }

    }
}