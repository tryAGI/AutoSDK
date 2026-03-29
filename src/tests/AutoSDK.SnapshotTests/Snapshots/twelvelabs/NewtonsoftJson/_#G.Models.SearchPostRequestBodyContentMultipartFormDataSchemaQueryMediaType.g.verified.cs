//HintName: G.Models.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of media you wish to use. This parameter is required for media queries. For example, to perform an image-based search, set this parameter to `image`. Use `query_text` together with this parameter when you want to perform a composed image+text search.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType value)
        {
            return value switch
            {
                SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType? ToEnum(string value)
        {
            return value switch
            {
                "image" => SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType.Image,
                _ => null,
            };
        }
    }
}