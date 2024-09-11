//HintName: G.Models.AccountTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines various account tiers with different access levels and permissions.
    /// </summary>
    public enum AccountTier
    {
        /// <summary>
        /// 
        /// </summary>
        BASIC,
        /// <summary>
        /// 
        /// </summary>
        STARTER,
        /// <summary>
        /// 
        /// </summary>
        PRO,
        /// <summary>
        /// 
        /// </summary>
        BYOC,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccountTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountTier value)
        {
            return value switch
            {
                AccountTier.BASIC => "BASIC",
                AccountTier.STARTER => "STARTER",
                AccountTier.PRO => "PRO",
                AccountTier.BYOC => "BYOC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountTier? ToEnum(string value)
        {
            return value switch
            {
                "BASIC" => AccountTier.BASIC,
                "STARTER" => AccountTier.STARTER,
                "PRO" => AccountTier.PRO,
                "BYOC" => AccountTier.BYOC,
                _ => null,
            };
        }
    }
}