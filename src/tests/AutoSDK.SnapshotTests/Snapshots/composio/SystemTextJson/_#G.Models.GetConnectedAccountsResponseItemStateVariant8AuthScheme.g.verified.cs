//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant8AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant8AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        CalcomAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant8AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant8AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant8AuthScheme.CalcomAuth => "CALCOM_AUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant8AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "CALCOM_AUTH" => GetConnectedAccountsResponseItemStateVariant8AuthScheme.CalcomAuth,
                _ => null,
            };
        }
    }
}