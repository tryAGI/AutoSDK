//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsResponseConnectionDataVariant7AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NO_AUTH")]
        NoAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant7AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant7AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant7AuthScheme.NoAuth => "NO_AUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant7AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "NO_AUTH" => PostConnectedAccountsResponseConnectionDataVariant7AuthScheme.NoAuth,
                _ => null,
            };
        }
    }
}