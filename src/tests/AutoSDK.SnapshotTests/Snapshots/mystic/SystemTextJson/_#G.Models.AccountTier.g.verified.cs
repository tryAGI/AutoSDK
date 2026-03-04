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
        Basic,
        /// <summary>
        /// 
        /// </summary>
        Starter,
        /// <summary>
        /// 
        /// </summary>
        Pro,
        /// <summary>
        /// 
        /// </summary>
        Byoc,
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
                AccountTier.Basic => "BASIC",
                AccountTier.Starter => "STARTER",
                AccountTier.Pro => "PRO",
                AccountTier.Byoc => "BYOC",
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
                "BASIC" => AccountTier.Basic,
                "STARTER" => AccountTier.Starter,
                "PRO" => AccountTier.Pro,
                "BYOC" => AccountTier.Byoc,
                _ => null,
            };
        }
    }
}