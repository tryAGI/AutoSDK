//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant2AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsResponseItemStateVariant2AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OAUTH2")]
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant2AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant2AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant2AuthScheme.Oauth2 => "OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant2AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "OAUTH2" => GetConnectedAccountsResponseItemStateVariant2AuthScheme.Oauth2,
                _ => null,
            };
        }
    }
}