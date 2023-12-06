internal class Program
{
    private static void Main(string[] args)
    {
        float chieudai;
        float chieurong;
        float dientich;
        Console.WriteLine("NHAP CHIEU DAI : ");
        chieudai = float.Parse(Console.ReadLine());
        Console.WriteLine("NHAP CHIEU RONG : ");
        chieurong = float.Parse(Console.ReadLine());
        dientich = chieudai * chieurong;
        Console.WriteLine("dien tich = "+dientich);
}
}