// File: isIbanValid.js -> IsIbanValid.cs
using System;
using System.Numerics;
using System.Text.RegularExpressions;

public static class IsIbanValid
{
    public static bool Check(string? iban)
    {
        if (string.IsNullOrWhiteSpace(iban))
            return false;

        iban = iban.ToUpper().Replace(" ", "").Trim();

        if (!Regex.IsMatch(iban, "^IR\\d{24}$"))
            return false;

        string rearranged = iban.Substring(4) + "1827"; // 'IR' => 18 27
        string numericString = ConvertToNumeric(rearranged);

        return BigInteger.TryParse(numericString, out var bigInt) && bigInt % 97 == 1;
    }

    private static string ConvertToNumeric(string input)
    {
        var result = "";
        foreach (char c in input)
        {
            if (char.IsLetter(c))
                result += (c - 'A' + 10).ToString();
            else
                result += c;
        }
        return result;
    }
}
