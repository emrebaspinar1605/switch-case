// See https://aka.ms/new-console-template for more information
int month=DateTime.Now.Month;

switch (month)
{
    case 1: Console.WriteLine("Ocak");
    break;

    case 2: Console.WriteLine("Şubat");
    break;

    case 7:System.Console.WriteLine("Temmuz");
   break;

    default: System.Console.WriteLine("Yanlış veri Girişi");
    break;
}
int sayi= 9;
switch (sayi)
{
    case 12:
    case 1:
    case 2: Console.WriteLine("Kış Ayındasınız");
    break;

    case 3:
    case 4:
    case 5: Console.WriteLine("İlkBahar Ayındasınız");
    break;
    
    case 6:
    case 7:
    case 8: Console.WriteLine("Yaz Ayındasınız");
    break;
    
    case 9:
    case 10:
    case 11: Console.WriteLine("Yaz Ayındasınız");
    break;  

    default : Console.WriteLine("Yanlış Veri Girişi");
    break;
}
