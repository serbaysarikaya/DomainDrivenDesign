﻿namespace DomainDrivenDesign.Domain.Shared;

public sealed record Money(decimal Amount, Currency Currency)
{
    public static Money operator +(Money a, Money b)
    {
        if (a.Currency != b.Currency)
        {
            throw new InvalidOperationException("Para birimleri eşleşmiyor.");
        }
       
        return new Money(a.Amount + b.Amount, a.Currency);
    }

    public  static Money Zero()=>new Money(0, Currency.None);
    public static Money Zero(Currency currency) => new Money(0, currency);
    public bool IsZero() => this == Zero(Currency);
}
