//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant11AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant11AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        ServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant11AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant11AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant11AuthScheme.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant11AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "SERVICE_ACCOUNT" => GetConnectedAccountsResponseItemStateVariant11AuthScheme.ServiceAccount,
                _ => null,
            };
        }
    }
}