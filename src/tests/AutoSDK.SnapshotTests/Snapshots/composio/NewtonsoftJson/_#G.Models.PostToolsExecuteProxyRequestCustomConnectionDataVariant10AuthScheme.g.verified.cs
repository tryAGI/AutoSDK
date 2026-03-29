//HintName: G.Models.PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GOOGLE_SERVICE_ACCOUNT")]
        GoogleServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "GOOGLE_SERVICE_ACCOUNT" => PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthScheme.GoogleServiceAccount,
                _ => null,
            };
        }
    }
}