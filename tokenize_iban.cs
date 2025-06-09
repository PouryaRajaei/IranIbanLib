// File: tokenizeIban.js -> TokenizeIban.cs
using System.Text.RegularExpressions;

public class TokenizedIranIban
{
    public string CountryCode { get; set; } = string.Empty;
    public string CD { get; set; } = string.Empty;
    public string CC { get; set; } = string.Empty;
    public string BbanType { get; set; } = string.Empty;
    public string BBAN { get; set; } = string.Empty;
}

public static class TokenizeIban
{
    public static TokenizedIranIban Tokenize(string iban)
    {
        var result = new TokenizedIranIban();
        if (string.IsNullOrWhiteSpace(iban)) return result;

        iban = iban.Trim().ToUpper();
        var match = Regex.Match(iban, @"^([A-Z]{2})(\d{2})(\d{3})(\d{1})(\d{18})$");

        if (!match.Success) return result;

        result.CountryCode = match.Groups[1].Value;
        result.CD = match.Groups[2].Value;
        result.CC = match.Groups[3].Value;
        result.BbanType = match.Groups[4].Value;
        result.BBAN = match.Groups[5].Value;

        return result;
    }
}
