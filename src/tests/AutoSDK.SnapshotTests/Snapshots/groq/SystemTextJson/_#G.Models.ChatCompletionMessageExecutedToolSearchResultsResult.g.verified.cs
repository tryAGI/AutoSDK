//HintName: G.Models.ChatCompletionMessageExecutedToolSearchResultsResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionMessageExecutedToolSearchResultsResult
    {
        /// <summary>
        /// The title of the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The URL of the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The content of the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The relevance score of the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageExecutedToolSearchResultsResult" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the search result
        /// </param>
        /// <param name="url">
        /// The URL of the search result
        /// </param>
        /// <param name="content">
        /// The content of the search result
        /// </param>
        /// <param name="score">
        /// The relevance score of the search result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageExecutedToolSearchResultsResult(
            string? title,
            string? url,
            string? content,
            float? score)
        {
            this.Title = title;
            this.Url = url;
            this.Content = content;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageExecutedToolSearchResultsResult" /> class.
        /// </summary>
        public ChatCompletionMessageExecutedToolSearchResultsResult()
        {
        }
    }
}