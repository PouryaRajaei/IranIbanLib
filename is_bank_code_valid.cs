// File: isBankCodeValid.js -> IsBankCodeValid.cs
public static class IsBankCodeValid
{
    public static bool Check(string? bankCode)
    {
        if (string.IsNullOrWhiteSpace(bankCode))
            return false;

        return IranIbanEnums.BankCodes.ContainsValue(bankCode);
    }
}
