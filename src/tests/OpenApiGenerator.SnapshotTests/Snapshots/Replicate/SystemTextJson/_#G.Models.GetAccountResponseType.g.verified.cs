//HintName: G.Models.GetAccountResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The account type. Can be a user or an organization.
    /// </summary>
    public enum GetAccountResponseType
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

    public static class GetAccountResponseTypeExtensions
    {
        public static string ToValueString(this GetAccountResponseType value)
        {
            return value switch
            {
                GetAccountResponseType.Organization => "organization",
                GetAccountResponseType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetAccountResponseType ToEnum(string value)
        {
            return value switch
            {
                "organization" => GetAccountResponseType.Organization,
                "user" => GetAccountResponseType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GetAccountResponseType ToEnum(int value)
        {
            return value switch
            {
                0 => GetAccountResponseType.Organization,
                1 => GetAccountResponseType.User,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}