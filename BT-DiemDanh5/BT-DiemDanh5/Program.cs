using System;

namespace BTDiemDanh
{
    class Program
    {
        public static void Main()
        {
            int[] arr_122 = new int[100];
            int i_122, mx_122, mn_122;


            Console.Write("Nhap {0} phan tu vao trong mang:\n", 10);
            for (i_122 = 0; i_122 < 10; i_122++)
            {
                Console.Write("Phan tu - {0}: ", i_122);
                arr_122[i_122] = Convert.ToInt32(Console.ReadLine());
            }


            mx_122 = arr_122[0];
            mn_122 = arr_122[0];

            for (i_122 = 1; i_122 < 10; i_122++)
            {
                if (arr_122[i_122] > mx_122)
                {
                    mx_122 = arr_122[i_122];
                }


                if (arr_122[i_122] < mn_122)
                {
                    mn_122 = arr_122[i_122];
                }
            }
            Console.Write("Phan tu lon nhat la: {0}\n", mx_122);
            Console.Write("Phan tu nho nhat la: {0}\n\n", mn_122);

            for (i_122 = 0; i_122 < 10; i_122++)
            {
                for (int j = i_122 + 1; j < 10; j++)
                {
                    if (arr_122[i_122] > arr_122[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        int temp_122 = arr_122[i_122];
                        arr_122[i_122] = arr_122[j];
                        arr_122[j] = temp_122;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr_122[i] + " ");
            }

            Console.ReadKey();
        }
    }
}