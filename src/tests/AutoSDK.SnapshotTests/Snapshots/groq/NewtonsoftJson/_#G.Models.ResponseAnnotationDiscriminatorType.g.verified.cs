//HintName: G.Models.ResponseAnnotationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseAnnotationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_citation")]
        FileCitation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url_citation")]
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAnnotationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAnnotationDiscriminatorType value)
        {
            return value switch
            {
                ResponseAnnotationDiscriminatorType.FileCitation => "file_citation",
                ResponseAnnotationDiscriminatorType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAnnotationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => ResponseAnnotationDiscriminatorType.FileCitation,
                "url_citation" => ResponseAnnotationDiscriminatorType.UrlCitation,
                _ => null,
            };
        }
    }
}