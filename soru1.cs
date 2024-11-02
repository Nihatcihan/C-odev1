// See https://aka.ms/new-console-template for more information

//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
Console.Write("Pozitif bir tam sayi giriniz:");

int n=Convert.ToInt16(Console.ReadLine());

Console.Write(n+" tane pozitif tam sayi giriniz:");
//int[] nsayi= new{};
int[] dizi=new int[n];


    for (int i = 0; i < n; i++)
    {
        dizi[i]=Convert.ToInt16(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
    {
        Console.Write(dizi[i]+" ");
    }
    Console.WriteLine();

    Console.Write("Cift olan sayilar:");
    for (int i = 0; i < n; i++)
    {   
        if(dizi[i]%2==0)
        Console.Write(dizi[i]+" ");
    }
