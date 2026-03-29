//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        BearerToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme.BearerToken => "BEARER_TOKEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BEARER_TOKEN" => PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme.BearerToken,
                _ => null,
            };
        }
    }
}