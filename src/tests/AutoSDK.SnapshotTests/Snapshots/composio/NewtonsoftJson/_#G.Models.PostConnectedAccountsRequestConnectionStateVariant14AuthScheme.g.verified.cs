//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant14AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsRequestConnectionStateVariant14AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="S2S_OAUTH2")]
        S2sOauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant14AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant14AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant14AuthScheme.S2sOauth2 => "S2S_OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant14AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "S2S_OAUTH2" => PostConnectedAccountsRequestConnectionStateVariant14AuthScheme.S2sOauth2,
                _ => null,
            };
        }
    }
}