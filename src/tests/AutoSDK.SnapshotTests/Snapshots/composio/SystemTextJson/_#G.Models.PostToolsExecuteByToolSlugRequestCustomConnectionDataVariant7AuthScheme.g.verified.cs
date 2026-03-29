//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        Oauth1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthScheme.Oauth1 => "OAUTH1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "OAUTH1" => PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthScheme.Oauth1,
                _ => null,
            };
        }
    }
}