//HintName: G.Models.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lexical")]
        Lexical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="semantic")]
        Semantic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems value)
        {
            return value switch
            {
                SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems.Lexical => "lexical",
                SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems.Semantic => "semantic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems? ToEnum(string value)
        {
            return value switch
            {
                "lexical" => SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems.Lexical,
                "semantic" => SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems.Semantic,
                _ => null,
            };
        }
    }
}