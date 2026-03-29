//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        NoAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme.NoAuth => "NO_AUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "NO_AUTH" => PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme.NoAuth,
                _ => null,
            };
        }
    }
}