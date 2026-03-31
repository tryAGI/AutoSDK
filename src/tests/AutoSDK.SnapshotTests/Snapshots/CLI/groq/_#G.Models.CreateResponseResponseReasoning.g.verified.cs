//HintName: G.Models.CreateResponseResponseReasoning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for [models that support reasoning](https://console.groq.com/docs/reasoning).
    /// </summary>
    public sealed partial class CreateResponseResponseReasoning
    {
        /// <summary>
        /// The reasoning effort level used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateResponseResponseReasoningEffortJsonConverter))]
        public global::G.CreateResponseResponseReasoningEffort? Effort { get; set; }

        /// <summary>
        /// Not supported. Always null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseResponseReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// The reasoning effort level used.
        /// </param>
        /// <param name="summary">
        /// Not supported. Always null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseResponseReasoning(
            global::G.CreateResponseResponseReasoningEffort? effort,
            string? summary)
        {
            this.Effort = effort;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseResponseReasoning" /> class.
        /// </summary>
        public CreateResponseResponseReasoning()
        {
        }
    }
}