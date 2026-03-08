public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    public static bool operator ==(CurrencyAmount lhs, CurrencyAmount rhs) => lhs.currency == rhs.currency ? lhs.amount == rhs.amount && lhs.currency == rhs.currency : throw new ArgumentException();
    public static bool operator !=(CurrencyAmount lhs, CurrencyAmount rhs) => lhs.currency == rhs.currency ? lhs.amount != rhs.amount || lhs.currency != rhs.currency : throw new ArgumentException();
    public static bool operator >(CurrencyAmount lhs, CurrencyAmount rhs) => lhs.currency == rhs.currency ? lhs.amount > rhs.amount : throw new ArgumentException();
    public static bool operator <(CurrencyAmount lhs, CurrencyAmount rhs) => lhs.currency == rhs.currency ? lhs.amount < rhs.amount : throw new ArgumentException();
    public static CurrencyAmount operator +(CurrencyAmount lhs, CurrencyAmount rhs) => lhs.currency == rhs.currency ? new CurrencyAmount(lhs.amount + rhs.amount, lhs.currency) : throw new ArgumentException();
    public static CurrencyAmount operator -(CurrencyAmount lhs, CurrencyAmount rhs) => lhs.currency == rhs.currency ? new CurrencyAmount(lhs.amount - rhs.amount, lhs.currency) : throw new ArgumentException();
    public static CurrencyAmount operator *(decimal lhs, CurrencyAmount rhs) => new CurrencyAmount(rhs.amount * lhs, rhs.currency);
    public static CurrencyAmount operator /(decimal lhs, CurrencyAmount rhs) => new CurrencyAmount(rhs.amount / lhs, rhs.currency);

    public static explicit operator double(CurrencyAmount c) => (double)c.amount;
    public static implicit operator decimal(CurrencyAmount c) => c.amount;

}
