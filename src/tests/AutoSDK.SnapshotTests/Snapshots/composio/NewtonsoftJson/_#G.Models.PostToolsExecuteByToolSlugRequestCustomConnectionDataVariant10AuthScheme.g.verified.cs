//HintName: G.Models.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme
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
    public static class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme value)
        {
            return value switch
            {
                PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "GOOGLE_SERVICE_ACCOUNT" => PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme.GoogleServiceAccount,
                _ => null,
            };
        }
    }
}