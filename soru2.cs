// See https://aka.ms/new-console-template for more information
// Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
Console.WriteLine("2 adet pozitif tam sayi giriniz");
int n =Convert.ToInt16(Console.ReadLine());
int m =Convert.ToInt16(Console.ReadLine());

Console.WriteLine(n+" adet pozitif tam sayi giriniz");
int[] dizi= new int[n];

for (int i = 0; i < n; i++)
    dizi[i]=Convert.ToInt16(Console.ReadLine());
for (int i = 0; i < n; i++)
    Console.Write(dizi[i]+" ");
Console.WriteLine(" ");
Console.WriteLine("dizinin elemanlarinda m'e esit veya tam bolunenler");

for (int i = 0; i < n; i++)
{
    if(dizi[i]==m)
        Console.Write(dizi[i]+",");
    else if(dizi[i]%m==0)
        Console.Write(dizi[i]+" ");   

}
