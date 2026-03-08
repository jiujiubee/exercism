public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    public static bool operator ==(CurrencyAmount lhs, CurrencyAmount rhs) => Validate(lhs, rhs, lhs.amount == rhs.amount);
    public static bool operator !=(CurrencyAmount lhs, CurrencyAmount rhs) => Validate(lhs, rhs, lhs.amount != rhs.amount);
    public static bool operator >(CurrencyAmount lhs, CurrencyAmount rhs) => Validate(lhs, rhs, lhs.amount > rhs.amount);
    public static bool operator <(CurrencyAmount lhs, CurrencyAmount rhs) => Validate(lhs, rhs, lhs.amount < rhs.amount);
    public static CurrencyAmount operator +(CurrencyAmount lhs, CurrencyAmount rhs) => Validate(lhs, rhs, lhs.amount + rhs.amount);
    public static CurrencyAmount operator -(CurrencyAmount lhs, CurrencyAmount rhs) => Validate(lhs, rhs, lhs.amount - rhs.amount);
    public static CurrencyAmount operator *(decimal lhs, CurrencyAmount rhs) => new CurrencyAmount(rhs.amount * lhs, rhs.currency);
    public static CurrencyAmount operator /(decimal lhs, CurrencyAmount rhs) => (lhs == 0) ? new CurrencyAmount(rhs.amount / lhs, rhs.currency) : throw new DivideByZeroException();

    public static explicit operator double(CurrencyAmount c) => (double)c.amount;
    public static implicit operator decimal(CurrencyAmount c) => c.amount;

    private static bool Validate(CurrencyAmount lhs, CurrencyAmount rhs, bool returnVal) => (lhs.currency == rhs.currency) ? returnVal : throw new ArgumentException();
    private static CurrencyAmount Validate(CurrencyAmount lhs, CurrencyAmount rhs, decimal returnVal) => (lhs.currency == rhs.currency) ? new CurrencyAmount (returnVal, lhs.currency) : throw new ArgumentException();

}
