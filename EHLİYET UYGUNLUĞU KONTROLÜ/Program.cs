namespace EHLİYET_UYGUNLUĞU_KONTROLÜ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yaşınızı giriniz.");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sağlık durumunuz iyi mi 'Evet' veya 'Hayır' yazınız.");
            string saglık = Console.ReadLine().ToLower();

            Console.WriteLine("Sabıkanız var ise 'Evet' yok ise 'Hayır' yazınız.");
            string sabika = Console.ReadLine().ToLower();

             if(yas>=18 && saglık == "evet" && sabika == "hayır")
            {
                Console.WriteLine("Ehliyet alabilirsin");
            }
            else
            {
                Console.WriteLine("Ehliyet alamazsın.");
            }





        }

    }
}
