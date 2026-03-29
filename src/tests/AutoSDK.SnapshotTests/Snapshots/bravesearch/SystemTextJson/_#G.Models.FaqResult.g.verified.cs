//HintName: G.Models.FaqResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A FAQ result.
    /// </summary>
    public sealed partial class FaqResult
    {
        /// <summary>
        /// The question.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Source URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Aggregated URL information for a result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_url")]
        public global::G.MetaUrl? MetaUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FaqResult" /> class.
        /// </summary>
        /// <param name="title">
        /// The question.
        /// </param>
        /// <param name="url">
        /// Source URL.
        /// </param>
        /// <param name="answer">
        /// The answer.
        /// </param>
        /// <param name="metaUrl">
        /// Aggregated URL information for a result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FaqResult(
            string? title,
            string? url,
            string? answer,
            global::G.MetaUrl? metaUrl)
        {
            this.Title = title;
            this.Url = url;
            this.Answer = answer;
            this.MetaUrl = metaUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FaqResult" /> class.
        /// </summary>
        public FaqResult()
        {
        }
    }
}