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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseOutputReasoningType Type { get; set; }

        /// <summary>
        /// The unique ID of the reasoning output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Summary items (currently empty).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Summary { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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