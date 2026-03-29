//HintName: G.Models.SearchPostRequestBodyContentMultipartFormDataSchemaSortOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// &lt;Info&gt;<br/>
    ///   This parameter is deprecated in Marengo 3.0 and newer versions. Use the [`rank`](/v1.3/api-reference/any-to-video-search/make-search-request#response.body.data.rank) field in the response instead, which indicates the relevance ranking assigned by the model.<br/>
    /// &lt;/Info&gt;<br/>
    /// Use this parameter to specify the sort order for the response.<br/>
    /// When performing a search, the platform assigns a relevance ranking to each video clip that matches your search terms. By default, the search results are sorted by relevance ranking in ascending order, with 1 being the most relevant result.<br/>
    /// If you set this parameter to `score` and `group_by` is set to `video`, the platform will determine the highest relevance ranking (lowest number) for each video and sort the videos in the response by this ranking. For each video, the matching video clips will be sorted by relevance ranking in ascending order.<br/>
    /// If you set this parameter to `clip_count` and `group_by` is set to `video`, the platform will sort the videos in the response by the number of clips. For each video, the matching video clips will be sorted by relevance ranking in ascending order. You can use `clip_count` only when the matching video clips are grouped by video.<br/>
    /// **Default:** `score`<br/>
    /// Default Value: score
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchPostRequestBodyContentMultipartFormDataSchemaSortOption
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip_count")]
        ClipCount,
        /// <summary>
        /// ** `score`
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="score")]
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchPostRequestBodyContentMultipartFormDataSchemaSortOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPostRequestBodyContentMultipartFormDataSchemaSortOption value)
        {
            return value switch
            {
                SearchPostRequestBodyContentMultipartFormDataSchemaSortOption.ClipCount => "clip_count",
                SearchPostRequestBodyContentMultipartFormDataSchemaSortOption.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPostRequestBodyContentMultipartFormDataSchemaSortOption? ToEnum(string value)
        {
            return value switch
            {
                "clip_count" => SearchPostRequestBodyContentMultipartFormDataSchemaSortOption.ClipCount,
                "score" => SearchPostRequestBodyContentMultipartFormDataSchemaSortOption.Score,
                _ => null,
            };
        }
    }
}