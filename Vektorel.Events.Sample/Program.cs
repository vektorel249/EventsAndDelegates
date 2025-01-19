namespace Vektorel.Events.Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Gerekli parametreler olmadığı için uygulama kapatılıyor");
                Console.ReadLine();
                return;
            }
            if (!int.TryParse(args[0], out var step))
            {
                Console.WriteLine("İlk parametre sayı olmalı");
                Console.ReadLine();
                return;
            }
            if (args[1].Length != 4)
            {
                Console.WriteLine("İkinci parametre 4 karakter olmalı");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"{step} adımda parola {args[1]} anahtarına göre şifreleniyor. Lütfen bekleyiniz");
            Thread.Sleep(2000);
            Console.WriteLine("Parola : " + Guid.NewGuid());

            Console.ReadLine();
        }
    }
}
