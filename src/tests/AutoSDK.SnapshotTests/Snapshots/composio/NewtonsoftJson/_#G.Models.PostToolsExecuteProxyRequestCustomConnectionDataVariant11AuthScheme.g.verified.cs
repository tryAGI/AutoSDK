//HintName: G.Models.PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthScheme
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
    public static class PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthScheme.S2sOauth2 => "S2S_OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "S2S_OAUTH2" => PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthScheme.S2sOauth2,
                _ => null,
            };
        }
    }
}