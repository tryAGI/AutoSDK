//HintName: G.Models.AccountGetResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type. Can be a user or an organization.
    /// </summary>
    public enum AccountGetResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccountGetResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountGetResponseType value)
        {
            return value switch
            {
                AccountGetResponseType.Organization => "organization",
                AccountGetResponseType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountGetResponseType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => AccountGetResponseType.Organization,
                "user" => AccountGetResponseType.User,
                _ => null,
            };
        }
    }
}