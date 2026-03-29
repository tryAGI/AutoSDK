//HintName: G.Models.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use this parameter to group or ungroup items in a response. It can take one of the following values:<br/>
    /// - `video`:  The platform will group the matching video clips in the response by video.<br/>
    /// - `clip`: The matching video clips in the response will not be grouped.<br/>
    /// **Default:** `clip`<br/>
    /// Default Value: clip
    /// </summary>
    public enum SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy
    {
        /// <summary>
        /// The platform will group the matching video clips in the response by video.
        /// </summary>
        Clip,
        /// <summary>
        /// The platform will group the matching video clips in the response by video.
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPostRequestBodyContentMultipartFormDataSchemaGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy value)
        {
            return value switch
            {
                SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy.Clip => "clip",
                SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "clip" => SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy.Clip,
                "video" => SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy.Video,
                _ => null,
            };
        }
    }
}