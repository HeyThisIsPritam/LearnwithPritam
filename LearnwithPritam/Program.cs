using System;

namespace LearnwithPritam
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            long phn = 990000000;
            object obj = phn;
            Customer cust = new Customer();
            object[] details = { 1002, "Pritam", CardType.Titanium, phn };
            cust.custDetails(details);
        }
    }
}
