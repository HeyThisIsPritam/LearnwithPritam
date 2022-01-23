using System;
using System.Collections.Generic;
using System.Text;

namespace LearnwithPritam
{
    class Customer
    {
        public int CustId;
        public string CustName;
        public CardType custCardType;
        public long custPhone;

        //public Customer(int CustId, string CustName, CardType custCardType,long custPhone)
        //{
        //    this.custCardType = custCardType;
        //    this.CustName = CustName;
        //    this.CustId = CustId;
        //    this.custPhone = custPhone;
        //}

        public void custDetails(object[] details)
        {
            Console.WriteLine("Customer details are: ");
            foreach (var item in details)
            {
                Console.WriteLine(item);
            }
        }

    }
}
