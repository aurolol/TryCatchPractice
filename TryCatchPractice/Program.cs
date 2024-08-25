
try 
{
    Console.Write("Bir sayı giriniz.");

    int sayi = Convert.ToInt32(Console.ReadLine());

    int karesi = sayi * sayi;

    Console.WriteLine(karesi);

}
catch(FormatException)
{
    Console.WriteLine("Yanlış format girdiniz." );
}
catch(Exception ex)
{
    Console.WriteLine("Beklenmeyen bir hata oluştu." + ex.Message);
}