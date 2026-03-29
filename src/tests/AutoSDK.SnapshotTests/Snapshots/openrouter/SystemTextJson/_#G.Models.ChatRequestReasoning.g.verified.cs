//HintName: G.Models.ChatRequestReasoning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for reasoning models
    /// </summary>
    public sealed partial class ChatRequestReasoning
    {
        /// <summary>
        /// Constrains effort on reasoning for reasoning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.ChatRequestReasoningEffort?, object>))]
        public global::G.OneOf<global::G.ChatRequestReasoningEffort?, object>? Effort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatRequestReasoningSummaryJsonConverter))]
        public global::G.ChatRequestReasoningSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Constrains effort on reasoning for reasoning models
        /// </param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestReasoning(
            global::G.OneOf<global::G.ChatRequestReasoningEffort?, object>? effort,
            global::G.ChatRequestReasoningSummary? summary)
        {
            this.Effort = effort;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestReasoning" /> class.
        /// </summary>
        public ChatRequestReasoning()
        {
        }
    }
}