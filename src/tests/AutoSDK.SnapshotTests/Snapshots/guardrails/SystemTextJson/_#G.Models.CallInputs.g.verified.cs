//HintName: G.Models.CallInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The inputs for a Guard Call.
    /// </summary>
    public sealed partial class CallInputs
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
        /// The total number of times the LLM can be called to correct output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numReasks")]
        public int? NumReasks { get; set; }

        /// <summary>
        /// Additional data to be used by Validators during execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether to perform reasks for the entire schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullSchemaReask")]
        public bool? FullSchemaReask { get; set; }

        /// <summary>
        /// Whether to use streaming.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Positional arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<object>? Args { get; set; }

        /// <summary>
        /// Keyword arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kwargs")]
        public object? Kwargs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallInputs" /> class.
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
        /// The total number of times the LLM can be called to correct output.
        /// </param>
        /// <param name="metadata">
        /// Additional data to be used by Validators during execution.
        /// </param>
        /// <param name="fullSchemaReask">
        /// Whether to perform reasks for the entire schema.
        /// </param>
        /// <param name="stream">
        /// Whether to use streaming.
        /// </param>
        /// <param name="args">
        /// Positional arguments.
        /// </param>
        /// <param name="kwargs">
        /// Keyword arguments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallInputs(
            string? llmApi,
            string? llmOutput,
            global::System.Collections.Generic.IList<object>? messages,
            object? promptParams,
            int? numReasks,
            object? metadata,
            bool? fullSchemaReask,
            bool? stream,
            global::System.Collections.Generic.IList<object>? args,
            object? kwargs)
        {
            this.LlmApi = llmApi;
            this.LlmOutput = llmOutput;
            this.Messages = messages;
            this.PromptParams = promptParams;
            this.NumReasks = numReasks;
            this.Metadata = metadata;
            this.FullSchemaReask = fullSchemaReask;
            this.Stream = stream;
            this.Args = args;
            this.Kwargs = kwargs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallInputs" /> class.
        /// </summary>
        public CallInputs()
        {
        }
    }
}