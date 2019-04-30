using System;

namespace Task_2_3_Operator_overloading
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    //enum CurrencyTypes
    //    {
    //        UAH,
    //        USD,
    //        EUR
    //}

    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public decimal Amount { get; set; }
        public string CurrencyType { get; set; }
        public static decimal[] Course = new decimal[2];
        //Course[0] = UAH/USD
        //Course[1] = UAH/EUR
        // 3) declare parameter constructor for properties initialization
        public Money(decimal amount, string currencyType)
        {
            Amount = amount;
            CurrencyType = currencyType;
        }
        public Money()
        {
            Amount = 0m;
            //   CurrencyType = CurrencyTypes.UAH;
        }
        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money amt1, Money amt2)
        {
            return new Money(amt1.Amount + amt2.Amount, amt1.CurrencyType);
        }
        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator --(Money amt1)
        {
            return new Money(amt1.Amount--, amt1.CurrencyType);
        }
        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money amt1, decimal X3)
        {
            return new Money(amt1.Amount * X3, amt1.CurrencyType);
        }
        // 7) declare overloading of operator > and < to compare 2 objects of Money
        public static bool operator <(Money amt1, Money amt2)
        {
            return (amt1.Amount < amt2.Amount);
        }
        public static bool operator >(Money amt1, Money amt2)
        {
            return (amt1.Amount > amt2.Amount);
        }
        // 8) declare overloading of operator true and false to check CurrencyType of object
        public static bool operator ==(Money amt1, Money amt2)
        {
            return true;
        }
        public static bool operator !=(Money amt1, Money amt2)
        {
            return true;
        }
        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa
        public static explicit operator double(Money amt1)
        {
            return Convert.ToDouble(amt1.Amount);
        }
        public static explicit operator string(Money atm1)
        {
            return "Convert 1st object of Money to string " + Convert.ToString(atm1.Amount) + " " + Convert.ToString(atm1.CurrencyType); ;
        }
        //public static implicit operator double(Money amt1)
        //{
        //    return (amt1.Amount);
        //}
    }
}
