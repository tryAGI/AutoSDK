//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant3AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsResponseConnectionDataVariant3AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="API_KEY")]
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant3AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant3AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant3AuthScheme.ApiKey => "API_KEY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant3AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => PostConnectedAccountsResponseConnectionDataVariant3AuthScheme.ApiKey,
                _ => null,
            };
        }
    }
}