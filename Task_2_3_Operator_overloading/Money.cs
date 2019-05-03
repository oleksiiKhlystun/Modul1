using System;

namespace Task_2_3_Operator_overloading
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EUR
    enum CurrencyTypes : byte
    {
        UAH = 1,
        USD = 27,
        EUR = 32
    }

    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public decimal Amount { get; set; }
        public CurrencyTypes CurrencyType { get; set; }
        // 3) declare parameter constructor for properties initialization
        public Money(decimal amount, CurrencyTypes currencyType)
        {
            Amount = amount;
            CurrencyType = currencyType;
        }
        public Money()
        {
            Amount = 0m;
            CurrencyType = CurrencyTypes.UAH;
        }
        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money amt1, Money amt2)
        {
            if (amt1.CurrencyType != amt2.CurrencyType)
            {
                Console.WriteLine("Different CurrencyType.Lets Converted to UAH");
                Converter(amt1);
                Converter(amt2);
                return new Money(amt1.Amount + amt2.Amount, amt1.CurrencyType = CurrencyTypes.UAH);
            }
            else
                return new Money(amt1.Amount + amt2.Amount, amt1.CurrencyType);
        }
        public static Money Converter(Money money)
        {
            money.Amount = money.Amount * (decimal)money.CurrencyType;
            money.CurrencyType = CurrencyTypes.UAH;
            return money;
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
            return "Convert 1st object of Money to string " + Convert.ToString(atm1.Amount) + " " + Convert.ToString(atm1.CurrencyType);
        }
    }
}
