// See https://aka.ms/new-console-template for more information
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
Console.WriteLine("pozitif bir sayi giriniz");
int n=Convert.ToInt16(Console.ReadLine());
string[] dizi = new string[n];
Console.WriteLine(n+" adet kelime giriniz");

for (int i = 0; i < n; i++)
   dizi[i]= Console.ReadLine();

for (int i = n; i > 0; i--)
   Console.WriteLine(dizi[i-1]);
