// File: turnBbanIntoIban.js -> TurnBbanIntoIban.cs
using System;
using System.Linq;
using System.Numerics;

public static class TurnBbanIntoIban
{
    public static string Convert(string bban, string bankCode, string bbanType = "0", string countryCode = "IR")
    {
        if (string.IsNullOrWhiteSpace(bankCode))
            throw new ArgumentException("You forgot to give bankCode to turnBbanIntoIban function");

        bban = bban?.Trim() ?? "";
        if (bban.Length < 18)
        {
            bban = bban.PadLeft(18, '0');
        }

        bban = bbanType + bban;

        string cc = string.Concat(countryCode.Select(c => GetIbanCC(c)));
        string ibanWithoutCD = bankCode + bban + cc + "00";

        BigInteger bigInt = BigInteger.Parse(ibanWithoutCD);
        int cd = 98 - (int)(bigInt % 97);

        return countryCode + cd.ToString("00") + bankCode + bban;
    }

    private static string GetIbanCC(char c)
    {
        if (char.IsLetter(c)) return ((c - 'A') + 10).ToString();
        return c.ToString();
    }
}

