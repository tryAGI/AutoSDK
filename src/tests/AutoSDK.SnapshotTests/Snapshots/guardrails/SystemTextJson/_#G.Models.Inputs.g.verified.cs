//HintName: G.Models.Inputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Input parameters for an iteration.
    /// </summary>
    public sealed partial class Inputs
    {
        /// <summary>
        /// The LLM resource targeted by the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmApi")]
        public string? LlmApi { get; set; }

        /// <summary>
        /// The string output from an external LLM call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llmOutput")]
        public string? LlmOutput { get; set; }

        /// <summary>
        /// The messages for chat models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<object>? Messages { get; set; }

        /// <summary>
        /// Parameters to be formatted into the messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptParams")]
        public object? PromptParams { get; set; }

        /// <summary>
        /// The total number of times the LLM can be called.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numReasks")]
        public int? NumReasks { get; set; }

        /// <summary>
        /// Additional data for Validators.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether to reask for the entire schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullSchemaReask")]
        public bool? FullSchemaReask { get; set; }

        /// <summary>
        /// Whether to use streaming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Inputs" /> class.
        /// </summary>
        /// <param name="llmApi">
        /// The LLM resource targeted by the user.
        /// </param>
        /// <param name="llmOutput">
        /// The string output from an external LLM call.
        /// </param>
        /// <param name="messages">
        /// The messages for chat models.
        /// </param>
        /// <param name="promptParams">
        /// Parameters to be formatted into the messages.
        /// </param>
        /// <param name="numReasks">
        /// The total number of times the LLM can be called.
        /// </param>
        /// <param name="metadata">
        /// Additional data for Validators.
        /// </param>
        /// <param name="fullSchemaReask">
        /// Whether to reask for the entire schema.
        /// </param>
        /// <param name="stream">
        /// Whether to use streaming.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Inputs(
            string? llmApi,
            string? llmOutput,
            global::System.Collections.Generic.IList<object>? messages,
            object? promptParams,
            int? numReasks,
            object? metadata,
            bool? fullSchemaReask,
            bool? stream)
        {
            this.LlmApi = llmApi;
            this.LlmOutput = llmOutput;
            this.Messages = messages;
            this.PromptParams = promptParams;
            this.NumReasks = numReasks;
            this.Metadata = metadata;
            this.FullSchemaReask = fullSchemaReask;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Inputs" /> class.
        /// </summary>
        public Inputs()
        {
        }
    }
}