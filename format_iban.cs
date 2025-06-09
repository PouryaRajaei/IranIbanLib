// File: formatIban.js -> FormatIban.cs
using System;
using System.Collections.Generic;

public static class FormatIban
{
    /// <summary>
    /// Formats an IBAN string into 4-character grouped segments (standard human-readable format)
    /// </summary>
    public static string Format(string iban)
    {
        if (string.IsNullOrWhiteSpace(iban)) return string.Empty;

        iban = iban.Replace(" ", "").Trim();

        List<string> parts = new();
        for (int i = 0; i < iban.Length; i += 4)
        {
            int length = Math.Min(4, iban.Length - i);
            parts.Add(iban.Substring(i, length));
        }

        return string.Join(" ", parts);
    }
}
