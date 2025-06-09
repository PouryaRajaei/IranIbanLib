// File: turnIbanIntoBban.js -> TurnIbanIntoBban.cs
public static class TurnIbanIntoBban
{
    public static string? Convert(string? iban)
    {
        if (string.IsNullOrWhiteSpace(iban) || iban.Length < 6)
            return null;

        return iban.Substring(4);
    }
}
