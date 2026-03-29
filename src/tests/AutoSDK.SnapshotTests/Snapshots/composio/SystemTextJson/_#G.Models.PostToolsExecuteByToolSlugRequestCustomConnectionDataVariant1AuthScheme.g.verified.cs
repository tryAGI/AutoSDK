//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthScheme.Oauth2 => "OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "OAUTH2" => PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthScheme.Oauth2,
                _ => null,
            };
        }
    }
}