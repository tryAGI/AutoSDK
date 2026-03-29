//HintName: G.Models.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Transcription,
        /// <summary>
        /// 
        /// </summary>
        Visual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems value)
        {
            return value switch
            {
                SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems.Audio => "audio",
                SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems.Transcription => "transcription",
                SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems.Visual => "visual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems? ToEnum(string value)
        {
            return value switch
            {
                "audio" => SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems.Audio,
                "transcription" => SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems.Transcription,
                "visual" => SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems.Visual,
                _ => null,
            };
        }
    }
}