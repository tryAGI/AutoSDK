//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        S2sOauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme.S2sOauth2 => "S2S_OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "S2S_OAUTH2" => PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme.S2sOauth2,
                _ => null,
            };
        }
    }
}