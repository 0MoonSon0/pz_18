using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_18
{
    public enum CreditHistoryStatus
    {
        High,
        Medium,
        Low
    }
    public class Client
    {
        private static decimal totalIssuedCredits;
        private static int totalClients;
        private string fullName; private CreditHistoryStatus creditHistoryStatus;
        private decimal loanAmount; private decimal interestRate;
        public string FullName
        {
            get { return fullName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("ФИО клиента не может быть пустым");
                    return;
                }
                fullName = value;
            }
        }
        public CreditHistoryStatus CreditHistoryStatus
        {
            get { return creditHistoryStatus; }
            set { creditHistoryStatus = value; }
        }
        public decimal LoanAmount
        {
            get { return loanAmount; }
            set
            {
                if (value < 100000 || value > 5000000)
                {
                    Console.WriteLine("Сумма кредита должна быть в пределах от 100 тыс. до 5 млн."); return;
                }
                loanAmount = value;
            }
        }
        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        public static decimal TotalIssuedCredits
        {
            get { return totalIssuedCredits; }
        }
        public static int TotalClients
        {
            get { return totalClients; }
        }
        public Client(string fullName, CreditHistoryStatus creditHistoryStatus, decimal loanAmount, decimal interestRate)
        {
            FullName = fullName;
            CreditHistoryStatus = creditHistoryStatus; LoanAmount = loanAmount;
            InterestRate = interestRate;
            totalClients++; totalIssuedCredits += loanAmount;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"ФИО клиента: {FullName}"); Console.WriteLine($"Сумма кредита: {LoanAmount}");
            Console.WriteLine($"Процент кредита: {InterestRate}"); Console.WriteLine($"Статус кредитной истории: {CreditHistoryStatus}");
        }
        public void IssueCredit()
        {
            switch (CreditHistoryStatus)
            {
                case CreditHistoryStatus.High:
                    InterestRate = 10;
                    break;
                case CreditHistoryStatus.Medium:
                    InterestRate = 12; break;
                case CreditHistoryStatus.Low:
                    Console.WriteLine("Отказ в выдаче кредита");
                    break;
            }
        }
        public static void PrintAllCreditsInfo()
        {
            Console.WriteLine($"Сумма всех выданных кредитов: {TotalIssuedCredits}"); Console.WriteLine($"Количество выданных кредитов: {TotalClients}");
            Console.WriteLine($"Остаток суммы на кредиты самого банка: {50000000 - TotalIssuedCredits}");
        }
    }

}