//HintName: G.Models.ChatCompletionMessageExecutedToolSearchResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The search results returned by the tool, if applicable.
    /// </summary>
    public sealed partial class ChatCompletionMessageExecutedToolSearchResults
    {
        /// <summary>
        /// List of search results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionMessageExecutedToolSearchResultsResult>? Results { get; set; }

        /// <summary>
        /// List of image URLs returned by the search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<string>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageExecutedToolSearchResults" /> class.
        /// </summary>
        /// <param name="results">
        /// List of search results
        /// </param>
        /// <param name="images">
        /// List of image URLs returned by the search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionMessageExecutedToolSearchResults(
            global::System.Collections.Generic.IList<global::G.ChatCompletionMessageExecutedToolSearchResultsResult>? results,
            global::System.Collections.Generic.IList<string>? images)
        {
            this.Results = results;
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionMessageExecutedToolSearchResults" /> class.
        /// </summary>
        public ChatCompletionMessageExecutedToolSearchResults()
        {
        }
    }
}