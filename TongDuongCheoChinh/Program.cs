using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongDuongCheoChinh
{
    internal class Program
    {
        static bool IsSquareMatrix(int[,] array)
        {
            int numRows = array.GetLength(0);
            int numCols = array.GetLength(1);

            return numRows == numCols;
        }

        static int TinhTongDuongCheo(int[,] array)
        {
            int numRows = array.GetLength(0);
            int duongCheoChinh = 0;
            for (int i = 0; i < numRows;i++)
            {
                duongCheoChinh += array[i,i];
            }
            return  duongCheoChinh;
        }
        static void Main(string[] args)
        {
            int[,] array =
            {
                {1,2,4,5},
                {2,5,8,8},
                {6,9,3,19},
                {7,8,9,10},
            };
            // hien thi ma tra tren man hinh
            Console.WriteLine("Ma trận:");
            //getlength(0) la cho chieu thu nhat
            //getlength(1) cho chieu thu hai
            //getlength(2) cho chieu thu ba
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // kiem tra ma tran co phai la ma tran vuong hay khong
            //neu khong thi thong bao ma
            if (IsSquareMatrix(array)==false)
            {
                Console.WriteLine("Day khong phai ma tran vuong: ");
            }
            //neu dung thi tinh duong cheo chinh cua ma tran
            else
            {
                int tinhTong = TinhTongDuongCheo(array);
                Console.WriteLine("Tong duong cheo chinh la: " + tinhTong);
            }
            
        }
    }
}
