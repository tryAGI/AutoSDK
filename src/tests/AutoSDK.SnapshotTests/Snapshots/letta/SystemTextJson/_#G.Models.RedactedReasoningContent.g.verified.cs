//HintName: G.Models.RedactedReasoningContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sent via the Anthropic Messages API
    /// </summary>
    public sealed partial class RedactedReasoningContent
    {
        /// <summary>
        /// Indicates this is a redacted thinking step.<br/>
        /// Default Value: redacted_reasoning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The redacted or filtered intermediate reasoning content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedReasoningContent" /> class.
        /// </summary>
        /// <param name="data">
        /// The redacted or filtered intermediate reasoning content.
        /// </param>
        /// <param name="type">
        /// Indicates this is a redacted thinking step.<br/>
        /// Default Value: redacted_reasoning
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RedactedReasoningContent(
            string data,
            string? type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedReasoningContent" /> class.
        /// </summary>
        public RedactedReasoningContent()
        {
        }
    }
}