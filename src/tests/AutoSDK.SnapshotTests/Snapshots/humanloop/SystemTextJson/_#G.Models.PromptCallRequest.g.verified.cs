//HintName: G.Models.PromptCallRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to call a Prompt (proxied LLM call with logging).
    /// </summary>
    public sealed partial class PromptCallRequest
    {
        /// <summary>
        /// A specific Version ID of the Prompt to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Name of the Environment identifying a deployed version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Path of the Prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// ID for an existing Prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The messages passed to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::G.ChatMessage>? Messages { get; set; }

        /// <summary>
        /// Request to create or update a Prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public global::G.PromptRequest? Prompt { get; set; }

        /// <summary>
        /// The inputs passed to the prompt template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// Identifies where the model was called from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the request/response payloads will be stored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save")]
        public bool? Save { get; set; }

        /// <summary>
        /// Custom Log ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logId")]
        public string? LogId { get; set; }

        /// <summary>
        /// The number of generations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numSamples")]
        public int? NumSamples { get; set; }

        /// <summary>
        /// Whether to return the inputs in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnInputs")]
        public bool? ReturnInputs { get; set; }

        /// <summary>
        /// The ID of the parent Log to nest this Log under.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceParentId")]
        public string? TraceParentId { get; set; }

        /// <summary>
        /// End-user ID related to the Log.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCallRequest" /> class.
        /// </summary>
        /// <param name="versionId">
        /// A specific Version ID of the Prompt to call.
        /// </param>
        /// <param name="environment">
        /// Name of the Environment identifying a deployed version.
        /// </param>
        /// <param name="path">
        /// Path of the Prompt.
        /// </param>
        /// <param name="id">
        /// ID for an existing Prompt.
        /// </param>
        /// <param name="messages">
        /// The messages passed to the provider.
        /// </param>
        /// <param name="prompt">
        /// Request to create or update a Prompt.
        /// </param>
        /// <param name="inputs">
        /// The inputs passed to the prompt template.
        /// </param>
        /// <param name="source">
        /// Identifies where the model was called from.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="save">
        /// Whether the request/response payloads will be stored.
        /// </param>
        /// <param name="logId">
        /// Custom Log ID.
        /// </param>
        /// <param name="numSamples">
        /// The number of generations.
        /// </param>
        /// <param name="returnInputs">
        /// Whether to return the inputs in the response.
        /// </param>
        /// <param name="traceParentId">
        /// The ID of the parent Log to nest this Log under.
        /// </param>
        /// <param name="user">
        /// End-user ID related to the Log.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCallRequest(
            string? versionId,
            string? environment,
            string? path,
            string? id,
            global::System.Collections.Generic.IList<global::G.ChatMessage>? messages,
            global::G.PromptRequest? prompt,
            object? inputs,
            string? source,
            object? metadata,
            bool? save,
            string? logId,
            int? numSamples,
            bool? returnInputs,
            string? traceParentId,
            string? user)
        {
            this.VersionId = versionId;
            this.Environment = environment;
            this.Path = path;
            this.Id = id;
            this.Messages = messages;
            this.Prompt = prompt;
            this.Inputs = inputs;
            this.Source = source;
            this.Metadata = metadata;
            this.Save = save;
            this.LogId = logId;
            this.NumSamples = numSamples;
            this.ReturnInputs = returnInputs;
            this.TraceParentId = traceParentId;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCallRequest" /> class.
        /// </summary>
        public PromptCallRequest()
        {
        }
    }
}