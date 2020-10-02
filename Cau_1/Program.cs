using System;
using System.Text;
namespace Cau1
{
    class Program
    {
        static void CreateMatrix(ref int[,] A, ref int d, ref int c)
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < d * c; i++)
            {
                Console.Write("Nhập theo thứ tự hàng -> cột[{0}][{1}] :", i / c, i % c);
                A[i / c, i % c] = int.Parse(Console.ReadLine());
            }
        }
        static void Show(int[,] A, int d, int c)
        {
            for (int i = 0; i < d * c; i++)
            {
                Console.Write("{0}   ", A[i % c, i / c]);
                if ((i + 1) % c == 0)
                {
                    Console.Write("\n");
                }
            }
        }
        static void Sum(int[,] A, int d, int c)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int tong = 0;
            for (int i = 0; i < d * c; i++)
            {
                tong += A[i / c, i % c];
                if ((i + 1) % c == 0)
                {
                    Console.WriteLine("Nhập mảng cần tính tổng: ");
                    c = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Tổng mảng {0} là: {1}", i / c, tong);
                    tong = 0;
                    break;
                }
            }
        }
        static void ShowMaxRow(int[,] A, int d, int c)
        {
            int maxRow = 0;
            int Max = 0;
            for (d = 0; d < A.GetLength(0); d++)
            {
                maxRow += A[d, 0];
            }
            for (d = 1; d < A.GetLength(0); d++)
            {
                int SumRow = 0;
                for (c = 0; c < A.GetLength(1); c++)
                {
                    SumRow += A[d, c];
                    if (SumRow > maxRow)
                    {
                        maxRow = SumRow;
                        Max = d + 1;
                    }
                }
            }
            Console.WriteLine($"Hàng {Max} có tổng lớn nhất = {maxRow} có phần tử: ");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] A = new int[10, 50];
            int d, c;
            do
            {
                Console.WriteLine("Nhập số hàng :");
                d = int.Parse(Console.ReadLine());
                if (d <= 0)
                {
                    Console.WriteLine("Số hàng không hợp lệ, nhập lại");
                }
            } while (d <= 0);
            do
            {
                Console.WriteLine("Nhập số cột :");
                c = int.Parse(Console.ReadLine());
                if (c <= 0)
                {
                    Console.WriteLine("Số cột không hợp lệ, nhập lại");
                }
            } while (c <= 0);
            CreateMatrix(ref A, ref d, ref c);
            Show(A, d, c);
            Sum(A, d, c);
            ShowMaxRow(A, d, c);
            Console.ReadLine();
        }
    }
}