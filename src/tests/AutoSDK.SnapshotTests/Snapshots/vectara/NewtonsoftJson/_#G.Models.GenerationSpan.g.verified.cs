//HintName: G.Models.GenerationSpan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The generation by an LLM.
    /// </summary>
    public sealed partial class GenerationSpan
    {
        /// <summary>
        /// This value is always `generation`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Time taken in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency_millis")]
        public int? LatencyMillis { get; set; }

        /// <summary>
        /// When the span started.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The text sent as a prompt to the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The text generated from the LLM.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation")]
        public string? Generation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationSpan" /> class.
        /// </summary>
        /// <param name="type">
        /// This value is always `generation`.
        /// </param>
        /// <param name="latencyMillis">
        /// Time taken in milliseconds.
        /// </param>
        /// <param name="startedAt">
        /// When the span started.
        /// </param>
        /// <param name="prompt">
        /// The text sent as a prompt to the LLM.
        /// </param>
        /// <param name="generation">
        /// The text generated from the LLM.
        /// </param>
        public GenerationSpan(
            string? type,
            int? latencyMillis,
            global::System.DateTime? startedAt,
            string? prompt,
            string? generation)
        {
            this.Type = type;
            this.LatencyMillis = latencyMillis;
            this.StartedAt = startedAt;
            this.Prompt = prompt;
            this.Generation = generation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationSpan" /> class.
        /// </summary>
        public GenerationSpan()
        {
        }
    }
}