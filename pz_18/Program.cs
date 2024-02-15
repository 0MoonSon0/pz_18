using pz_18;

class Program
{
    
    
        static void Main(string[] args)
        {
            Client client1 = new Client("Иванов Иван Иванович", CreditHistoryStatus.High, 1000000, 0); client1.PrintInfo();
            Client client2 = new Client("Петров Петр Петрович", CreditHistoryStatus.Medium, 2000000, 0);
            client2.PrintInfo();
            Client client3 = new Client("Сидоров Сидор Сидорович", CreditHistoryStatus.Low, 3000000, 0); client3.PrintInfo();
            Client.PrintAllCreditsInfo();
            Console.ReadKey();
        }
    
}
