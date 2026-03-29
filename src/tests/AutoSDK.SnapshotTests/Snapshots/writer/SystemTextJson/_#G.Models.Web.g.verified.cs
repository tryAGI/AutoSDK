//HintName: G.Models.Web.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A web-based reference containing text snippets from online sources accessed during the query.
    /// </summary>
    public sealed partial class Web
    {
        /// <summary>
        /// The exact text snippet from the web source that was used to support the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The URL of the web page where this content was found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The title of the web page where this content was found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Internal score used during the retrieval process for ranking and selecting relevant snippets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Web" /> class.
        /// </summary>
        /// <param name="text">
        /// The exact text snippet from the web source that was used to support the response.
        /// </param>
        /// <param name="url">
        /// The URL of the web page where this content was found.
        /// </param>
        /// <param name="title">
        /// The title of the web page where this content was found.
        /// </param>
        /// <param name="score">
        /// Internal score used during the retrieval process for ranking and selecting relevant snippets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Web(
            string text,
            string url,
            string title,
            double score)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Web" /> class.
        /// </summary>
        public Web()
        {
        }
    }
}