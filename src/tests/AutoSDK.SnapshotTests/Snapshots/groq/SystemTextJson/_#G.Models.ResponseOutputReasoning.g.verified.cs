//HintName: G.Models.ResponseOutputReasoning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A reasoning output from the model. Available for [models that support reasoning](https://console.groq.com/docs/reasoning).
    /// </summary>
    public sealed partial class ResponseOutputReasoning
    {
        /// <summary>
        /// The type of the reasoning output. Always `reasoning`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputReasoningTypeJsonConverter))]
        public global::G.ResponseOutputReasoningType Type { get; set; }

        /// <summary>
        /// The unique ID of the reasoning output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Summary items (currently empty).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputReasoning" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the reasoning output.
        /// </param>
        /// <param name="summary">
        /// Summary items (currently empty).
        /// </param>
        /// <param name="type">
        /// The type of the reasoning output. Always `reasoning`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputReasoning(
            string id,
            global::System.Collections.Generic.IList<object> summary,
            global::G.ResponseOutputReasoningType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputReasoning" /> class.
        /// </summary>
        public ResponseOutputReasoning()
        {
        }
    }
}