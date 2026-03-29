//HintName: G.Models.SummarizedReasoningContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The style of reasoning content returned by the OpenAI Responses API
    /// </summary>
    public sealed partial class SummarizedReasoningContent
    {
        /// <summary>
        /// Indicates this is a summarized reasoning step.<br/>
        /// Default Value: summarized_reasoning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The unique identifier for this reasoning step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Summaries of the reasoning content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.SummarizedReasoningContentPart> Summary { get; set; }

        /// <summary>
        /// The encrypted reasoning content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizedReasoningContent" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for this reasoning step.
        /// </param>
        /// <param name="summary">
        /// Summaries of the reasoning content.
        /// </param>
        /// <param name="type">
        /// Indicates this is a summarized reasoning step.<br/>
        /// Default Value: summarized_reasoning
        /// </param>
        /// <param name="encryptedContent">
        /// The encrypted reasoning content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummarizedReasoningContent(
            string id,
            global::System.Collections.Generic.IList<global::G.SummarizedReasoningContentPart> summary,
            string? type,
            string? encryptedContent)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.EncryptedContent = encryptedContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummarizedReasoningContent" /> class.
        /// </summary>
        public SummarizedReasoningContent()
        {
        }
    }
}