//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthScheme.ApiKey => "API_KEY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthScheme.ApiKey,
                _ => null,
            };
        }
    }
}