// File: enums.js -> IranIbanEnums.cs
using System.Collections.Generic;

public static class IranIbanEnums
{
    public static readonly Dictionary<string, string> BankCodes = new()
    {
        { "MELLI", "017" },
        { "SEPAH", "015" },
        { "MASKAN", "014" },
        { "SADERAT", "019" },
        { "TEJARAT", "018" },
        { "REFAH", "013" },
        { "KESHAVARZI", "016" },
        { "SANATOMADAN", "011" },
        { "POST", "021" },
        { "EGHTESAD_NOVIN", "055" },
        { "PARSIAN", "054" },
        { "PASARGAD", "057" },
        { "SAMAN", "056" },
        { "KARAFARIN", "053" },
        { "SINA", "059" },
        { "MELAT", "012" },
        { "SHAHR", "061" },
        { "AYANDEH", "062" },
        { "IRAN_ZAMIN", "069" },
        { "TOURISM", "058" },
        { "GHARZOLHASANEH_RESALAT", "060" },
        { "GHARZOLHASANEH_MEHR", "058" }
    };
} // Note: GHARZOLHASANEH_MEHR shares the same code as TOURISM; preserve original mapping
