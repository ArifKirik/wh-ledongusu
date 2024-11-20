namespace while_döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba eskişehir");
            //    i++;
            //}
            //Console.ReadLine();
            //int sayi;
            //Console.WriteLine("Bir sayı giriniz:");
            //sayi=Convert.ToInt32(Console.ReadLine());

            //while(sayi%2==0)
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    sayi=Convert.ToInt32(Console.ReadLine()) ;

            //}
            //Console.WriteLine("tek sayı girdiniz");
            //Console.ReadLine();
            int sayi;
            Console.WriteLine("faktöriyeli alınacak sayıyı giriniz:");
            sayi=Convert.ToInt32(Console.ReadLine());
            int faktöriyel = 1;
            while(sayi>1)
            {
                faktöriyel = faktöriyel * sayi;
                sayi--;
            }
            Console.WriteLine(faktöriyel);
            Console.ReadLine();
        }
    }
}
