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
        [global::Newtonsoft.Json.JsonProperty("effort")]
        public global::G.OneOf<global::G.ChatRequestReasoningEffort?, object>? Effort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public global::G.ChatRequestReasoningSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Constrains effort on reasoning for reasoning models
        /// </param>
        /// <param name="summary"></param>
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