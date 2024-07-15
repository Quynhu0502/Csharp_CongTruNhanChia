using System.Data;

internal class Program
{   /// <summary>
/// 
/// </summary>
/// <param name="args"></param>

    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Chào,Thế Giới!");
        Console.WriteLine("CT cộng 2 số đơn giản");
        int so1, so2, tong;
        Console.Write("Nhập số 1:");
        so1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập số 2:");
        so2 = Convert.ToInt32(Console.ReadLine());
        tong = so1 + so2;
        Console.WriteLine("Tổng của hai số " + so1 + " và " + so2 + " là " + tong);
        Console.WriteLine("Tổng của hai số bằng hàm là " + TinhTong(so1, so2));

        //Console.Write ("Tổng của hai số {0} và số {1} là số {2}", so1,so2,tong);
        int thuong;
        try
        {
            thuong = so1 / so2;
            Console.WriteLine($"Thương của hai số {so1} và {so2} là {thuong}");

        }
        catch (Exception e)
        {
            Console.WriteLine("Không thể chia cho 0");
           


        }


    }
    private static int TinhTong(int a, int b)
    {
       return a + b;
    }


}
