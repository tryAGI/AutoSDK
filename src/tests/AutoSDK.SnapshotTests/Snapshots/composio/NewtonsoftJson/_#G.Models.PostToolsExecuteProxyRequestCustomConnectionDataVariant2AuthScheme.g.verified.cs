//HintName: G.Models.PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DCR_OAUTH")]
        DcrOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthScheme.DcrOauth => "DCR_OAUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "DCR_OAUTH" => PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthScheme.DcrOauth,
                _ => null,
            };
        }
    }
}