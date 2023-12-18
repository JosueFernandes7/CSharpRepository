using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Account(1001,"Nelio",0.0); // classe pai

            //account.Withdraw(200);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500); // classe filha
            bacc.Withdraw(200);


        }
    }
}