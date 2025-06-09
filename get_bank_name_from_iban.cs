// File: getBankNameFromIban.js -> GetBankNameFromIban.cs
using System;
using System.Collections.Generic;

public static class GetBankNameFromIban
{
    private static readonly Dictionary<string, string> BankNames = new()
    {
        { "017", "بانک ملی ایران" },
        { "015", "بانک سپه" },
        { "014", "بانک مسکن" },
        { "019", "بانک صادرات ایران" },
        { "018", "بانک تجارت" },
        { "013", "بانک رفاه کارگران" },
        { "016", "بانک کشاورزی" },
        { "011", "بانک صنعت و معدن" },
        { "021", "پست بانک ایران" },
        { "055", "بانک اقتصاد نوین" },
        { "054", "بانک پارسیان" },
        { "057", "بانک پاسارگاد" },
        { "056", "بانک سامان" },
        { "053", "بانک کارآفرین" },
        { "059", "بانک سینا" },
        { "012", "بانک ملت" },
        { "061", "بانک شهر" },
        { "062", "بانک آینده" },
        { "069", "بانک ایران زمین" },
        { "058", "بانک گردشگری / قرض‌الحسنه مهر ایران" },
        { "060", "بانک قرض‌الحسنه رسالت" }
    };

    public static string? GetName(string iban)
    {
        if (string.IsNullOrWhiteSpace(iban) || iban.Length < 10)
            return null;

        string bankCode = iban.Substring(4, 3);
        return BankNames.TryGetValue(bankCode, out var name) ? name : null;
    }
}
