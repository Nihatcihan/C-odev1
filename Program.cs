// See https://aka.ms/new-console-template for more information
// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

Console.WriteLine("Lütfen bir cümle giriniz!");
string cumle = Console.ReadLine();
int harf=0;
string[] dizi= cumle.Split(' ');
for (int i = 0; i < cumle.Length; i++)
{
    if (cumle[i]!=' ')
        harf++;
    
}
 Console.WriteLine("Kelime sayisi: " + dizi.Length);
Console.WriteLine("Harf sayisi: " + harf);

