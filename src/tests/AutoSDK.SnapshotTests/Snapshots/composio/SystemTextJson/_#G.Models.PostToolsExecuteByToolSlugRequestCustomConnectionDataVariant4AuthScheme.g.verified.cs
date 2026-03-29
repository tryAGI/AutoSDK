//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        BasicWithJwt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BASIC_WITH_JWT" => PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme.BasicWithJwt,
                _ => null,
            };
        }
    }
}