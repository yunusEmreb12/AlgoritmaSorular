using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Soru = Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
          
                    Console.WriteLine("Lütfen pozitif bir sayi giriniz:");
                    int n = int.Parse(Console.ReadLine());
                    
                    for (int i = 1; i <= n; i++)
                    {
                        if(i % 2 == 0)
                            Console.WriteLine(i);
                    }

            //2.Soru = Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

                    Console.WriteLine("Lüften pozitif bir sayı giriniz:");
                    int n= int.Parse(Console.ReadLine());

                    Console.WriteLine("Lüften pozitif bir sayı giriniz:");
                    int m= int.Parse(Console.ReadLine());

                    int[] sayilar = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Lütfen {0} ıncı sayıyı giriniz adet sayı giriniz:",i+1);  
                        sayilar[i]=int.Parse(Console.ReadLine());
                    }

                    foreach (int sayi in sayilar)
                    {
                        if(sayi%m==0)
                            Console.WriteLine(sayi);
                    }
                
            // 3.Soru = Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

                    Console.WriteLine("Lütfen pozitif bir sayi giriniz:");
                    int n = int.Parse(Console.ReadLine());
                    string[] dizi = new string[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Lütfen {0} adet kelime gir:",i+1);
                        dizi[i] = Console.ReadLine();
                    }
                    Array.Reverse(dizi);
                    foreach (var item in dizi)
                    {
                        Console.Write(item);
                    }

                // 4.Soru = Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
                //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

                    Console.WriteLine("Bir cümle Yazınız:");
                    string cumle = Console.ReadLine();
                    char[] character= cumle.ToCharArray();
                    string[] kelime = cumle.Split(" ");
                    Console.WriteLine("Cümledeki harf sayısı:"+ character.Length);
                    Console.WriteLine("Cümledeki kelime sayısı:"+ kelime.Length);
        }   
    }
}
