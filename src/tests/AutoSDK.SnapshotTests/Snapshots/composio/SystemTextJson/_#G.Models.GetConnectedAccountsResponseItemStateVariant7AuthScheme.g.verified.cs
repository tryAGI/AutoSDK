//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant7AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant7AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        NoAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant7AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant7AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant7AuthScheme.NoAuth => "NO_AUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant7AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "NO_AUTH" => GetConnectedAccountsResponseItemStateVariant7AuthScheme.NoAuth,
                _ => null,
            };
        }
    }
}