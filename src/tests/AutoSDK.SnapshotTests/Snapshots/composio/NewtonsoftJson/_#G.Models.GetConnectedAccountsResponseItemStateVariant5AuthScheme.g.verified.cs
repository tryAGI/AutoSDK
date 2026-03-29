//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant5AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsResponseItemStateVariant5AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BEARER_TOKEN")]
        BearerToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant5AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant5AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant5AuthScheme.BearerToken => "BEARER_TOKEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant5AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BEARER_TOKEN" => GetConnectedAccountsResponseItemStateVariant5AuthScheme.BearerToken,
                _ => null,
            };
        }
    }
}