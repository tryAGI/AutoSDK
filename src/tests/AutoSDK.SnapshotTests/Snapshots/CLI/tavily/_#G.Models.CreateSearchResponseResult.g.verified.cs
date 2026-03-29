//HintName: G.Models.CreateSearchResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSearchResponseResult
    {
        /// <summary>
        /// The title of the search result.<br/>
        /// Example: Lionel Messi Facts | Britannica
        /// </summary>
        /// <example>Lionel Messi Facts | Britannica</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The URL of the search result.<br/>
        /// Example: https://www.britannica.com/facts/Lionel-Messi
        /// </summary>
        /// <example>https://www.britannica.com/facts/Lionel-Messi</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// A short description of the search result.<br/>
        /// Example: Lionel Messi, an Argentine footballer, is widely regarded as one of the greatest football players of his generation. Born in 1987, Messi spent the majority of his career playing for Barcelona, where he won numerous domestic league titles and UEFA Champions League titles. Messi is known for his exceptional dribbling skills, vision, and goal
        /// </summary>
        /// <example>Lionel Messi, an Argentine footballer, is widely regarded as one of the greatest football players of his generation. Born in 1987, Messi spent the majority of his career playing for Barcelona, where he won numerous domestic league titles and UEFA Champions League titles. Messi is known for his exceptional dribbling skills, vision, and goal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The relevance score of the search result.<br/>
        /// Example: 0.81025416F
        /// </summary>
        /// <example>0.81025416F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// The cleaned and parsed HTML content of the search result. Only if `include_raw_content` is true.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_content")]
        public string? RawContent { get; set; }

        /// <summary>
        /// The favicon URL for the result.<br/>
        /// Example: https://britannica.com/favicon.png
        /// </summary>
        /// <example>https://britannica.com/favicon.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// A list of images extracted from this search result. Only included when `include_images` is `true`. If `include_image_descriptions` is `true`, each item will have `url` and `description`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::G.CreateSearchResponseResultImage>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchResponseResult" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the search result.<br/>
        /// Example: Lionel Messi Facts | Britannica
        /// </param>
        /// <param name="url">
        /// The URL of the search result.<br/>
        /// Example: https://www.britannica.com/facts/Lionel-Messi
        /// </param>
        /// <param name="content">
        /// A short description of the search result.<br/>
        /// Example: Lionel Messi, an Argentine footballer, is widely regarded as one of the greatest football players of his generation. Born in 1987, Messi spent the majority of his career playing for Barcelona, where he won numerous domestic league titles and UEFA Champions League titles. Messi is known for his exceptional dribbling skills, vision, and goal
        /// </param>
        /// <param name="score">
        /// The relevance score of the search result.<br/>
        /// Example: 0.81025416F
        /// </param>
        /// <param name="rawContent">
        /// The cleaned and parsed HTML content of the search result. Only if `include_raw_content` is true.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="favicon">
        /// The favicon URL for the result.<br/>
        /// Example: https://britannica.com/favicon.png
        /// </param>
        /// <param name="images">
        /// A list of images extracted from this search result. Only included when `include_images` is `true`. If `include_image_descriptions` is `true`, each item will have `url` and `description`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSearchResponseResult(
            string? title,
            string? url,
            string? content,
            float? score,
            string? rawContent,
            string? favicon,
            global::System.Collections.Generic.IList<global::G.CreateSearchResponseResultImage>? images)
        {
            this.Title = title;
            this.Url = url;
            this.Content = content;
            this.Score = score;
            this.RawContent = rawContent;
            this.Favicon = favicon;
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchResponseResult" /> class.
        /// </summary>
        public CreateSearchResponseResult()
        {
        }
    }
}